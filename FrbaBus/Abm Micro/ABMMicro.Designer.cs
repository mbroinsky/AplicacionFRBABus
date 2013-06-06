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
            this.campoMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.Label();
            this.idModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.capacidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idMarca = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.Micros = new System.Windows.Forms.DataGridView();
            this.salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Micros)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Capacidad (KG):";
            // 
            // idServicio
            // 
            this.idServicio.FormattingEnabled = true;
            this.idServicio.Location = new System.Drawing.Point(269, 26);
            this.idServicio.Name = "idServicio";
            this.idServicio.Size = new System.Drawing.Size(121, 21);
            this.idServicio.TabIndex = 17;
            this.idServicio.SelectedIndexChanged += new System.EventHandler(this.idServicio_SelectedIndexChanged_1);
            // 
            // campoMatricula
            // 
            this.campoMatricula.Location = new System.Drawing.Point(82, 26);
            this.campoMatricula.MaxLength = 7;
            this.campoMatricula.Name = "campoMatricula";
            this.campoMatricula.Size = new System.Drawing.Size(68, 20);
            this.campoMatricula.TabIndex = 15;
            this.campoMatricula.TextChanged += new System.EventHandler(this.Matrícula_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Modelo:";
            // 
            // matricula
            // 
            this.matricula.AutoSize = true;
            this.matricula.Location = new System.Drawing.Point(10, 30);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(55, 13);
            this.matricula.TabIndex = 16;
            this.matricula.Text = "Matrícula:";
            // 
            // idModelo
            // 
            this.idModelo.FormattingEnabled = true;
            this.idModelo.Location = new System.Drawing.Point(661, 27);
            this.idModelo.Name = "idModelo";
            this.idModelo.Size = new System.Drawing.Size(121, 21);
            this.idModelo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tipo de servicio:";
            // 
            // capacidad
            // 
            this.capacidad.Location = new System.Drawing.Point(904, 26);
            this.capacidad.Name = "capacidad";
            this.capacidad.Size = new System.Drawing.Size(37, 20);
            this.capacidad.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Marca:";
            // 
            // idMarca
            // 
            this.idMarca.FormattingEnabled = true;
            this.idMarca.Location = new System.Drawing.Point(464, 26);
            this.idMarca.Name = "idMarca";
            this.idMarca.Size = new System.Drawing.Size(121, 21);
            this.idMarca.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.idMarca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.idModelo);
            this.groupBox1.Controls.Add(this.capacidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.matricula);
            this.groupBox1.Controls.Add(this.campoMatricula);
            this.groupBox1.Controls.Add(this.idServicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1327, 64);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Micros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(962, 25);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 27;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(1183, 355);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 28;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Micros
            // 
            this.Micros.AllowUserToAddRows = false;
            this.Micros.AllowUserToDeleteRows = false;
            this.Micros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Micros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Micros.Location = new System.Drawing.Point(12, 82);
            this.Micros.Name = "Micros";
            this.Micros.RowHeadersVisible = false;
            this.Micros.Size = new System.Drawing.Size(1327, 267);
            this.Micros.TabIndex = 29;
            this.Micros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Micros_CellContentClick);
            // 
            // salir
            // 
            this.salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salir.Location = new System.Drawing.Point(1264, 355);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 30;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // ABMMicro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.salir;
            this.ClientSize = new System.Drawing.Size(1351, 390);
            this.ControlBox = false;
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Micros);
            this.Controls.Add(this.agregar);
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
        private System.Windows.Forms.TextBox campoMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label matricula;
        private System.Windows.Forms.ComboBox idModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capacidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox idMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView Micros;
        private System.Windows.Forms.Button salir;
    }
}