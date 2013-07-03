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

namespace FrbaBus.Consulta_Puntos_Adquiridos
{
    public partial class ConsultaDePuntos : Form
    {
        public ConsultaDePuntos()
        {
            InitializeComponent();
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
    }
}
