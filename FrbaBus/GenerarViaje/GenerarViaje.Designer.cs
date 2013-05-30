namespace FrbaBus.GenerarViaje
{
    partial class GenerarViaje
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
            this.FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.FechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.Micros = new System.Windows.Forms.ComboBox();
            this.Recorridos = new System.Windows.Forms.ComboBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.lblFecSal = new System.Windows.Forms.Label();
            this.lblFecLle = new System.Windows.Forms.Label();
            this.lblMicro = new System.Windows.Forms.Label();
            this.lblRecorrido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FechaSalida
            // 
            this.FechaSalida.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaSalida.Location = new System.Drawing.Point(197, 12);
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.Size = new System.Drawing.Size(139, 20);
            this.FechaSalida.TabIndex = 0;
            // 
            // FechaLlegada
            // 
            this.FechaLlegada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.FechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaLlegada.Location = new System.Drawing.Point(197, 49);
            this.FechaLlegada.Name = "FechaLlegada";
            this.FechaLlegada.Size = new System.Drawing.Size(139, 20);
            this.FechaLlegada.TabIndex = 1;
            // 
            // Micros
            // 
            this.Micros.FormattingEnabled = true;
            this.Micros.Location = new System.Drawing.Point(197, 86);
            this.Micros.Name = "Micros";
            this.Micros.Size = new System.Drawing.Size(200, 21);
            this.Micros.TabIndex = 2;
            // 
            // Recorridos
            // 
            this.Recorridos.FormattingEnabled = true;
            this.Recorridos.Location = new System.Drawing.Point(197, 123);
            this.Recorridos.Name = "Recorridos";
            this.Recorridos.Size = new System.Drawing.Size(200, 21);
            this.Recorridos.TabIndex = 3;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(114, 173);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(227, 173);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // lblFecSal
            // 
            this.lblFecSal.AutoSize = true;
            this.lblFecSal.Location = new System.Drawing.Point(12, 16);
            this.lblFecSal.Name = "lblFecSal";
            this.lblFecSal.Size = new System.Drawing.Size(82, 13);
            this.lblFecSal.TabIndex = 6;
            this.lblFecSal.Text = "Fecha de salida";
            // 
            // lblFecLle
            // 
            this.lblFecLle.AutoSize = true;
            this.lblFecLle.Location = new System.Drawing.Point(12, 53);
            this.lblFecLle.Name = "lblFecLle";
            this.lblFecLle.Size = new System.Drawing.Size(134, 13);
            this.lblFecLle.TabIndex = 7;
            this.lblFecLle.Text = "Fecha de llegada estimada";
            // 
            // lblMicro
            // 
            this.lblMicro.AutoSize = true;
            this.lblMicro.Location = new System.Drawing.Point(12, 89);
            this.lblMicro.Name = "lblMicro";
            this.lblMicro.Size = new System.Drawing.Size(33, 13);
            this.lblMicro.TabIndex = 8;
            this.lblMicro.Text = "Micro";
            // 
            // lblRecorrido
            // 
            this.lblRecorrido.AutoSize = true;
            this.lblRecorrido.Location = new System.Drawing.Point(12, 126);
            this.lblRecorrido.Name = "lblRecorrido";
            this.lblRecorrido.Size = new System.Drawing.Size(53, 13);
            this.lblRecorrido.TabIndex = 9;
            this.lblRecorrido.Text = "Recorrido";
            // 
            // GenerarViaje
            // 
            this.AcceptButton = this.Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelar;
            this.ClientSize = new System.Drawing.Size(413, 208);
            this.ControlBox = false;
            this.Controls.Add(this.lblRecorrido);
            this.Controls.Add(this.lblMicro);
            this.Controls.Add(this.lblFecLle);
            this.Controls.Add(this.lblFecSal);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Recorridos);
            this.Controls.Add(this.Micros);
            this.Controls.Add(this.FechaLlegada);
            this.Controls.Add(this.FechaSalida);
            this.Name = "GenerarViaje";
            this.ShowIcon = false;
            this.Text = "GenerarViaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaSalida;
        private System.Windows.Forms.DateTimePicker FechaLlegada;
        private System.Windows.Forms.ComboBox Micros;
        private System.Windows.Forms.ComboBox Recorridos;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label lblFecSal;
        private System.Windows.Forms.Label lblFecLle;
        private System.Windows.Forms.Label lblMicro;
        private System.Windows.Forms.Label lblRecorrido;
    }
}