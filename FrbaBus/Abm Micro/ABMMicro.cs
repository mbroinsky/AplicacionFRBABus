using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccesoADatos.Orm;


namespace FrbaBus.Abm_Micro
{
    public partial class ABMMicro : Form
    {
        public ABMMicro()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Micros.Columns.Clear();
            Micros.DataSource = Micro.BuscarMicro(Matrícula.Text, "", "", "", "");
            Micros.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Matrícula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
