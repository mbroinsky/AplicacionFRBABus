using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccesoADatos.Orm;

namespace FrbaBus.Abm_Permisos
{
    public partial class SeleccionRol : Form
    {
        public SeleccionRol()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Roles.DataSource = Rol.Listar(Nombre.Text);
            
            var btn = new DataGridViewButtonColumn();

            btn.Text = "Modificar";
            btn.Name = "Modificar";
            btn.UseColumnTextForButtonValue = true;
            btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btn.FlatStyle = FlatStyle.Standard;
            btn.CellTemplate.Style.BackColor = Color.Honeydew;

            Roles.Columns.Add(btn);

            Roles.ClearSelection();
        }
        
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Roles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Roles.Columns.Count - 1)
            {
                var fila = Roles.SelectedRows[0];

                var mod = new ABMRol(new Rol(fila));

                mod.ShowDialog();
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            var alta = new ABMRol();

            alta.ShowDialog();
        }
    }
}
