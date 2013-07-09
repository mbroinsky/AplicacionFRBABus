using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Utilidades;

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class Paso2 : Form
    {
        public bool Cancelado { get; set; }
        private int KilosDisponibles;
        public int KilosSeleccionados {get; set; }
        public int CantidadPasajes{get; set;}
        public bool HayDisc { get; set; }

        public Paso2(int pasajesLibres, int kilosLibres)
        {
            InitializeComponent();

            for (int i = 0; i < pasajesLibres; i++)
                cantPasajes.Items.Add(i);

            cantPasajes.SelectedIndex = 0;
            KilosDisponibles = kilosLibres;

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

        private void siguiente_Click(object sender, EventArgs e)
        {
            if (!Validador.esNumericoEnteroPositivo(cantKilos.Text))
            {
                MessageBox.Show("La cantidad de kilos está mal ingresada");
                return;
            }

            if (Convert.ToInt32(cantKilos.Text) > KilosDisponibles)
            {
                MessageBox.Show("La cantidad disponible de kilos es " + Convert.ToString(KilosDisponibles) + 
                    "Kg. Por favor ingrese una cantidad menor");
                return;
            }

            if (Convert.ToInt32(cantKilos.Text) == 0 && Convert.ToInt32(cantPasajes.Text) == 0)
            {
                MessageBox.Show("Si no desea comprar nada, por favor presione el botón 'Cancelar'");
                return;
            }

            if (hayDiscapacitados.Checked)
                MessageBox.Show("Ud. seleccionó que viaja un pasajero con capacidades especiales.\n" +
                    "El primer pasaje que cargue y el de la persona con capacidades especiales serán sin costo.");

            this.CantidadPasajes = Convert.ToInt32(cantPasajes.Text);
            this.KilosSeleccionados = Convert.ToInt32(cantKilos.Text);
            this.HayDisc = hayDiscapacitados.Checked;
            this.Hide();
        }
    }
}
