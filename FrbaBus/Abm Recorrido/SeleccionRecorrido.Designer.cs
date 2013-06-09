namespace Abm_Recorrido
{
    partial class SeleccionRecorrido
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
            this.recorridos = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblTipoServ = new System.Windows.Forms.Label();
            this.tipoServicio = new System.Windows.Forms.ComboBox();
            this.ciudadDestino = new System.Windows.Forms.ComboBox();
            this.ciudadOrigen = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recorridos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recorridos
            // 
            this.recorridos.AllowUserToAddRows = false;
            this.recorridos.AllowUserToDeleteRows = false;
            this.recorridos.AllowUserToOrderColumns = true;
            this.recorridos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.recorridos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.recorridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recorridos.Location = new System.Drawing.Point(12, 138);
            this.recorridos.MultiSelect = false;
            this.recorridos.Name = "recorridos";
            this.recorridos.ReadOnly = true;
            this.recorridos.RowHeadersVisible = false;
            this.recorridos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recorridos.ShowEditingIcon = false;
            this.recorridos.Size = new System.Drawing.Size(637, 301);
            this.recorridos.TabIndex = 0;
            this.recorridos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Roles_CellContentClick);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(556, 100);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(61, 19);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(188, 20);
            this.codigo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limpiar);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.lblOrigen);
            this.groupBox1.Controls.Add(this.lblTipoServ);
            this.groupBox1.Controls.Add(this.tipoServicio);
            this.groupBox1.Controls.Add(this.ciudadDestino);
            this.groupBox1.Controls.Add(this.ciudadOrigen);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(475, 100);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 10;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(283, 64);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 9;
            this.lblDestino.Text = "Destino";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(6, 64);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 8;
            this.lblOrigen.Text = "Origen";
            // 
            // lblTipoServ
            // 
            this.lblTipoServ.AutoSize = true;
            this.lblTipoServ.Location = new System.Drawing.Point(283, 22);
            this.lblTipoServ.Name = "lblTipoServ";
            this.lblTipoServ.Size = new System.Drawing.Size(84, 13);
            this.lblTipoServ.TabIndex = 7;
            this.lblTipoServ.Text = "Tipo de Servicio";
            // 
            // tipoServicio
            // 
            this.tipoServicio.FormattingEnabled = true;
            this.tipoServicio.Location = new System.Drawing.Point(382, 19);
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.Size = new System.Drawing.Size(207, 21);
            this.tipoServicio.TabIndex = 6;
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.FormattingEnabled = true;
            this.ciudadDestino.Location = new System.Drawing.Point(382, 61);
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.Size = new System.Drawing.Size(207, 21);
            this.ciudadDestino.TabIndex = 5;
            // 
            // ciudadOrigen
            // 
            this.ciudadOrigen.FormattingEnabled = true;
            this.ciudadOrigen.Location = new System.Drawing.Point(60, 61);
            this.ciudadOrigen.Name = "ciudadOrigen";
            this.ciudadOrigen.Size = new System.Drawing.Size(189, 21);
            this.ciudadOrigen.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // Salir
            // 
            this.Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Salir.Location = new System.Drawing.Point(568, 445);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(12, 445);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(80, 21);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar...";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // SeleccionRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Salir;
            this.ClientSize = new System.Drawing.Size(655, 480);
            this.ControlBox = false;
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.recorridos);
            this.Name = "SeleccionRecorrido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccion de Recorrido";
            ((System.ComponentModel.ISupportInitialize)(this.recorridos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView recorridos;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblTipoServ;
        private System.Windows.Forms.ComboBox tipoServicio;
        private System.Windows.Forms.ComboBox ciudadDestino;
        private System.Windows.Forms.ComboBox ciudadOrigen;
        private System.Windows.Forms.Button limpiar;
    }
}