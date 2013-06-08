using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccesoADatos.Orm;
using FrbaBus;

namespace Abm_Recorrido
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
            recorridos.DataSource = Recorrido.Listar(codigo.Text, null, Convert.ToInt32(tipoServicio.SelectedValue), 
                                                  Convert.ToInt32(ciudadOrigen.SelectedValue), 
                                                  Convert.ToInt32(ciudadDestino.SelectedValue));
            
            var btn = new DataGridViewButtonColumn();

            btn.Text = "Modificar";
            btn.Name = "Modificar";
            btn.UseColumnTextForButtonValue = true;
            btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btn.FlatStyle = FlatStyle.Standard;
            btn.CellTemplate.Style.BackColor = Color.Honeydew;

            recorridos.Columns.Add(btn);

            recorridos.ClearSelection();
        }
        
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Roles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == recorridos.Columns.Count - 1)
            {
                var fila = recorridos.SelectedRows[0];

                //var mod = new ABMRecorrido(new Recorrido(fila));

                //if (!Globales.oInstance.usr.TienePermiso(mod.Name))
                //{
                //    MessageBox.Show("Ud. no tiene permiso para acceder a la pantalla solicitada");
                //    return;
                //}

                //mod.ShowDialog();

                //recorridos.DataSource = null;
                //recorridos.Columns.Clear();
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
    }
}
