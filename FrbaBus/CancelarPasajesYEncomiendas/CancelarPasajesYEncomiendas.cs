using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;
using FrbaBus.Utilidades;

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
            if (Validador.esNumericoEnteroPositivo(textBoxIdVenta.Text))
            {
                this.cargarGrilla();
            }
            else
            {
                MessageBox.Show("El valor ingresado debe ser un número positivo");
            }
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

            DataTable dt = (DataTable)Venta.TraerPasajesYEncomiendas(Convert.ToInt32(textBoxIdVenta.Text));

            if (dt.Rows.Count == 0) { MessageBox.Show("No se encontraron datos para esa venta"); }
            else
            {
                grillaPasajesYEncomiendas.DataSource = dt;
                grillaPasajesYEncomiendas.Columns.Add(cancelar);
            }

        }

        private void grillaPasajesYEncomiendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grillaPasajesYEncomiendas.Columns.Count - 1)
            {
                var fila = grillaPasajesYEncomiendas.Rows[e.RowIndex];
                confirmarCancelacion modalCancelar = new confirmarCancelacion();
                modalCancelar.tipo  = Convert.ToString(fila.Cells["Tipo"].Value);
                modalCancelar.id = Convert.ToInt32(fila.Cells["id"].Value);
                this.SetVisibleCore(false);
                modalCancelar.ShowDialog();
                modalCancelar.Close();
                this.SetVisibleCore(true);
                cargarGrilla();
            }
        }
    }
}
