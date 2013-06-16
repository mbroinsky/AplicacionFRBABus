using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilidades;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.Canje_de_Ptos
{
    public partial class CanjeDePuntos : Form
    {
        public CanjeDePuntos()
        {
            InitializeComponent();
        }

        int dni;

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

            if (e.ColumnIndex == grillaProductos.Columns.Count - 1)
            {
                var fila = grillaProductos.Rows[e.RowIndex];

                if (Validador.esNumericoEnteroPositivo(Convert.ToString(fila.Cells["Cantidad"].Value)))
                {

                    if (Convert.ToInt32(fila.Cells["Cantidad"].Value) <= Convert.ToInt32(fila.Cells["Stock"].Value))
                        
                    {
                        if(Cliente.totalDePuntos(dni) > (Convert.ToInt32(fila.Cells["Cantidad"].Value) * Convert.ToInt32(fila.Cells["Precio"].Value)))
                        {
                            Cliente.canjearProducto(dni, Convert.ToInt32(fila.Cells["id"].Value), Convert.ToInt32(fila.Cells["Cantidad"].Value));

                            grillaProductos.Columns.Clear();
                            
                            cargarGilla();
                    
                        }
                        else
                        {
                            MessageBox.Show("No dispone de los puntos suficientes para realizar dicha operacion");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cantidad ingresada supera el stock total");
                    }
                }
                else
                {
                    MessageBox.Show("Cantidad debe ser un valor numérico entero mayor a cero");
                }
            }
        }

        private void CanjeDePuntos_Load(object sender, EventArgs e)
        {

        }

        private void campoDNICliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarGilla(){
                
                dni = Convert.ToInt32(campoDNICliente.Text);

                DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
                cantidad.HeaderText = "Cantidad";
                cantidad.Name = "Cantidad";
                cantidad.Visible = true;

                DataGridViewButtonColumn canjearPuntos = new DataGridViewButtonColumn();
                canjearPuntos.HeaderText = "Canjear";
                canjearPuntos.Name = "Canjear";
                canjearPuntos.Visible = true;
                canjearPuntos.UseColumnTextForButtonValue = true;

                DataTable dt = (DataTable)Cliente.productosDisponiblesParaCliente(Convert.ToInt32(campoDNICliente.Text));

                if (dt.Rows.Count == 0) { MessageBox.Show("No se encontraron datos para ese cliente"); }
                else {
                   
                grillaProductos.DataSource = dt;
                grillaProductos.Columns["id"].Visible = false;
                grillaProductos.Columns.Add(cantidad);
                grillaProductos.Columns.Add(canjearPuntos);
                }
        
        }
    }
}
