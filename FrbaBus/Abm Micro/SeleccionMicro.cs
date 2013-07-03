using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.Abm_Micro
{
    public partial class SeleccionMicro : Form
    {
        public SeleccionMicro()
        {
            InitializeComponent();


            DataTable comboServicios = Servicio.ListarComboServicio();
            DataRow rowServicios = comboServicios.NewRow();
            rowServicios[0] = DBNull.Value;
            rowServicios[1] = "-TODOS-";
            comboServicios.Rows.Add(rowServicios);
            idServicio.DataSource = comboServicios;
            idServicio.ValueMember = ((DataTable)idServicio.DataSource).Columns[0].ColumnName;
            idServicio.DisplayMember = ((DataTable)idServicio.DataSource).Columns[1].ColumnName;


            DataTable comboMarca = Marca.ListarComboMarca();
            DataRow rowMarca = comboMarca.NewRow();
            rowMarca[0] = DBNull.Value;
            rowMarca[1] = "-TODOS-";
            comboMarca.Rows.Add(rowMarca);
            idMarca.DataSource = comboMarca;
            idMarca.ValueMember = ((DataTable)idMarca.DataSource).Columns[0].ColumnName;
            idMarca.DisplayMember = ((DataTable)idMarca.DataSource).Columns[1].ColumnName;

            cargarComboBoxModelo();

            DataTable butacas = new DataTable();

        }

        private void cargarComboBoxModelo()
        {
                DataTable comboModelo = new DataTable();
                if (!DBNull.Value.Equals(idMarca.SelectedValue))
                {
                    comboModelo = Modelo.ListarComboModelo(Convert.ToInt32(idMarca.SelectedIndex+1));
                }
                else
                {
                    comboModelo.Columns.Add("id", typeof(int));
                    comboModelo.Columns.Add("Modelo", typeof(string));
                }
                DataRow rowModelo = comboModelo.NewRow();
                rowModelo[0] = DBNull.Value;
                rowModelo[1] = "-TODOS-";
                comboModelo.Rows.Add(rowModelo);
                idModelo.DataSource = comboModelo;
                idModelo.ValueMember = ((DataTable)idModelo.DataSource).Columns[0].ColumnName;
                idModelo.DisplayMember = ((DataTable)idModelo.DataSource).Columns[1].ColumnName;

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            this.cargarGrilla();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            var log = new Abm_Micro.ABMMicro();

            this.SetVisibleCore(false);

            log.ShowDialog();

            this.SetVisibleCore(true);
        }

        private void AbrirDialogo(SeleccionMicro aBMMicro)
        {
            throw new NotImplementedException();
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

                Micro.cambiarHabilitado(Convert.ToInt32(fila.Cells["id"].Value), Convert.ToInt32(fila.Cells["Ini. Mantenimiento"].Value));

                Micros.Columns.Clear();
            }

            if (e.ColumnIndex == Micros.Columns.Count - 3)
            {
                var fila = Micros.Rows[e.RowIndex];

                String fechaIni = null;
                String fechaFin = null;

                if (!DBNull.Value.Equals(fila.Cells["Ini. Mantenimiento"].Value)) { fechaIni = Convert.ToString(fila.Cells["Ini. Mantenimiento"].Value); };
                if (!DBNull.Value.Equals(fila.Cells["Fin Mantenimiento"].Value)) { fechaFin = Convert.ToString(fila.Cells["Fin Mantenimiento"].Value); };

                Micro.cambiarEstado(Convert.ToInt32(fila.Cells["id"].Value), fechaIni, fechaFin);

                Micros.Columns.Clear();
            }


            if (e.ColumnIndex == Micros.Columns.Count - 4)
            {
                var fila = Micros.Rows[e.RowIndex];

                var log = new Abm_Micro.ABMMicro(Micro.BuscarMicroPorId(Convert.ToInt32(fila.Cells["id"].Value)));

                this.SetVisibleCore(false);

                log.ShowDialog();

                this.SetVisibleCore(true);
            }

            this.cargarGrilla();
        }

        private void cargarGrilla()
        {
            Micros.Columns.Clear();
            Micros.DataSource = Micro.BuscarMicro(campoMatricula.Text, Convert.ToString(idServicio.SelectedValue), Convert.ToString(idMarca.SelectedValue), Convert.ToString(idModelo.SelectedValue), capacidad.Text);
            /*Columnas para los botones*/

            DataGridViewColumn Modificar = new DataGridViewButtonColumn();
            Modificar.HeaderText = "Modificar";
            Modificar.Name = "Modificar";
            Modificar.Visible = true;

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

            Micros.Columns.Add(Modificar);
            Micros.Columns.Add(enServicio);
            Micros.Columns.Add(Habilitar);
            Micros.Columns.Add(BajaDefinitiva);

            /*Botones*/

            foreach (DataGridViewRow row in Micros.Rows)
            {
                DataGridViewButtonCell btnModificar = new DataGridViewButtonCell();
                btnModificar.UseColumnTextForButtonValue = false;
                btnModificar.Value = "Modificar";

                DataGridViewButtonCell btnEstado = new DataGridViewButtonCell();
                btnEstado.UseColumnTextForButtonValue = false;

                DataGridViewButtonCell btnHabilitar = new DataGridViewButtonCell();
                btnHabilitar.UseColumnTextForButtonValue = false;

                DataGridViewButtonCell btnBajaDefinitiva = new DataGridViewButtonCell();
                btnBajaDefinitiva.UseColumnTextForButtonValue = false;
                btnBajaDefinitiva.Value = "Baja definitiva";

                if (DBNull.Value.Equals(row.Cells["Ini. Mantenimiento"].Value) || (!DBNull.Value.Equals(row.Cells["Ini. Mantenimiento"].Value) && !DBNull.Value.Equals(row.Cells["Fin Mantenimiento"].Value)))
                {
                    btnEstado.Value = "Enviar a Mant.";
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

                row.Cells["Modificar"] = btnModificar;
                row.Cells["Estado del servicio"] = btnEstado;
                row.Cells["Habilitar"] = btnHabilitar;
                row.Cells["Baja Definitiva"] = btnBajaDefinitiva;

            }

            Micros.ClearSelection();
        }

        private void idMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
                cargarComboBoxModelo();
        }
    }
}
