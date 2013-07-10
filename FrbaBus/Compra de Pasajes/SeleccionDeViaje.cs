using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;


namespace FrbaBus.Compra_de_Pasajes
{
    public partial class SeleccionDeViaje : Form
    {
        public Int32 IdViaje { get; set; }
        public int PasajesLibres { get; set; }
        public double KilosLibres { get; set; }
        public bool Cancelado { get; set; }
        public double PrecioPasaje { get; set; }
        public double PrecioKilo { get; set; }

        public SeleccionDeViaje()
        {
            InitializeComponent();

            Cancelado = false;

            fechaViaje.Value = Configuracion.Instance().FechaSistema;

            Ciudad.LlenarCombo(ciudadOrigen);
            Ciudad.LlenarCombo(ciudadDestino);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (fechaViaje.Value.ToString("dd/MM/yyyy").CompareTo(Configuracion.Instance().FechaSistema.ToString("dd/MM/yyyy")) < 0)
            {
                MessageBox.Show("La fecha de viaje no es válida");
                return;
            }

            if (ciudadDestino.SelectedIndex == ciudadOrigen.SelectedIndex)
            {
                MessageBox.Show("La ciudad de destino no puede coincidir con la de origen");
                return;
            }

            viajesDisponibles.DataSource = Viaje.TraerDisponibles(Convert.ToDateTime(fechaViaje.Value), 
                Convert.ToInt32(ciudadOrigen.SelectedValue), 
                Convert.ToInt32(ciudadDestino.SelectedValue));

            if (viajesDisponibles.DataSource != null)
                viajesDisponibles.Columns["ID"].Visible = false;
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            if (viajesDisponibles.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar un viaje para proseguir con la compra");
                return;
            }

            this.IdViaje = Convert.ToInt32(viajesDisponibles.SelectedRows[0].Cells["ID"].Value);
            this.PasajesLibres = Convert.ToInt32(viajesDisponibles.SelectedRows[0].Cells["Butacas libres"].Value);
            this.KilosLibres = Convert.ToDouble(viajesDisponibles.SelectedRows[0].Cells["Kg. libres"].Value);
            this.PrecioPasaje = Convert.ToDouble(viajesDisponibles.SelectedRows[0].Cells["Precio de pasaje"].Value);
            this.PrecioKilo = Convert.ToDouble(viajesDisponibles.SelectedRows[0].Cells["Precio Encomienda(x Kg)"].Value);

            this.Hide();
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
