namespace FrbaBus.ListadoEstadistico
{
    partial class SeleccionListado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipoListado = new System.Windows.Forms.ListBox();
            this.lblComienzoSem = new System.Windows.Forms.Label();
            this.lblTipoListado = new System.Windows.Forms.Label();
            this.comienzoSemestre = new System.Windows.Forms.DateTimePicker();
            this.ver = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.resultados = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipoListado);
            this.groupBox1.Controls.Add(this.lblComienzoSem);
            this.groupBox1.Controls.Add(this.lblTipoListado);
            this.groupBox1.Controls.Add(this.comienzoSemestre);
            this.groupBox1.Controls.Add(this.ver);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tipoListado
            // 
            this.tipoListado.FormattingEnabled = true;
            this.tipoListado.Items.AddRange(new object[] {
            "Top 5 destinos con más pasajes comprados",
            "Top 5 destinos con micros más vacíos",
            "Top 5 clientes con más puntos acumulados",
            "Top 5 destinos con pasajes cancelados",
            "Top 5 micros con mayor cantidad de días fuera de servicio"});
            this.tipoListado.Location = new System.Drawing.Point(13, 32);
            this.tipoListado.Name = "tipoListado";
            this.tipoListado.Size = new System.Drawing.Size(299, 82);
            this.tipoListado.TabIndex = 5;
            // 
            // lblComienzoSem
            // 
            this.lblComienzoSem.AutoSize = true;
            this.lblComienzoSem.Location = new System.Drawing.Point(347, 16);
            this.lblComienzoSem.Name = "lblComienzoSem";
            this.lblComienzoSem.Size = new System.Drawing.Size(98, 13);
            this.lblComienzoSem.TabIndex = 4;
            this.lblComienzoSem.Text = "Comienzo semestre";
            // 
            // lblTipoListado
            // 
            this.lblTipoListado.AutoSize = true;
            this.lblTipoListado.Location = new System.Drawing.Point(10, 16);
            this.lblTipoListado.Name = "lblTipoListado";
            this.lblTipoListado.Size = new System.Drawing.Size(128, 13);
            this.lblTipoListado.TabIndex = 3;
            this.lblTipoListado.Text = "Seleccione tipo de listado";
            // 
            // comienzoSemestre
            // 
            this.comienzoSemestre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.comienzoSemestre.Location = new System.Drawing.Point(359, 42);
            this.comienzoSemestre.Name = "comienzoSemestre";
            this.comienzoSemestre.Size = new System.Drawing.Size(86, 20);
            this.comienzoSemestre.TabIndex = 2;
            this.comienzoSemestre.ValueChanged += new System.EventHandler(this.comienzoSemestre_ValueChanged);
            // 
            // ver
            // 
            this.ver.Location = new System.Drawing.Point(370, 91);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(75, 23);
            this.ver.TabIndex = 0;
            this.ver.Text = "Ver";
            this.ver.UseVisualStyleBackColor = true;
            this.ver.Click += new System.EventHandler(this.ver_Click);
            // 
            // salir
            // 
            this.salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salir.Location = new System.Drawing.Point(393, 418);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 1;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            // 
            // resultados
            // 
            this.resultados.AllowUserToAddRows = false;
            this.resultados.AllowUserToDeleteRows = false;
            this.resultados.AllowUserToResizeRows = false;
            this.resultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultados.Location = new System.Drawing.Point(2, 131);
            this.resultados.MultiSelect = false;
            this.resultados.Name = "resultados";
            this.resultados.ReadOnly = true;
            this.resultados.RowHeadersVisible = false;
            this.resultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultados.Size = new System.Drawing.Size(466, 281);
            this.resultados.TabIndex = 2;
            // 
            // SeleccionListado
            // 
            this.AcceptButton = this.ver;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.salir;
            this.ClientSize = new System.Drawing.Size(471, 444);
            this.ControlBox = false;
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.groupBox1);
            this.Name = "SeleccionListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccion de Listados Estadísticos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblComienzoSem;
        private System.Windows.Forms.Label lblTipoListado;
        private System.Windows.Forms.DateTimePicker comienzoSemestre;
        private System.Windows.Forms.Button ver;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.DataGridView resultados;
        private System.Windows.Forms.ListBox tipoListado;
    }
}