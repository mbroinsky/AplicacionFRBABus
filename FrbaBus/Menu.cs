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

            selRol.ShowDialog();
        }
    }
}
