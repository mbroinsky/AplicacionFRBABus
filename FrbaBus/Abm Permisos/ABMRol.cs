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

            var temp = Funcionalidad.Listar();

            foreach (DataColumn columna in temp.Columns)
            {
                denegados.Columns.Add(columna.ColumnName, columna.ColumnName);
                otorgados.Columns.Add(columna.ColumnName, columna.ColumnName);
            }

            foreach (DataRow fila in temp.Rows)
                denegados.Rows.Add(fila[0], fila[1]);

            denegados.Columns[0].Visible = false;
            denegados.Columns[1].Width = denegados.Width;

            otorgados.Columns[0].Visible = false;
            otorgados.Columns[1].Width = otorgados.Width;
        }

        public ABMRol(Rol rolMod)
        {
            InitializeComponent();

            _Modificacion = true;

            _Rol = rolMod;

            Nombre.Text = _Rol.Nombre;
            Habilitado.Checked = _Rol.Habilitado;

            var temp = Funcionalidad.ListarDenegadasPorRol(_Rol.Id);

            foreach(DataColumn columna in temp.Columns)
                denegados.Columns.Add(columna.ColumnName, columna.ColumnName);
            
            foreach (DataRow fila in temp.Rows)
                denegados.Rows.Add(fila[0], fila[1]);

            denegados.Columns[0].Visible = false;
            denegados.Columns[1].Width = denegados.Width;

            temp = Funcionalidad.ListarPermitidasPorRol(_Rol.Id);

            foreach (DataColumn columna in temp.Columns)
                otorgados.Columns.Add(columna.ColumnName, columna.ColumnName);

            foreach (DataRow fila in temp.Rows)
                otorgados.Rows.Add(fila[0], fila[1]);

            otorgados.Columns[0].Visible = false;
            otorgados.Columns[1].Width = otorgados.Width;
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
                destino.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value);
                origen.Rows.Remove(fila);
            }

            destino.Sort(destino.Columns[1], ListSortDirection.Ascending);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text == "")
            {
                MessageBox.Show("El nombre no puede quedar vacío");
                return;
            }

            if (_Modificacion)
            {
                if (!_Rol.Modificar(Nombre.Text, Habilitado.Checked, otorgados.Rows))
                {
                    MessageBox.Show("Ocurrió un error de actualización");
                    return;
                }
            }
            else
            {
                _Rol = new Rol();

                if (!_Rol.Insertar(Nombre.Text, Habilitado.Checked, otorgados.Rows))
                {
                    MessageBox.Show("Ocurrió un error de actualización");
                    return;
                }
 
            }
            

            this.Close();
        }

        private void denegados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

//probando..