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

            var temp = Funcionalidad.ListarDenegadasPorRol(_Rol.Id);

            denegados.Columns.Add("Id", "Id");
            denegados.Columns.Add("Funcionalidad", "Funcionalidad");

            foreach (DataRow fila in temp.Rows)
                denegados.Rows.Add(fila["Id"], fila["Funcionalidad"]);

            denegados.Columns["Id"].Visible = false;
            denegados.Columns["Funcionalidad"].Width = denegados.Width;

            temp = Funcionalidad.ListarPermitidasPorRol(_Rol.Id);
            
            otorgados.Columns.Add("Id", "Id");
            otorgados.Columns.Add("Funcionalidad", "Funcionalidad");

            foreach (DataRow fila in temp.Rows)
                otorgados.Rows.Add(fila["Id"], fila["Funcionalidad"]);

            otorgados.Columns["Id"].Visible = false;
            otorgados.Columns["Funcionalidad"].Width = otorgados.Width;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            MoverFilas(denegados, otorgados);
        }

        private void Quitar_Click(object sender, EventArgs e)
        {
            MoverFilas(otorgados, denegados);
        }

        private void QuitarTodo_Click(object sender, EventArgs e)
        {
            otorgados.SelectAll();

            MoverFilas(otorgados, denegados);
        }

        private void AgregarTodo_Click(object sender, EventArgs e)
        {
            denegados.SelectAll();

            MoverFilas(denegados, otorgados);
        }

        private void MoverFilas(DataGridView origen, DataGridView destino)
        {
            foreach (DataGridViewRow fila in origen.SelectedRows)
            {
                destino.Rows.Add(fila.Cells["Id"].Value, fila.Cells["Funcionalidad"].Value);
                origen.Rows.Remove(fila);
            }

            destino.Sort(destino.Columns["Funcionalidad"], ListSortDirection.Ascending);
        }

    }
}

