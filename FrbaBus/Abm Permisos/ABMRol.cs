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

            denegados.DataSource = Funcionalidad.Listar();

            denegados.Columns["Id"].Visible = false;
            denegados.Columns["Funcionalidad"].Width = denegados.Width;
        }
    }
}
