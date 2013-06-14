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

        private void listarProductos_Click(object sender, EventArgs e)
        {
            grillaProductos.Columns.Clear();
            if (Validador.esNumericoEnteroPositivo(campoDNICliente.Text))
            {
                DataGridViewColumn canjearPuntos = new DataGridViewButtonColumn();
                canjearPuntos.HeaderText = "Canjear";
                canjearPuntos.Name = "Canjear";
                canjearPuntos.Visible = true;

                grillaProductos.DataSource = Cliente.productosDisponiblesParaCliente(Convert.ToInt32(campoDNICliente.Text));

                grillaProductos.Columns.Add(canjearPuntos);
            }
            else
            {
                MessageBox.Show("El valor ingresado no es numérico");
            }
        }

        private void grillaPuntos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
