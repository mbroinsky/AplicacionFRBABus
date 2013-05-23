using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Abm_Permisos;

namespace FrbaBus
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ABMRol_Click(object sender, EventArgs e)
        {
            var selRol = new SeleccionRol();

            if (!Globales.oInstance.usr.TienePermiso(selRol.Name))
            {
                MessageBox.Show("Ud. no tiene permiso para acceder a la pantalla solicitada");
                return;
            }

            selRol.ShowDialog();
        }
        
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AMicro_Click(object sender, EventArgs e)
        {
            var selGestionMicros = new FrbaBus.Abm_Micro.ABMMicro();

            if (!Globales.oInstance.usr.TienePermiso(selGestionMicros.Name))
            {
                MessageBox.Show("Ud. no tiene permiso para acceder a la pantalla solicitada");
                return;
            }

            selGestionMicros.ShowDialog();

        }
    }
}
