using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using FrbaBus.AccesoADatos.Orm;
using FrbaBus.AccesoADatos;
using System.Windows.Forms;

namespace FrbaBus.Compra_de_Pasajes
{
    static class GenerarCompra
    {
        public static void Generar(Boolean efectivo)
        {
            int cantPasajes;
            double cantKilos;
            double precioPasaje;
            double precioKilo;
            Int32 idViaje;
            bool hayDiscap = false;
            Int16 cantDiscap = 0;
            Venta ven;
            double totalVenta = 0;

            var viaje = new SeleccionDeViaje();
            
            viaje.ShowDialog();

            if (viaje.Cancelado)
            {
                viaje.Close();
                return;
            }

            var selCantidades = new SeleccionDeCantidad(viaje.PasajesLibres, viaje.KilosLibres);

            idViaje = viaje.IdViaje;
            precioKilo = viaje.PrecioKilo;
            precioPasaje = viaje.PrecioPasaje;

            viaje.Close();

            selCantidades.ShowDialog();

            if (selCantidades.Cancelado)
            {
                selCantidades.Close();
                return;
            }

            cantPasajes = selCantidades.CantidadPasajes;
            cantKilos = selCantidades.KilosSeleccionados;
            hayDiscap = selCantidades.HayDisc;

            Conector.Datos.IniciarTransaccion();

            ven = new Venta(Configuracion.Instance().FechaSistema);

            if (!ven.Insertar())
            {
                MessageBox.Show("Ocurrió un error y no se puede continuar con la compra");
                Conector.Datos.AbortarTransaccion();
                return;
            }

            for (int i = 0; i < cantPasajes; i++)
            {
                var pas = new Pasajero(idViaje, hayDiscap, cantDiscap);

                pas.ShowDialog();

                if (pas.Cancelado)
                {
                    pas.Close();
                    Conector.Datos.AbortarTransaccion();
                    return;
                }

                double precio = precioPasaje;

                //Si es el primer pasaje y hay un discapacitado, no se cobra
                if (hayDiscap && i == 0 && !pas.Clie.Discapacitado)
                {
                    MessageBox.Show("El pasaje es sin cargo");
                    precio = 0;
                }
                //Si hay un discapacitado y es el pasajero actual, no se cobra 
                else if (hayDiscap && pas.Clie.Discapacitado)
                {
                    MessageBox.Show("El pasaje es sin cargo");
                    precio = 0;
                    cantDiscap++;
                }
                //Si el primer pasaje fue el del discapacitado, no se cobra el segundo
                else if (hayDiscap && i == 1 && cantDiscap == 1)
                {
                    MessageBox.Show("El pasaje es sin cargo");
                    precio = 0;
                }
                //Si el pasajero es jubilado, se cobra la mitad del pasaje
                else if (pas.Clie.EsJubilado())
                {
                    MessageBox.Show("El pasaje es a mitad de precio por ser jubilado/a");
                    precio = precio / 2;
                }

                if (!Pasaje.Insertar(ven.IdVenta, idViaje, pas.Clie.Id, pas.NumAsiento, pas.IdMicro, precio))
                {
                    MessageBox.Show("Ocurrió un error al cargar el pasaje. Se cancela la operación.");
                    Conector.Datos.AbortarTransaccion();
                    return;
                }

                totalVenta += precio;

                pas.Close();
            }

            if (cantDiscap == 0 && hayDiscap)
            {
                MessageBox.Show("Seleccionó que viaja una persona con capacidades especiales pero no la cargo.\n" +
                    "Se cancela la compra.");
                Conector.Datos.AbortarTransaccion();
                return;
            }

            if (cantKilos > 0)
            {
                var enc = new DatosEncomienda(idViaje, cantKilos);

                enc.ShowDialog();

                if (enc.Cancelado)
                {
                    enc.Close();
                    Conector.Datos.AbortarTransaccion();
                    return;
                }

                double precio = Math.Round(cantKilos * precioKilo, 2);

                if (!Encomienda.Insertar(ven.IdVenta, idViaje, enc.Clie.Id, cantKilos, precio))
                {
                    MessageBox.Show("Ocurrió un error al cargar la encomienda. Se cancela la operación.");
                    Conector.Datos.AbortarTransaccion();
                    return;
                }

                totalVenta += precio;

                enc.Close();
            }

            var pago = new DatosPago(totalVenta, efectivo);

            pago.ShowDialog();

            if (pago.Cancelado)
            {
                pago.Close();
                Conector.Datos.AbortarTransaccion();
                return;
            }

            if (!pago.Efectivo)
                ven.IdTarjeta = pago.Tar.Id;

            ven.IdPagador = pago.Clie.Id;

            pago.Close();

            ven.PrecioTotal = totalVenta;

            if (!ven.Actualizar())
            {
                MessageBox.Show("Ocurrió un error y no se puede continuar con la compra");
                Conector.Datos.AbortarTransaccion();
                return;
            }

            MessageBox.Show("La operación se realizó con éxito.\n Número de voucher: " + Convert.ToString(ven.IdVenta));

            Conector.Datos.TerminarTransaccion();
        }
    }
}
