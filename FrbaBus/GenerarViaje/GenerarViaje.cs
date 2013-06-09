using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccesoADatos.Orm;

namespace FrbaBus.GenerarViaje
{
    public partial class GenerarViaje : Form
    {
        public GenerarViaje()
        {
            InitializeComponent();
            fechaSalida.Value = DateTime.Now;
            fechaLlegada.Value = DateTime.Now;

            Recorrido.ListarCombo(recorridos);

            generar.Enabled = false;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (recorridos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un recorrido");
                return;
            }

            if (fechaSalida.Value <= DateTime.Now)
            {
                MessageBox.Show("Debe seleccionar una fecha mayor a hoy");
                return;
            }

            if (fechaLlegada.Value < fechaSalida.Value)
            {
                MessageBox.Show("La fecha de llegada no puede ser menor a la fecha de salida");
                return;
            }

            if(fechaLlegada.Value.Subtract(fechaSalida.Value).Days > 1)
            {
                MessageBox.Show("Un viaje no puede tardar más de 24 horas");
                return;
            }

            grpMicros.Enabled = true;
            grpPreseleccion.Enabled = false;

            volver.Enabled = true;
            buscar.Enabled = false;
            generar.Enabled = true;
            
            Micro.LlenarComboDisponibles(Convert.ToInt32(recorridos.SelectedValue), fechaSalida.Value, microsDisp);
        }

        private void volver_Click(object sender, EventArgs e)
        {
            grpMicros.Enabled = false;
            grpPreseleccion.Enabled = true;

            volver.Enabled = false;
            buscar.Enabled = true;
            generar.Enabled = false;

            microsDisp.DataSource = null;
        }

        private void generar_Click(object sender, EventArgs e)
        {
            if (microsDisp.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un micro de la lista");
                return;
            }

            var viaje = new Viaje(Convert.ToInt32(microsDisp.SelectedValue),
                                Convert.ToInt32(recorridos.SelectedValue),
                                fechaSalida.Value, fechaLlegada.Value);

            if (!viaje.Insertar())
            {
                MessageBox.Show("Ocurrió un error al insertar el viaje");
                return;
            }

            this.Close();
        }

        private void recorridos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
