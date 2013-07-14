using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.Abm_Micro
{
    public partial class AlternativaMicro : Form
    {
        public int idViaje;
        public int idRecorrido;
        public DateTime fechaInicio;
        public DateTime fechaFin;

        public AlternativaMicro(int idViaje, int idRecorrido, DateTime fechaInicio)
        {
            InitializeComponent();

            this.idViaje = idViaje;
            this.idRecorrido = idRecorrido;
            this.fechaInicio = fechaInicio;
            
            campoViaje.Text = Convert.ToString(idViaje);
            asignarNuevoMicro.Enabled = false;

        }

        private void buscarMicros_Click(object sender, EventArgs e)
        {
            Micro.LlenarComboDisponibles(idRecorrido, fechaInicio, microsDisp);

            if (microsDisp.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron alternativas");

            }
            else
            {
                asignarNuevoMicro.Enabled = true;

                grpMicros.Enabled = true;

            }

        }

        private void asignarNuevoMicro_Click(object sender, EventArgs e)
        {
            Viaje.actualizarViaje(idViaje, Convert.ToInt32(microsDisp.SelectedValue));
            this.Close();
        }

        private void cancelarPasajes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar todas la ventas asociadas a este viaje?", "Cancelar ventas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Viaje.CancelarTodosLosPasajesYEncomiendas(idViaje, Configuracion.Instance().FechaSistema);
                this.Close();
            }
            
        }
    }
}
