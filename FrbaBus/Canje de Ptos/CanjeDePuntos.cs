using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Utilidades;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.Canje_de_Ptos
{
    public partial class CanjeDePuntos : Form
    {
        int dni;

        public CanjeDePuntos()
        {
            InitializeComponent();
        }

        private void listarProductos_Click(object sender, EventArgs e)
        {
            grillaProductos.Columns.Clear();
            
            if (Validador.esNumericoEnteroPositivo(campoDNICliente.Text))
            {
                cargarGilla();
            }
            else
            {
                MessageBox.Show("El valor ingresado no es numérico");
            }
        }

        private void grillaPuntos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Por si toca en el header del boton
            if (grillaProductos.SelectedRows.Count == 0)
                return;

            if (e.ColumnIndex == grillaProductos.Columns.Count - 1)
            {
                var fila = grillaProductos.Rows[e.RowIndex];

                if (Cliente.totalDePuntos(dni) > (Convert.ToInt32(fila.Cells["Precio"].Value)))
                {
                    Cliente.canjearProducto(dni, Convert.ToInt32(fila.Cells["id"].Value), 1);

                    grillaProductos.Columns.Clear();

                    cargarGilla();

                }
                else
                {
                    MessageBox.Show("No dispone de los puntos suficientes para realizar dicha operacion");
                }

            }
        }

        private void cargarGilla()
        {

            dni = Convert.ToInt32(campoDNICliente.Text);

            DataTable dt = (DataTable)Cliente.productosDisponiblesParaCliente(Convert.ToInt32(campoDNICliente.Text));

            if (dt.Rows.Count == 0)
            { 
                MessageBox.Show("No se encontraron productos disponibles para el cliente"); 
            }
            else
            {
                DataGridViewButtonColumn canjearPuntos = new DataGridViewButtonColumn();
                canjearPuntos.HeaderText = "Canjear";
                canjearPuntos.Name = "Canjear";
                canjearPuntos.Text = "Canjear";
                canjearPuntos.Visible = true;
                canjearPuntos.UseColumnTextForButtonValue = true;

                grillaProductos.DataSource = dt;
                grillaProductos.Columns["id"].Visible = false;
                grillaProductos.Columns.Add(canjearPuntos);
            }

        }
    }
}
