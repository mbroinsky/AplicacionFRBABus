using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;

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
            roles.Columns.Clear(); 
            roles.DataSource = Rol.Listar(nombre.Text);

            if (roles.DataSource != null)
            {
                var btn = new DataGridViewButtonColumn();

                btn.Text = "Modificar";
                btn.Name = "Modificar";
                btn.UseColumnTextForButtonValue = true;
                btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                btn.FlatStyle = FlatStyle.Standard;
                btn.CellTemplate.Style.BackColor = Color.Honeydew;

                roles.Columns.Add(btn);

                btn = new DataGridViewButtonColumn();

                btn.Text = "Deshab/Hab";
                btn.Name = "Deshab/Hab";
                btn.UseColumnTextForButtonValue = true;
                btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                btn.FlatStyle = FlatStyle.Standard;
                btn.CellTemplate.Style.BackColor = Color.Honeydew;

                roles.Columns.Add(btn);

                roles.ClearSelection();
            }
        }
        
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Roles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (roles.SelectedRows.Count == 0)
            {
                return;
            }

            if (e.ColumnIndex == roles.Columns["Modificar"].Index)
            {
                var rol = new Rol(roles.SelectedRows[0]);

                if (!rol.Habilitado)
                {
                    MessageBox.Show("No se puede modificar un rol deshabilitado");
                    return;
                }

                var mod = new ABMRol(rol);

                if (!Globales.oInstance.usr.TienePermiso(mod.Name))
                {
                    MessageBox.Show("Ud. no tiene permiso para acceder a la pantalla solicitada");
                    return;
                }

                mod.ShowDialog();

                roles.DataSource = null;
                roles.Columns.Clear();
            }
            else if (e.ColumnIndex == roles.Columns["Deshab/Hab"].Index)
            {
                var fila = roles.SelectedRows[0];

                var rol = new Rol(fila);

                if (!Globales.oInstance.usr.TienePermiso("DeshabRol"))
                {
                    MessageBox.Show("Ud. no tiene permiso para Deshabilitar/Habilitar rol");
                    return;
                }

                if (rol.Id == Globales.Instance().usr.UsuarioRol.Id)
                {
                    MessageBox.Show("Un usuario no puede deshabilitar su propio rol");
                    return;
                }

                rol.Habilitado = !rol.Habilitado;
                
                rol.Modificar();

                this.Buscar_Click(this.buscar, null);
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            var alta = new ABMRol();

            if (!Globales.oInstance.usr.TienePermiso(alta.Name))
            {
                MessageBox.Show("Ud. no tiene permiso para acceder a la pantalla solicitada");
                return;
            }

            alta.ShowDialog();

            roles.DataSource = null;
            roles.Columns.Clear();
        }
    }
}
