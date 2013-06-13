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
                grillaPuntos.DataSource = Cliente.obtenerPuntosCliente(Convert.ToInt32(campoDNICliente.Text));
            }
            else
            {
                MessageBox.Show("El valor ingresado no es numérico");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
