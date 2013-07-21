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
            this.roles = new System.Windows.Forms.DataGridView();
            this.buscar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roles
            // 
            this.roles.AllowUserToAddRows = false;
            this.roles.AllowUserToDeleteRows = false;
            this.roles.AllowUserToOrderColumns = true;
            this.roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.roles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roles.Location = new System.Drawing.Point(12, 73);
            this.roles.MultiSelect = false;
            this.roles.Name = "roles";
            this.roles.ReadOnly = true;
            this.roles.RowHeadersVisible = false;
            this.roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roles.ShowEditingIcon = false;
            this.roles.Size = new System.Drawing.Size(336, 269);
            this.roles.TabIndex = 0;
            this.roles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Roles_CellContentClick);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(242, 17);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(90, 19);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(134, 20);
            this.nombre.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.buscar);
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
            // salir
            // 
            this.salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salir.Location = new System.Drawing.Point(273, 353);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(12, 354);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(80, 21);
            this.agregar.TabIndex = 5;
            this.agregar.Text = "Agregar...";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // SeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.salir;
            this.ClientSize = new System.Drawing.Size(361, 388);
            this.ControlBox = false;
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.roles);
            this.Name = "SeleccionRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccion de Rol";
            ((System.ComponentModel.ISupportInitialize)(this.roles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView roles;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button agregar;
    }
}