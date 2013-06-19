﻿using System;
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

                roles.ClearSelection();
            }
        }
        
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Roles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == roles.Columns.Count - 1)
            {
                if (roles.SelectedRows.Count == 0)
                {
                    return;                    
                }
                
                var fila = roles.SelectedRows[0];

                var mod = new ABMRol(new Rol(fila));

                if (!Globales.oInstance.usr.TienePermiso(mod.Name))
                {
                    MessageBox.Show("Ud. no tiene permiso para acceder a la pantalla solicitada");
                    return;
                }

                mod.ShowDialog();

                roles.DataSource = null;
                roles.Columns.Clear();
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

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
