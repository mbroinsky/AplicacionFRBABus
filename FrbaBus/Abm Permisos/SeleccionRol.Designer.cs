namespace FrbaBus.Abm_Permisos
{
    partial class SeleccionRol
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
            this.Roles = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Roles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Roles
            // 
            this.Roles.AllowUserToAddRows = false;
            this.Roles.AllowUserToDeleteRows = false;
            this.Roles.AllowUserToOrderColumns = true;
            this.Roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Roles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Roles.Location = new System.Drawing.Point(12, 73);
            this.Roles.MultiSelect = false;
            this.Roles.Name = "Roles";
            this.Roles.ReadOnly = true;
            this.Roles.RowHeadersVisible = false;
            this.Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Roles.ShowEditingIcon = false;
            this.Roles.Size = new System.Drawing.Size(336, 269);
            this.Roles.TabIndex = 0;
            this.Roles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Roles_CellContentClick);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(242, 17);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(90, 19);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(134, 20);
            this.Nombre.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre Rol";
            // 
            // Salir
            // 
            this.Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Salir.Location = new System.Drawing.Point(273, 353);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(12, 354);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(80, 21);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar...";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // SeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Salir;
            this.ClientSize = new System.Drawing.Size(361, 388);
            this.ControlBox = false;
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Roles);
            this.Name = "SeleccionRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccion de Rol";
            ((System.ComponentModel.ISupportInitialize)(this.Roles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Roles;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Agregar;
    }
}