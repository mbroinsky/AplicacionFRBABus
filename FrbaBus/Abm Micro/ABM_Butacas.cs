using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Abm_Micro
{
    public partial class ABM_Butacas : Form
    {
        DataTable butacas = new DataTable();
         
                 
        public ABM_Butacas()
        {
            
            DataTable PasilloVentana = new DataTable();
            DataGridViewComboBoxColumn comboBoxPasilloVentana = new DataGridViewComboBoxColumn();     
            InitializeComponent();
            this.Butacas.EditMode = DataGridViewEditMode.EditOnEnter;

            
            butacas.Clear();

            /*Genero el combo box para el Datagridview*/
            PasilloVentana.Columns.Add(new DataColumn("Value", typeof(string)));
            PasilloVentana.Columns.Add(new DataColumn("Description", typeof(string)));
            PasilloVentana.Rows.Add("0", "Pasillo");
            PasilloVentana.Rows.Add("1", "Ventana");

            comboBoxPasilloVentana.HeaderText = "Tipo de Asiento";
            comboBoxPasilloVentana.DataSource = PasilloVentana;
            comboBoxPasilloVentana.ValueMember = "Value";
            comboBoxPasilloVentana.DisplayMember = "Description";

            comboBoxPasilloVentana.DefaultCellStyle.NullValue = "Pasillo";
            
            /*Preparo las columnas de la tabla butacas*/            
            butacas.Columns.Add("idMicro");
            butacas.Columns.Add("Piso");
            butacas.Columns.Add("Nro. Asiento");
            Butacas.DataSource = butacas;
            Butacas.Columns["idMicro"].Visible = false;
            Butacas.Columns.Add(comboBoxPasilloVentana);

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validador.esNumericoEnteroPositivo(cantidad.Text) && Validador.esNumericoEnteroPositivo(piso.Text))
            {
                if (cantidad.Text.Length > 0 && piso.Text.Length > 0)
                {
                    int asientos;
                    for (asientos = 1; asientos <= Convert.ToInt32(cantidad.Text); asientos++)
                    {
                        butacas.Rows.Add(new object[] { 0, Convert.ToInt32(piso.Text), asientos });
                    }
                }
                else
                {
                    MessageBox.Show("Los valores ingresados deben ser mayores a cero");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Los valores ingresados deben ser numéricos");
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            butacas.Clear();
        }

        private void Butacas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void piso_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
