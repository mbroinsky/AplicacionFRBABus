namespace FrbaBus.Abm_Micro
{
    partial class FormularioMantenimiento
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
            this.fechaDeBaja = new System.Windows.Forms.DateTimePicker();
            this.fechaDeAlta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaDeBaja
            // 
            this.fechaDeBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDeBaja.Location = new System.Drawing.Point(150, 26);
            this.fechaDeBaja.Name = "fechaDeBaja";
            this.fechaDeBaja.Size = new System.Drawing.Size(87, 20);
            this.fechaDeBaja.TabIndex = 0;
            // 
            // fechaDeAlta
            // 
            this.fechaDeAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDeAlta.Location = new System.Drawing.Point(150, 52);
            this.fechaDeAlta.Name = "fechaDeAlta";
            this.fechaDeAlta.Size = new System.Drawing.Size(87, 20);
            this.fechaDeAlta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Baja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Reincoporación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaDeAlta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fechaDeBaja);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo de Mantenimiento";
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(180, 107);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 5;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(99, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // formularioMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 142);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "formularioMantenimiento";
            this.Text = "Enviar a Mantenimeinto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaDeBaja;
        private System.Windows.Forms.DateTimePicker fechaDeAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button button2;
    }
}