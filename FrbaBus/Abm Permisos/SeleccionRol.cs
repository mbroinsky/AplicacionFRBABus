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
            
            var btn = New DataGridViewButtonColumn();
            
            Roles.Columns.Add(btn);
            //btn.HeaderText = ""
            btn.Text = "Modificar";
            btn.Name = "Modificar";
            btn.UseColumnTextForButtonValue = true;
        }
        
        private void Roles_CellClick(object sender, EventArgs e)
        {
            if (e.ColumnIndex = Roles.Columns.Count)
                var mod = new ABMRol();    
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
