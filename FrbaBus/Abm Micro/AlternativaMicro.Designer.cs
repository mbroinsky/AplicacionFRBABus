namespace FrbaBus.Abm_Micro
{
    partial class AlternativaMicro
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
            this.microsDisp = new System.Windows.Forms.ComboBox();
            this.grpMicros = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.asignarNuevoMicro = new System.Windows.Forms.Button();
            this.cancelarPasajes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.grpMicros.SuspendLayout();
            this.SuspendLayout();
            // 
            // microsDisp
            // 
            this.microsDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.microsDisp.FormattingEnabled = true;
            this.microsDisp.Location = new System.Drawing.Point(6, 22);
            this.microsDisp.Name = "microsDisp";
            this.microsDisp.Size = new System.Drawing.Size(173, 163);
            this.microsDisp.TabIndex = 12;
            // 
            // grpMicros
            // 
            this.grpMicros.Controls.Add(this.microsDisp);
            this.grpMicros.Enabled = false;
            this.grpMicros.Location = new System.Drawing.Point(12, 86);
            this.grpMicros.Name = "grpMicros";
            this.grpMicros.Size = new System.Drawing.Size(185, 191);
            this.grpMicros.TabIndex = 12;
            this.grpMicros.TabStop = false;
            this.grpMicros.Text = "Micros Disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.MaximumSize = new System.Drawing.Size(185, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "El micro tenía viajes asigandos. Seleccione una alternativa o cancele los pasajes" +
                "";
            // 
            // asignarNuevoMicro
            // 
            this.asignarNuevoMicro.Location = new System.Drawing.Point(12, 312);
            this.asignarNuevoMicro.Name = "asignarNuevoMicro";
            this.asignarNuevoMicro.Size = new System.Drawing.Size(185, 23);
            this.asignarNuevoMicro.TabIndex = 13;
            this.asignarNuevoMicro.Text = "Asignar nuevo micro";
            this.asignarNuevoMicro.UseVisualStyleBackColor = true;
            // 
            // cancelarPasajes
            // 
            this.cancelarPasajes.Location = new System.Drawing.Point(12, 283);
            this.cancelarPasajes.Name = "cancelarPasajes";
            this.cancelarPasajes.Size = new System.Drawing.Size(185, 23);
            this.cancelarPasajes.TabIndex = 14;
            this.cancelarPasajes.Text = "Cancelar Pasajes/Encomiendas";
            this.cancelarPasajes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Viaje ID:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(65, 58);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // AlternativaMicro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 349);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelarPasajes);
            this.Controls.Add(this.asignarNuevoMicro);
            this.Controls.Add(this.grpMicros);
            this.Controls.Add(this.label1);
            this.Name = "AlternativaMicro";
            this.Text = "Micro con viajes";
            this.grpMicros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox microsDisp;
        private System.Windows.Forms.GroupBox grpMicros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button asignarNuevoMicro;
        private System.Windows.Forms.Button cancelarPasajes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}