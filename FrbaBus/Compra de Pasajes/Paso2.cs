using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class Paso2 : Form
    {
        public bool Cancelado { get; set; }

        public Paso2(int pasajesLibres, int kilosLibres)
        {
            InitializeComponent();

            for (int i = 0; i < pasajesLibres; i++)
                cantPasajes.Items.Add(i);

            cantPasajes.SelectedIndex = 0;

            Cancelado = false;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar la compra?",
                "Cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.No)
                return;

            this.Cancelado = true;

            this.Hide();
        }


    }
}
