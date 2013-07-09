using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Compra_de_Pasajes;
using FrbaBus.AccesoADatos;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus
{
    public partial class AccesoSistema : Form
    {
        public AccesoSistema()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var log = new Login.Formulario();

            this.SetVisibleCore(false);

            log.ShowDialog();

            if (log.LoginOk)
            {
                var mnu = new FrbaBus.Menu();

                mnu.ShowDialog();
            }

            this.SetVisibleCore(true);
        }

        private void ComprarPasajes_Click(object sender, EventArgs e)
        {
            int cantPasajes;
            int cantKilos;
            double precioPasaje;
            double precioKilo;
            Int64 idVenta;
            Int32 idViaje;
            bool hayDiscap = false;

            var viaje = new Paso1();

            this.SetVisibleCore(false);

            viaje.ShowDialog();

            if (viaje.Cancelado)
            {
                viaje.Close();
                this.SetVisibleCore(true);
                return;
            }

            var selCantidades = new Paso2(viaje.PasajesLibres, viaje.KilosLibres);

            idViaje = viaje.IdViaje;
            precioKilo = viaje.PrecioKilo;
            precioPasaje = viaje.PrecioPasaje;

            viaje.Close();

            selCantidades.ShowDialog();

            if (selCantidades.Cancelado)
            {
                selCantidades.Close();
                this.SetVisibleCore(true);
                return;
            }

            cantPasajes = selCantidades.CantidadPasajes;
            cantKilos = selCantidades.KilosSeleccionados;

            idVenta = Venta.TraerNumerador();

            if(idVenta < 0)
            {
                MessageBox.Show("Ocurrió un error y no se puede continuar con la compra");
                this.SetVisibleCore(true);
                return;
            }

            Conector.Datos.IniciarTransaccion();

            for (int i = 0; i < cantPasajes; i++)
            {
                var pas = new Pasajero(idViaje, hayDiscap);

                pas.ShowDialog();

                if (pas.Cancelado)
                {
                    pas.Close();
                    Conector.Datos.AbortarTransaccion();
                    this.SetVisibleCore(true);
                    return;
                }

                hayDiscap = hayDiscap || pas.HayDiscapacitado;

                var pasaje = new Pasaje();

                Pasaje.Insertar();
            }

            if (cantKilos > 0)
            {
 
            }

            if (hayDiscap)
            {
            }
            else
            { 
            }
            
            Conector.Datos.TerminarTransaccion();

            this.SetVisibleCore(true);
        }
    }
}
