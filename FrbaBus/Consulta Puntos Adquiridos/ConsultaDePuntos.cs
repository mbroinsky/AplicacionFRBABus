using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;
using Utilidades;

namespace FrbaBus.Consulta_Puntos_Adquiridos
{
    public partial class ConsultaDePuntos : Form
    {
        public ConsultaDePuntos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grillaPuntos.Columns.Clear();
            if (Validador.esNumericoEnteroPositivo(campoDNICliente.Text))
            {
                DataTable dt = Cliente.obtenerPuntosCliente(Convert.ToInt32(campoDNICliente.Text));
                if (dt.Rows.Count == 0) { MessageBox.Show("No se encontraron datos para ese cliente"); }
                else { 
                        grillaPuntos.DataSource = dt;
                        totalPuntos.Text = Convert.ToString(Cliente.totalDePuntos(Convert.ToInt32(campoDNICliente.Text)));
                }
            }
            else
            {
                MessageBox.Show("El valor ingresado no es numérico");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grillaPuntos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
