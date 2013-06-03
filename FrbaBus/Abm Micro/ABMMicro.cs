using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccesoADatos.Orm;
using FrbaBus.AccesoADatos.Orm;


namespace FrbaBus.Abm_Micro
{
    public partial class ABMMicro : Form
    {
        public ABMMicro()
        {
            InitializeComponent();
            
            idServicio.DataSource = Servicio.ListarComboServicio();
            idServicio.ValueMember = ((DataTable)idServicio.DataSource).Columns[0].ColumnName;
            idServicio.DisplayMember = ((DataTable)idServicio.DataSource).Columns[1].ColumnName;

            idMarca.DataSource = Marca.ListarComboMarca();
            idMarca.ValueMember = ((DataTable)idMarca.DataSource).Columns[0].ColumnName;
            idMarca.DisplayMember = ((DataTable)idMarca.DataSource).Columns[1].ColumnName;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Micros.Columns.Clear();
            Micros.DataSource = Micro.BuscarMicro(campoMatricula.Text, Convert.ToString(idServicio.SelectedValue), Convert.ToString(idMarca.SelectedValue), "", capacidad.Text);
            Micros.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var log = new Abm_Micro.AM_Micro();

            this.SetVisibleCore(false);

            log.ShowDialog();

            this.SetVisibleCore(true);
        }

        private void AbrirDialogo(ABMMicro aBMMicro)
        {
            throw new NotImplementedException();
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

        private void idServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Micros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idServicio_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {

        }
    }
}
