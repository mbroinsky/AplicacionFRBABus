namespace FrbaBus.Abm_Micro
{
    partial class ABMMicro
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.idServicio = new System.Windows.Forms.ComboBox();
            this.Matrícula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.idModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.capacidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idMarca = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Micros = new System.Windows.Forms.DataGridView();
            this.matricula_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado_grid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.marca_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_alta_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuera_de_servicio_grid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fecha_reinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Micros)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Capacidad (KG):";
            // 
            // idServicio
            // 
            this.idServicio.FormattingEnabled = true;
            this.idServicio.Location = new System.Drawing.Point(265, 27);
            this.idServicio.Name = "idServicio";
            this.idServicio.Size = new System.Drawing.Size(121, 21);
            this.idServicio.TabIndex = 17;
            // 
            // Matrícula
            // 
            this.Matrícula.Location = new System.Drawing.Point(78, 27);
            this.Matrícula.MaxLength = 7;
            this.Matrícula.Name = "Matrícula";
            this.Matrícula.Size = new System.Drawing.Size(68, 20);
            this.Matrícula.TabIndex = 15;
            this.Matrícula.TextChanged += new System.EventHandler(this.Matrícula_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Modelo:";
            // 
            // matricula
            // 
            this.matricula.AutoSize = true;
            this.matricula.Location = new System.Drawing.Point(6, 31);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(55, 13);
            this.matricula.TabIndex = 16;
            this.matricula.Text = "Matrícula:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Agregar butacas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // idModelo
            // 
            this.idModelo.FormattingEnabled = true;
            this.idModelo.Location = new System.Drawing.Point(465, 27);
            this.idModelo.Name = "idModelo";
            this.idModelo.Size = new System.Drawing.Size(121, 21);
            this.idModelo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tipo de servicio:";
            // 
            // capacidad
            // 
            this.capacidad.Location = new System.Drawing.Point(900, 27);
            this.capacidad.Name = "capacidad";
            this.capacidad.Size = new System.Drawing.Size(37, 20);
            this.capacidad.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Marca:";
            // 
            // idMarca
            // 
            this.idMarca.FormattingEnabled = true;
            this.idMarca.Location = new System.Drawing.Point(660, 27);
            this.idMarca.Name = "idMarca";
            this.idMarca.Size = new System.Drawing.Size(121, 21);
            this.idMarca.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.idMarca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.capacidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.idModelo);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.matricula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Matrícula);
            this.groupBox1.Controls.Add(this.idServicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 64);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Micros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(962, 25);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 27;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Micros
            // 
            this.Micros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Micros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula_grid,
            this.servicio_grid,
            this.capacidad_grid,
            this.habilitado_grid,
            this.marca_grid,
            this.modelo_grid,
            this.fecha_alta_grid,
            this.fuera_de_servicio_grid,
            this.fecha_reinicio,
            this.fecha_baja});
            this.Micros.Location = new System.Drawing.Point(12, 82);
            this.Micros.Name = "Micros";
            this.Micros.Size = new System.Drawing.Size(1043, 267);
            this.Micros.TabIndex = 28;
            this.Micros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // matricula_grid
            // 
            this.matricula_grid.HeaderText = "Matrícula";
            this.matricula_grid.Name = "matricula_grid";
            this.matricula_grid.ReadOnly = true;
            // 
            // servicio_grid
            // 
            this.servicio_grid.HeaderText = "Tpo. Serv";
            this.servicio_grid.Name = "servicio_grid";
            this.servicio_grid.ReadOnly = true;
            // 
            // capacidad_grid
            // 
            this.capacidad_grid.HeaderText = "Capacidad";
            this.capacidad_grid.Name = "capacidad_grid";
            this.capacidad_grid.ReadOnly = true;
            // 
            // habilitado_grid
            // 
            this.habilitado_grid.HeaderText = "Habilitado";
            this.habilitado_grid.Name = "habilitado_grid";
            this.habilitado_grid.ReadOnly = true;
            // 
            // marca_grid
            // 
            this.marca_grid.HeaderText = "Marca";
            this.marca_grid.Name = "marca_grid";
            this.marca_grid.ReadOnly = true;
            // 
            // modelo_grid
            // 
            this.modelo_grid.HeaderText = "Modelo";
            this.modelo_grid.Name = "modelo_grid";
            this.modelo_grid.ReadOnly = true;
            // 
            // fecha_alta_grid
            // 
            this.fecha_alta_grid.HeaderText = "Fec. Alta";
            this.fecha_alta_grid.Name = "fecha_alta_grid";
            this.fecha_alta_grid.ReadOnly = true;
            // 
            // fuera_de_servicio_grid
            // 
            this.fuera_de_servicio_grid.HeaderText = "En servicio";
            this.fuera_de_servicio_grid.Name = "fuera_de_servicio_grid";
            this.fuera_de_servicio_grid.ReadOnly = true;
            // 
            // fecha_reinicio
            // 
            this.fecha_reinicio.HeaderText = "Fec. Reinicio";
            this.fecha_reinicio.Name = "fecha_reinicio";
            this.fecha_reinicio.ReadOnly = true;
            // 
            // fecha_baja
            // 
            this.fecha_baja.HeaderText = "Fec. Baja";
            this.fecha_baja.Name = "fecha_baja";
            this.fecha_baja.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(980, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ABMMicro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Micros);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABMMicro";
            this.Text = "Gestión de Micros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Micros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox idServicio;
        private System.Windows.Forms.TextBox Matrícula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label matricula;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox idModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capacidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox idMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Micros;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad_grid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitado_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_alta_grid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fuera_de_servicio_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_reinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_baja;
        private System.Windows.Forms.Button Buscar;
    }
}