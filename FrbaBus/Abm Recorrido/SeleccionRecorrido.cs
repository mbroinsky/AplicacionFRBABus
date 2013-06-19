using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.Abm_Recorrido
{
    public partial class SeleccionRecorrido : Form
    {
        public SeleccionRecorrido()
        {
            InitializeComponent();

            tipoServicio.DataSource = Servicio.ListarComboServicio();
            tipoServicio.ValueMember = ((DataTable)tipoServicio.DataSource).Columns[0].ColumnName;
            tipoServicio.DisplayMember = ((DataTable)tipoServicio.DataSource).Columns[1].ColumnName;

            Ciudad.LlenarCombo(ciudadOrigen);
            Ciudad.LlenarCombo(ciudadDestino);

            ciudadOrigen.SelectedIndex = -1;
            ciudadDestino.SelectedIndex = -1;
            tipoServicio.SelectedIndex = -1;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            recorridos.Columns.Clear();

            if (tipoServicio.SelectedIndex == -1 && ciudadOrigen.SelectedIndex == -1 &&
                    ciudadDestino.SelectedIndex == -1)
                recorridos.DataSource = Recorrido.Listar(true, codigo.Text, null, null, null, null);
            else if (tipoServicio.SelectedIndex == -1  && ciudadOrigen.SelectedIndex == -1)
                recorridos.DataSource = Recorrido.Listar(true, codigo.Text, null, null,
                  null, Convert.ToInt32(ciudadDestino.SelectedValue));
            else if (tipoServicio.SelectedIndex == -1  && ciudadDestino.SelectedIndex == -1)
                recorridos.DataSource = Recorrido.Listar(true, codigo.Text, null, null,
                  Convert.ToInt32(ciudadOrigen.SelectedValue), null);
            else if (ciudadOrigen.SelectedIndex == -1 && ciudadDestino.SelectedIndex == -1)
                recorridos.DataSource = Recorrido.Listar(true, codigo.Text, null, 
                    Convert.ToInt32(tipoServicio.SelectedValue), null, null);
            else if (ciudadOrigen.SelectedIndex == -1)
                recorridos.DataSource = Recorrido.Listar(true, codigo.Text, null, Convert.ToInt32(tipoServicio.SelectedValue),
                  null, Convert.ToInt32(ciudadDestino.SelectedValue));
            else if (ciudadDestino.SelectedIndex == -1)
                recorridos.DataSource = Recorrido.Listar(true, codigo.Text, null, Convert.ToInt32(tipoServicio.SelectedValue),
                  Convert.ToInt32(ciudadOrigen.SelectedValue), null);
            else if (tipoServicio.SelectedIndex == -1)
                recorridos.DataSource = Recorrido.Listar(true, codigo.Text, null, null,
                  Convert.ToInt32(ciudadOrigen.SelectedValue), Convert.ToInt32(ciudadDestino.SelectedValue));
            else
                recorridos.DataSource = Recorrido.Listar(true, codigo.Text, null, Convert.ToInt32(tipoServicio.SelectedValue),
                  Convert.ToInt32(ciudadOrigen.SelectedValue), Convert.ToInt32(ciudadDestino.SelectedValue));

            if (((DataTable)recorridos.DataSource).Rows.Count > 0)
            {
                var btnMod = new DataGridViewButtonColumn();

                btnMod.Text = "Modificar";
                btnMod.Name = "Modificar";
                btnMod.UseColumnTextForButtonValue = true;
                btnMod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                btnMod.FlatStyle = FlatStyle.Standard;
                btnMod.CellTemplate.Style.BackColor = Color.Honeydew;

                recorridos.Columns.Add(btnMod);

                var btnDeshab = new DataGridViewButtonColumn();

                btnDeshab.Text = "Deshabilitar";
                btnDeshab.Name = "Deshabilitar";
                btnDeshab.UseColumnTextForButtonValue = true;
                btnDeshab.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                btnDeshab.FlatStyle = FlatStyle.Standard;
                btnDeshab.CellTemplate.Style.BackColor = Color.Honeydew;

                recorridos.Columns.Add(btnDeshab);

                recorridos.ClearSelection();
            }
        }
        
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Roles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == recorridos.Columns["Modificar"].Index)
            {
                var fila = recorridos.SelectedRows[0];

                var mod = new ABMRecorrido(Convert.ToInt32(fila.Cells["ID"].Value));

                if (!Globales.oInstance.usr.TienePermiso(mod.Name))
                {
                    MessageBox.Show("Ud. no tiene permiso para acceder a la pantalla solicitada");
                    return;
                }

                mod.ShowDialog();

                recorridos.DataSource = null;
                recorridos.Columns.Clear();
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            var alta = new ABMRecorrido();

            if (!Globales.oInstance.usr.TienePermiso(alta.Name))
            {
                MessageBox.Show("Ud. no tiene permiso para acceder a la pantalla solicitada");
                return;
            }

            alta.ShowDialog();

            recorridos.DataSource = null;
            recorridos.Columns.Clear();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            codigo.Text = String.Empty;
            ciudadDestino.SelectedIndex = -1;
            ciudadOrigen.SelectedIndex = -1;
            tipoServicio.SelectedIndex = -1;
        }
    }
}
