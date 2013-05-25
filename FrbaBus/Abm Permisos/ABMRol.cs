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

namespace FrbaBus.Abm_Permisos
{
    public partial class ABMRol : Form
    {
        private Boolean _Modificacion;
        private Rol _Rol;

        public ABMRol()
        {
            InitializeComponent();

            _Modificacion = false;

            denegados.DataSource = Funcionalidad.Listar();

            denegados.Columns["Id"].Visible = false;
        }

        public ABMRol(Rol rolMod)
        {
            InitializeComponent();

            _Modificacion = true;

            _Rol = rolMod;

            Nombre.Text = _Rol.Nombre;
            Habilitado.Checked = _Rol.Habilitado;

            denegados.DataSource = Funcionalidad.ListarDenegadasPorRol(_Rol.Id);

            denegados.Columns["Id"].Visible = false;
            denegados.Columns["Funcionalidad"].Width = denegados.Width;

            otorgados.DataSource = Funcionalidad.ListarPermitidasPorRol(_Rol.Id);

            otorgados.Columns["Id"].Visible = false;
            otorgados.Columns["Funcionalidad"].Width = otorgados.Width;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < denegados.SelectedRows.Count - 1; i++)
            {
                otorgados.Rows.Add(denegados.SelectedRows[i]);
                denegados.Rows.Remove(denegados.SelectedRows[i]);
            }

            otorgados.Sort(otorgados.Columns["Nombre"], ListSortDirection.Ascending);
        }

        private void Quitar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= otorgados.SelectedRows.Count - 1; i++)
            {
                denegados.Rows.Add(otorgados.SelectedRows[i]);
                otorgados.Rows.Remove(otorgados.SelectedRows[i]);
            }

            denegados.Sort(denegados.Columns["Funcionalidad"], ListSortDirection.Ascending);
        }

        private void QuitarTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < otorgados.Rows.Count - 1; i++)
            {
                denegados.Rows.Add(otorgados.Rows[i]);
                otorgados.Rows.Remove(otorgados.Rows[i]);
            }

            denegados.Sort(denegados.Columns["Nombre"], ListSortDirection.Ascending);
        }

        private void AgregarTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < denegados.Rows.Count - 1; i++)
            {
                otorgados.Rows.Add(denegados.Rows[i]);
                denegados.Rows.Remove(denegados.Rows[i]);
            }

            otorgados.Sort(otorgados.Columns["Nombre"], ListSortDirection.Ascending);
        }



    }
}

