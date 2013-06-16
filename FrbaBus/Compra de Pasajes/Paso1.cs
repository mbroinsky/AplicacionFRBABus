using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccesoADatos.Orm;

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class Paso1 : Form
    {
        public Paso1()
        {
            InitializeComponent();

            fechaViaje.Value = Configuracion.Instance().FechaSistema;

            Ciudad.LlenarCombo(ciudadOrigen);
            Ciudad.LlenarCombo(ciudadDestino);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (fechaViaje.Value <= Configuracion.Instance().FechaSistema)
            {
                MessageBox.Show("La fecha de viaje no es válida");
                return;
            }

            if (ciudadDestino.SelectedIndex == ciudadOrigen.SelectedIndex)
            {
                MessageBox.Show("La ciudad de destino no puede coincider con la de origen");
                return;
            }

            viajesDisponibles.DataSource = Viaje.TraerDisponibles(Convert.ToDateTime(fechaViaje.Value), 
                Convert.ToInt32(ciudadOrigen.SelectedValue), 
                Convert.ToInt32(ciudadDestino.SelectedValue));
        }

    }
}
