using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.Consulta_Puntos_Adquiridos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grillaPuntos.Columns.Clear();
            grillaPuntos.DataSource = Cliente.obtenerPuntosCliente(10);

        }
    }
}
