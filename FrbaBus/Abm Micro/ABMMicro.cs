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

            DataTable butacas = new DataTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cargarGrilla();
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

            if (e.ColumnIndex == Micros.Columns.Count - 1)
            {

                if (MessageBox.Show("¿Está seguro que quiere dar de baja el micro en forma definitiva?", "Baja definitiva", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var fila = Micros.Rows[e.RowIndex];

                    Micro.bajaDefinitiva(Convert.ToInt32(fila.Cells["id"].Value));

                    Micros.Columns.Clear();

                }

            }

            if (e.ColumnIndex == Micros.Columns.Count - 2)
            {
                var fila = Micros.Rows[e.RowIndex];

                Micro.cambiarHabilitado(Convert.ToInt32(fila.Cells["id"].Value), Convert.ToInt32(fila.Cells["Habilitado"].Value));

                Micros.Columns.Clear();
            }

            if (e.ColumnIndex == Micros.Columns.Count - 3)
            {
                var fila = Micros.Rows[e.RowIndex];

                Micro.cambiarEstado(Convert.ToInt32(fila.Cells["id"].Value), Convert.ToInt32(fila.Cells["Fuera de Servicio"].Value));

                Micros.Columns.Clear();
            }

            this.cargarGrilla();
        }

        private void idServicio_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {

        }

        private void cargarGrilla()
        {
            Micros.Columns.Clear();
            Micros.DataSource = Micro.BuscarMicro(campoMatricula.Text, Convert.ToString(idServicio.SelectedValue), Convert.ToString(idMarca.SelectedValue), "", capacidad.Text);
            /*Columnas para los botones*/

            DataGridViewColumn enServicio = new DataGridViewButtonColumn();
            enServicio.HeaderText = "Estado del servicio";
            enServicio.Name = "Estado del servicio";
            enServicio.Visible = true;

            DataGridViewColumn Habilitar = new DataGridViewButtonColumn();
            Habilitar.HeaderText = "Habilitar";
            Habilitar.Name = "Habilitar";
            Habilitar.Visible = true;

            DataGridViewColumn BajaDefinitiva = new DataGridViewButtonColumn();
            BajaDefinitiva.HeaderText = "Baja Definitiva";
            BajaDefinitiva.Name = "Baja Definitiva";
            BajaDefinitiva.Visible = true;

            Micros.Columns.Add(enServicio);
            Micros.Columns.Add(Habilitar);
            Micros.Columns.Add(BajaDefinitiva);

            /*Botones*/

            foreach (DataGridViewRow row in Micros.Rows)
            {
                DataGridViewButtonCell btnEstado = new DataGridViewButtonCell();
                btnEstado.UseColumnTextForButtonValue = false;

                DataGridViewButtonCell btnHabilitar = new DataGridViewButtonCell();
                btnHabilitar.UseColumnTextForButtonValue = false;

                DataGridViewButtonCell btnBajaDefinitiva = new DataGridViewButtonCell();
                btnBajaDefinitiva.UseColumnTextForButtonValue = false;
                btnBajaDefinitiva.Value = "Baja definitiva";

                if (Convert.ToInt32(row.Cells["Fuera de Servicio"].Value) == 0)
                {
                    btnEstado.Value = "Sacar de servicio";
                }
                else
                {
                    btnEstado.Value = "Reincorporar";
                }

                if (Convert.ToInt32(row.Cells["Habilitado"].Value) == 0)
                {
                    btnHabilitar.Value = "Habilitar";
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    btnHabilitar.Value = "Deshabilitar";
                }

                row.Cells["Estado del servicio"] = btnEstado;
                row.Cells["Habilitar"] = btnHabilitar;
                row.Cells["Baja Definitiva"] = btnBajaDefinitiva;

            }

            Micros.ClearSelection();
        }
    }
}
