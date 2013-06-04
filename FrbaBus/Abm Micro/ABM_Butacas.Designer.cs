namespace FrbaBus.Abm_Micro
{
    partial class ABM_Butacas
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
            this.agregarButacas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.piso = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Butacas = new System.Windows.Forms.DataGridView();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Butacas)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarButacas
            // 
            this.agregarButacas.Location = new System.Drawing.Point(296, 18);
            this.agregarButacas.Name = "agregarButacas";
            this.agregarButacas.Size = new System.Drawing.Size(75, 23);
            this.agregarButacas.TabIndex = 0;
            this.agregarButacas.Text = "Agregar";
            this.agregarButacas.UseVisualStyleBackColor = true;
            this.agregarButacas.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Piso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(39, 20);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(26, 20);
            this.piso.TabIndex = 2;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(201, 21);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(89, 20);
            this.cantidad.TabIndex = 3;
            this.cantidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de asientos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cantidad);
            this.groupBox1.Controls.Add(this.piso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.agregarButacas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 54);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Butacas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Butacas
            // 
            this.Butacas.AllowUserToAddRows = false;
            this.Butacas.AllowUserToDeleteRows = false;
            this.Butacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Butacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Butacas.Location = new System.Drawing.Point(12, 72);
            this.Butacas.Name = "Butacas";
            this.Butacas.RowHeadersVisible = false;
            this.Butacas.Size = new System.Drawing.Size(377, 254);
            this.Butacas.TabIndex = 30;
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Location = new System.Drawing.Point(308, 332);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 32;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(229, 332);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 31;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            // 
            // ABM_Butacas
            // 
            this.AcceptButton = this.aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar;
            this.ClientSize = new System.Drawing.Size(401, 366);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.Butacas);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABM_Butacas";
            this.Text = "Butacas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Butacas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agregarButacas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox piso;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Butacas;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;



    }
}