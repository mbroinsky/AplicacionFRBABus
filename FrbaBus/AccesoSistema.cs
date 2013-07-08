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
            Int64 idVoucher;

            var venta = new Paso1();

            this.SetVisibleCore(false);

            venta.ShowDialog();

            if (venta.Cancelado)
            {
                venta.Close();
                this.SetVisibleCore(true);
                return;
            }

            var selCantidades = new Paso2(venta.PasajesLibres, venta.KilosLibres);

            venta.Close();

            selCantidades.ShowDialog();

            if (selCantidades.Cancelado)
            {
                selCantidades.Close();
                this.SetVisibleCore(true);
                return;
            }

            cantPasajes = selCantidades.CantidadPasajes;
            cantKilos = selCantidades.KilosSeleccionados;

            idVoucher = Venta.TraerNumerador();

            if(idVoucher < 0)
            {
                MessageBox.Show("Ocurrió un error y no se puede continuar con la compra");
                this.SetVisibleCore(true);
                return;
            }

            for (int i = 0; i < cantPasajes; i++)
            {
                var pas = new Pasajero();

                pas.ShowDialog();

                if (pas.Cancelado)
                {
                    pas.Close();
                    this.SetVisibleCore(true);
                    return;
                }
            }

            if (cantKilos > 0)
            {
 
            }

            Conector.Datos.IniciarTransaccion();

            //Butaca.BorrarReservas(idVoucher);
            
            Conector.Datos.TerminarTransaccion();

            this.SetVisibleCore(true);
        }
    }
}
