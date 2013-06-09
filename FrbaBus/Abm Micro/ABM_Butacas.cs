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
        public DataTable butacas{get;set;}
        public DataGridViewComboBoxColumn comboBoxPasilloVentana;

        public ABM_Butacas()
        {
            InitializeComponent();
            butacas = new DataTable();
            butacas.Columns.Add("idMicro");
            butacas.Columns.Add("Piso");
            butacas.Columns.Add("Nro. Asiento");
            butacas.Columns.Add("Tipo de Asiento");
            prepararGrilla();

            
           // Butacas.Columns["idMicro"].Visible = false;
        }

        public ABM_Butacas(DataTable butacasMicro)
        {
            InitializeComponent();
            butacas = new DataTable(); 
            this.butacas = butacasMicro;
            prepararGrilla();
           
            //Butacas.Columns["idMicro"].Visible = false;

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
                        butacas.Rows.Add(new object[] { 0, Convert.ToInt32(piso.Text), asientos, "Pasillo" });
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
            this.SetVisibleCore(false);
        }

        private void prepararGrilla()
        {
            
            Butacas.Columns.Clear();

            DataGridViewColumn cMicro = new DataGridViewTextBoxColumn();;
            cMicro.HeaderText = "idMicro";
            cMicro.DataPropertyName = "idMicro";

            DataGridViewColumn cPiso = new DataGridViewTextBoxColumn();
            cPiso.HeaderText = "Piso";
            cPiso.DataPropertyName = "Piso";

            DataGridViewColumn cNroAsiento = new DataGridViewTextBoxColumn();
            cNroAsiento.HeaderText = "Nro. Asiento";
            cNroAsiento.DataPropertyName = "Nro. Asiento";


            DataGridViewComboBoxColumn cTipoDeAsiento = new DataGridViewComboBoxColumn();
            var tipo = new List<string>() { "Pasillo", "Ventanilla" };
            cTipoDeAsiento.DataSource = tipo;
            cTipoDeAsiento.HeaderText = "Tipo de Asiento";
            cTipoDeAsiento.DataPropertyName = "Tipo de Asiento";

            Butacas.Columns.AddRange(cMicro, cPiso, cNroAsiento, cTipoDeAsiento);

            Butacas.DataSource = butacas;

           
        }

    }
}
