﻿namespace FrbaBus.Abm_Permisos
{
    partial class ABMRol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.denegados = new System.Windows.Forms.DataGridView();
            this.otorgados = new System.Windows.Forms.DataGridView();
            this.Quitar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.QuitarTodo = new System.Windows.Forms.Button();
            this.AgregarTodo = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.lblDenegados = new System.Windows.Forms.Label();
            this.lblOtorgados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.denegados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otorgados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(68, 274);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 1;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Location = new System.Drawing.Point(169, 274);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // denegados
            // 
            this.denegados.AllowUserToAddRows = false;
            this.denegados.AllowUserToDeleteRows = false;
            this.denegados.AllowUserToResizeColumns = false;
            this.denegados.AllowUserToResizeRows = false;
            this.denegados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.denegados.ColumnHeadersVisible = false;
            this.denegados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.denegados.Location = new System.Drawing.Point(6, 60);
            this.denegados.Name = "denegados";
            this.denegados.RowHeadersVisible = false;
            this.denegados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.denegados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.denegados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.denegados.ShowEditingIcon = false;
            this.denegados.Size = new System.Drawing.Size(128, 192);
            this.denegados.TabIndex = 3;
            // 
            // otorgados
            // 
            this.otorgados.AllowUserToAddRows = false;
            this.otorgados.AllowUserToDeleteRows = false;
            this.otorgados.AllowUserToResizeColumns = false;
            this.otorgados.AllowUserToResizeRows = false;
            this.otorgados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.otorgados.ColumnHeadersVisible = false;
            this.otorgados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.otorgados.Location = new System.Drawing.Point(181, 60);
            this.otorgados.Name = "otorgados";
            this.otorgados.RowHeadersVisible = false;
            this.otorgados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.otorgados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.otorgados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.otorgados.Size = new System.Drawing.Size(125, 192);
            this.otorgados.TabIndex = 4;
            // 
            // Quitar
            // 
            this.Quitar.Location = new System.Drawing.Point(140, 127);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(35, 23);
            this.Quitar.TabIndex = 5;
            this.Quitar.Text = "<";
            this.Quitar.UseVisualStyleBackColor = true;
            this.Quitar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(140, 156);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(35, 23);
            this.Agregar.TabIndex = 6;
            this.Agregar.Text = ">";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // QuitarTodo
            // 
            this.QuitarTodo.Location = new System.Drawing.Point(140, 185);
            this.QuitarTodo.Name = "QuitarTodo";
            this.QuitarTodo.Size = new System.Drawing.Size(35, 23);
            this.QuitarTodo.TabIndex = 7;
            this.QuitarTodo.Text = "<<";
            this.QuitarTodo.UseVisualStyleBackColor = true;
            this.QuitarTodo.Click += new System.EventHandler(this.QuitarTodo_Click);
            // 
            // AgregarTodo
            // 
            this.AgregarTodo.Location = new System.Drawing.Point(140, 214);
            this.AgregarTodo.Name = "AgregarTodo";
            this.AgregarTodo.Size = new System.Drawing.Size(35, 23);
            this.AgregarTodo.TabIndex = 8;
            this.AgregarTodo.Text = ">>";
            this.AgregarTodo.UseVisualStyleBackColor = true;
            this.AgregarTodo.Click += new System.EventHandler(this.AgregarTodo_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(58, 12);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(156, 20);
            this.Nombre.TabIndex = 9;
            // 
            // lblDenegados
            // 
            this.lblDenegados.AutoSize = true;
            this.lblDenegados.Location = new System.Drawing.Point(3, 39);
            this.lblDenegados.Name = "lblDenegados";
            this.lblDenegados.Size = new System.Drawing.Size(105, 13);
            this.lblDenegados.TabIndex = 11;
            this.lblDenegados.Text = "Permisos denegados";
            // 
            // lblOtorgados
            // 
            this.lblOtorgados.AutoSize = true;
            this.lblOtorgados.Location = new System.Drawing.Point(178, 39);
            this.lblOtorgados.Name = "lblOtorgados";
            this.lblOtorgados.Size = new System.Drawing.Size(99, 13);
            this.lblOtorgados.TabIndex = 12;
            this.lblOtorgados.Text = "Permisos otorgados";
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelar;
            this.ClientSize = new System.Drawing.Size(318, 309);
            this.ControlBox = false;
            this.Controls.Add(this.lblOtorgados);
            this.Controls.Add(this.lblDenegados);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.AgregarTodo);
            this.Controls.Add(this.QuitarTodo);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Quitar);
            this.Controls.Add(this.otorgados);
            this.Controls.Add(this.denegados);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.lblNombre);
            this.Name = "ABMRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM de Rol";
            ((System.ComponentModel.ISupportInitialize)(this.denegados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otorgados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DataGridView denegados;
        private System.Windows.Forms.DataGridView otorgados;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button QuitarTodo;
        private System.Windows.Forms.Button AgregarTodo;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label lblDenegados;
        private System.Windows.Forms.Label lblOtorgados;
    }
}
