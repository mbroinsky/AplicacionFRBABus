using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.CancelarPasajesYEncomiendas
{
    public partial class CancelarPasajesYEncomiendas : Form
    {

        public CancelarPasajesYEncomiendas()
        {
            InitializeComponent();
        }

        private void buscarPasajesYEncomiendas_Click(object sender, EventArgs e)
        {
            this.cargarGrilla();
        }

        private void cargarGrilla()
        {
            grillaPasajesYEncomiendas.Columns.Clear();

            DataGridViewButtonColumn cancelar = new DataGridViewButtonColumn();
            cancelar.HeaderText = "Cancelar";
            cancelar.Name = "Cancelar";
            cancelar.Text = "Cancelar";
            cancelar.Visible = true;
            cancelar.UseColumnTextForButtonValue = true;

            DataTable dt = (DataTable)Venta.traerPasajesYEncomiendas(Convert.ToInt32(textBoxIdVenta.Text));

            if (dt.Rows.Count == 0) { MessageBox.Show("No se encontraron datos para esa venta"); }
            else
            {
                grillaPasajesYEncomiendas.DataSource = dt;
                grillaPasajesYEncomiendas.Columns.Add(cancelar);
            }

        }

    }
}
