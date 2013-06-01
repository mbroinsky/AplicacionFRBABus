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
            this.generar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.grpMicros = new System.Windows.Forms.GroupBox();
            this.microsDisp = new System.Windows.Forms.ListBox();
            this.buscar = new System.Windows.Forms.Button();
            this.grpPreseleccion = new System.Windows.Forms.GroupBox();
            this.lblRecorrido = new System.Windows.Forms.Label();
            this.lblFecLle = new System.Windows.Forms.Label();
            this.lblFecSal = new System.Windows.Forms.Label();
            this.recorridos = new System.Windows.Forms.ComboBox();
            this.fechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.volver = new System.Windows.Forms.Button();
            this.grpMicros.SuspendLayout();
            this.grpPreseleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // generar
            // 
            this.generar.Location = new System.Drawing.Point(49, 323);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(75, 23);
            this.generar.TabIndex = 4;
            this.generar.Text = "Generar";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Location = new System.Drawing.Point(164, 323);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // grpMicros
            // 
            this.grpMicros.Controls.Add(this.microsDisp);
            this.grpMicros.Enabled = false;
            this.grpMicros.Location = new System.Drawing.Point(4, 126);
            this.grpMicros.Name = "grpMicros";
            this.grpMicros.Size = new System.Drawing.Size(294, 191);
            this.grpMicros.TabIndex = 11;
            this.grpMicros.TabStop = false;
            this.grpMicros.Text = "Micros Disponibles";
            // 
            // microsDisp
            // 
            this.microsDisp.FormattingEnabled = true;
            this.microsDisp.Location = new System.Drawing.Point(83, 25);
            this.microsDisp.Name = "microsDisp";
            this.microsDisp.Size = new System.Drawing.Size(113, 160);
            this.microsDisp.TabIndex = 11;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(185, 97);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(113, 23);
            this.buscar.TabIndex = 12;
            this.buscar.Text = "Buscar Micros";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // grpPreseleccion
            // 
            this.grpPreseleccion.Controls.Add(this.lblRecorrido);
            this.grpPreseleccion.Controls.Add(this.lblFecLle);
            this.grpPreseleccion.Controls.Add(this.lblFecSal);
            this.grpPreseleccion.Controls.Add(this.recorridos);
            this.grpPreseleccion.Controls.Add(this.fechaLlegada);
            this.grpPreseleccion.Controls.Add(this.fechaSalida);
            this.grpPreseleccion.Location = new System.Drawing.Point(4, -4);
            this.grpPreseleccion.Name = "grpPreseleccion";
            this.grpPreseleccion.Size = new System.Drawing.Size(294, 95);
            this.grpPreseleccion.TabIndex = 13;
            this.grpPreseleccion.TabStop = false;
            // 
            // lblRecorrido
            // 
            this.lblRecorrido.AutoSize = true;
            this.lblRecorrido.Location = new System.Drawing.Point(4, 17);
            this.lblRecorrido.Name = "lblRecorrido";
            this.lblRecorrido.Size = new System.Drawing.Size(53, 13);
            this.lblRecorrido.TabIndex = 15;
            this.lblRecorrido.Text = "Recorrido";
            // 
            // lblFecLle
            // 
            this.lblFecLle.AutoSize = true;
            this.lblFecLle.Location = new System.Drawing.Point(4, 71);
            this.lblFecLle.Name = "lblFecLle";
            this.lblFecLle.Size = new System.Drawing.Size(134, 13);
            this.lblFecLle.TabIndex = 14;
            this.lblFecLle.Text = "Fecha de llegada estimada";
            // 
            // lblFecSal
            // 
            this.lblFecSal.AutoSize = true;
            this.lblFecSal.Location = new System.Drawing.Point(4, 45);
            this.lblFecSal.Name = "lblFecSal";
            this.lblFecSal.Size = new System.Drawing.Size(82, 13);
            this.lblFecSal.TabIndex = 13;
            this.lblFecSal.Text = "Fecha de salida";
            // 
            // recorridos
            // 
            this.recorridos.FormattingEnabled = true;
            this.recorridos.Location = new System.Drawing.Point(83, 14);
            this.recorridos.Name = "recorridos";
            this.recorridos.Size = new System.Drawing.Size(200, 21);
            this.recorridos.TabIndex = 12;
            // 
            // fechaLlegada
            // 
            this.fechaLlegada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLlegada.Location = new System.Drawing.Point(144, 67);
            this.fechaLlegada.Name = "fechaLlegada";
            this.fechaLlegada.Size = new System.Drawing.Size(139, 20);
            this.fechaLlegada.TabIndex = 11;
            // 
            // fechaSalida
            // 
            this.fechaSalida.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaSalida.Location = new System.Drawing.Point(144, 41);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(139, 20);
            this.fechaSalida.TabIndex = 10;
            // 
            // volver
            // 
            this.volver.Enabled = false;
            this.volver.Location = new System.Drawing.Point(66, 97);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(113, 23);
            this.volver.TabIndex = 14;
            this.volver.Text = "Volver a seleccionar";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // GenerarViaje
            // 
            this.AcceptButton = this.generar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar;
            this.ClientSize = new System.Drawing.Size(301, 350);
            this.ControlBox = false;
            this.Controls.Add(this.volver);
            this.Controls.Add(this.grpPreseleccion);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.grpMicros);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.generar);
            this.Name = "GenerarViaje";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GenerarViaje";
            this.grpMicros.ResumeLayout(false);
            this.grpPreseleccion.ResumeLayout(false);
            this.grpPreseleccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.GroupBox grpMicros;
        private System.Windows.Forms.ListBox microsDisp;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.GroupBox grpPreseleccion;
        private System.Windows.Forms.Label lblRecorrido;
        private System.Windows.Forms.Label lblFecLle;
        private System.Windows.Forms.Label lblFecSal;
        private System.Windows.Forms.ComboBox recorridos;
        private System.Windows.Forms.DateTimePicker fechaLlegada;
        private System.Windows.Forms.DateTimePicker fechaSalida;
        private System.Windows.Forms.Button volver;
    }
}