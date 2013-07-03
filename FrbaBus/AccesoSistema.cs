using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Compra_de_Pasajes;

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
            var venta = new Paso1();

            this.SetVisibleCore(false);

            venta.ShowDialog();

            if (venta.Cancelado)
            {
                venta.Close();
                this.SetVisibleCore(true);
                return;
            }

            var paso2 = new Paso2(venta.PasajesLibres, venta.KilosLibres);

            paso2.ShowDialog();

            this.SetVisibleCore(true);
        }
    }
}
