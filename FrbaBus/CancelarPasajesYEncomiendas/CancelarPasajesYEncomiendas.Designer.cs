namespace FrbaBus.CancelarPasajesYEncomiendas
{
    partial class CancelarPasajesYEncomiendas
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
            this.grillaPasajesYEncomiendas = new System.Windows.Forms.DataGridView();
            this.buscarPasajesYEncomiendas = new System.Windows.Forms.Button();
            this.textBoxIdVenta = new System.Windows.Forms.MaskedTextBox();
            this.etiquetaNumeroDeVenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPasajesYEncomiendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grillaPasajesYEncomiendas
            // 
            this.grillaPasajesYEncomiendas.AllowUserToAddRows = false;
            this.grillaPasajesYEncomiendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaPasajesYEncomiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPasajesYEncomiendas.Location = new System.Drawing.Point(12, 81);
            this.grillaPasajesYEncomiendas.Name = "grillaPasajesYEncomiendas";
            this.grillaPasajesYEncomiendas.ReadOnly = true;
            this.grillaPasajesYEncomiendas.RowHeadersVisible = false;
            this.grillaPasajesYEncomiendas.Size = new System.Drawing.Size(523, 287);
            this.grillaPasajesYEncomiendas.TabIndex = 0;
            this.grillaPasajesYEncomiendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPasajesYEncomiendas_CellContentClick);
            // 
            // buscarPasajesYEncomiendas
            // 
            this.buscarPasajesYEncomiendas.Location = new System.Drawing.Point(465, 13);
            this.buscarPasajesYEncomiendas.Name = "buscarPasajesYEncomiendas";
            this.buscarPasajesYEncomiendas.Size = new System.Drawing.Size(52, 43);
            this.buscarPasajesYEncomiendas.TabIndex = 1;
            this.buscarPasajesYEncomiendas.Text = "Buscar";
            this.buscarPasajesYEncomiendas.UseVisualStyleBackColor = true;
            this.buscarPasajesYEncomiendas.Click += new System.EventHandler(this.buscarPasajesYEncomiendas_Click);
            // 
            // textBoxIdVenta
            // 
            this.textBoxIdVenta.Location = new System.Drawing.Point(77, 27);
            this.textBoxIdVenta.Name = "textBoxIdVenta";
            this.textBoxIdVenta.Size = new System.Drawing.Size(181, 20);
            this.textBoxIdVenta.TabIndex = 2;
            // 
            // etiquetaNumeroDeVenta
            // 
            this.etiquetaNumeroDeVenta.AutoSize = true;
            this.etiquetaNumeroDeVenta.Location = new System.Drawing.Point(6, 30);
            this.etiquetaNumeroDeVenta.Name = "etiquetaNumeroDeVenta";
            this.etiquetaNumeroDeVenta.Size = new System.Drawing.Size(65, 13);
            this.etiquetaNumeroDeVenta.TabIndex = 3;
            this.etiquetaNumeroDeVenta.Text = "N° de Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscarPasajesYEncomiendas);
            this.groupBox1.Controls.Add(this.etiquetaNumeroDeVenta);
            this.groupBox1.Controls.Add(this.textBoxIdVenta);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 62);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Pasajes/Encomiendas por ventas";
            // 
            // CancelarPasajesYEncomiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 380);
            this.Controls.Add(this.grillaPasajesYEncomiendas);
            this.Controls.Add(this.groupBox1);
            this.Name = "CancelarPasajesYEncomiendas";
            this.Text = "Cancelar Pasajes y Encomiendas";
            ((System.ComponentModel.ISupportInitialize)(this.grillaPasajesYEncomiendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaPasajesYEncomiendas;
        private System.Windows.Forms.Button buscarPasajesYEncomiendas;
        private System.Windows.Forms.MaskedTextBox textBoxIdVenta;
        private System.Windows.Forms.Label etiquetaNumeroDeVenta;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}