namespace FrbaBus.Registrar_LLegada_Micro
{
    partial class RegistrarLlegada
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
            this.LlegadasCargadas = new System.Windows.Forms.DataGridView();
            this.Micro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMicro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.ciudadOrigen = new System.Windows.Forms.ComboBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.cargar = new System.Windows.Forms.Button();
            this.ciudadDestino = new System.Windows.Forms.ComboBox();
            this.patenteMicro = new System.Windows.Forms.ComboBox();
            this.agregar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCiudadOri = new System.Windows.Forms.Label();
            this.lblCiudadDest = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LlegadasCargadas)).BeginInit();
            this.SuspendLayout();
            // 
            // LlegadasCargadas
            // 
            this.LlegadasCargadas.AllowUserToAddRows = false;
            this.LlegadasCargadas.AllowUserToDeleteRows = false;
            this.LlegadasCargadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.LlegadasCargadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LlegadasCargadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Micro,
            this.Origen,
            this.Destino,
            this.FecLlegada,
            this.idOrigen,
            this.idDestino,
            this.idMicro});
            this.LlegadasCargadas.Location = new System.Drawing.Point(12, 169);
            this.LlegadasCargadas.Name = "LlegadasCargadas";
            this.LlegadasCargadas.RowHeadersVisible = false;
            this.LlegadasCargadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LlegadasCargadas.Size = new System.Drawing.Size(362, 203);
            this.LlegadasCargadas.TabIndex = 0;
            // 
            // Micro
            // 
            this.Micro.Frozen = true;
            this.Micro.HeaderText = "Micro";
            this.Micro.Name = "Micro";
            this.Micro.ReadOnly = true;
            this.Micro.Width = 58;
            // 
            // Origen
            // 
            this.Origen.Frozen = true;
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Width = 63;
            // 
            // Destino
            // 
            this.Destino.Frozen = true;
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 68;
            // 
            // FecLlegada
            // 
            this.FecLlegada.Frozen = true;
            this.FecLlegada.HeaderText = "Fecha Llegada";
            this.FecLlegada.Name = "FecLlegada";
            this.FecLlegada.ReadOnly = true;
            this.FecLlegada.Width = 95;
            // 
            // idOrigen
            // 
            this.idOrigen.Frozen = true;
            this.idOrigen.HeaderText = "idOrigen";
            this.idOrigen.Name = "idOrigen";
            this.idOrigen.ReadOnly = true;
            this.idOrigen.Visible = false;
            // 
            // idDestino
            // 
            this.idDestino.Frozen = true;
            this.idDestino.HeaderText = "idDestino";
            this.idDestino.Name = "idDestino";
            this.idDestino.ReadOnly = true;
            this.idDestino.Visible = false;
            // 
            // idMicro
            // 
            this.idMicro.Frozen = true;
            this.idMicro.HeaderText = "idMicro";
            this.idMicro.Name = "idMicro";
            this.idMicro.ReadOnly = true;
            this.idMicro.Visible = false;
            // 
            // fechaLlegada
            // 
            this.fechaLlegada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLlegada.Location = new System.Drawing.Point(154, 12);
            this.fechaLlegada.Name = "fechaLlegada";
            this.fechaLlegada.Size = new System.Drawing.Size(155, 20);
            this.fechaLlegada.TabIndex = 1;
            // 
            // ciudadOrigen
            // 
            this.ciudadOrigen.FormattingEnabled = true;
            this.ciudadOrigen.Location = new System.Drawing.Point(154, 39);
            this.ciudadOrigen.Name = "ciudadOrigen";
            this.ciudadOrigen.Size = new System.Drawing.Size(200, 21);
            this.ciudadOrigen.TabIndex = 2;
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Location = new System.Drawing.Point(310, 388);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(64, 23);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(232, 388);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(72, 23);
            this.cargar.TabIndex = 4;
            this.cargar.Text = "Cargar";
            this.cargar.UseVisualStyleBackColor = true;
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.FormattingEnabled = true;
            this.ciudadDestino.Location = new System.Drawing.Point(154, 66);
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.Size = new System.Drawing.Size(200, 21);
            this.ciudadDestino.TabIndex = 5;
            // 
            // patenteMicro
            // 
            this.patenteMicro.FormattingEnabled = true;
            this.patenteMicro.Location = new System.Drawing.Point(154, 93);
            this.patenteMicro.Name = "patenteMicro";
            this.patenteMicro.Size = new System.Drawing.Size(200, 21);
            this.patenteMicro.TabIndex = 6;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(279, 131);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 7;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(125, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha y hora de Llegada";
            // 
            // lblCiudadOri
            // 
            this.lblCiudadOri.AutoSize = true;
            this.lblCiudadOri.Location = new System.Drawing.Point(12, 42);
            this.lblCiudadOri.Name = "lblCiudadOri";
            this.lblCiudadOri.Size = new System.Drawing.Size(87, 13);
            this.lblCiudadOri.TabIndex = 9;
            this.lblCiudadOri.Text = "Ciudad de origen";
            // 
            // lblCiudadDest
            // 
            this.lblCiudadDest.AutoSize = true;
            this.lblCiudadDest.Location = new System.Drawing.Point(12, 69);
            this.lblCiudadDest.Name = "lblCiudadDest";
            this.lblCiudadDest.Size = new System.Drawing.Size(92, 13);
            this.lblCiudadDest.TabIndex = 10;
            this.lblCiudadDest.Text = "Ciudad de destino";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(15, 100);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(89, 13);
            this.lblPatente.TabIndex = 11;
            this.lblPatente.Text = "Patente del micro";
            // 
            // RegistrarLlegada
            // 
            this.AcceptButton = this.agregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar;
            this.ClientSize = new System.Drawing.Size(376, 417);
            this.ControlBox = false;
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblCiudadDest);
            this.Controls.Add(this.lblCiudadOri);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.patenteMicro);
            this.Controls.Add(this.ciudadDestino);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.ciudadOrigen);
            this.Controls.Add(this.fechaLlegada);
            this.Controls.Add(this.LlegadasCargadas);
            this.Name = "RegistrarLlegada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de llegadas";
            ((System.ComponentModel.ISupportInitialize)(this.LlegadasCargadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LlegadasCargadas;
        private System.Windows.Forms.DateTimePicker fechaLlegada;
        private System.Windows.Forms.ComboBox ciudadOrigen;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Micro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMicro;
        private System.Windows.Forms.ComboBox ciudadDestino;
        private System.Windows.Forms.ComboBox patenteMicro;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCiudadOri;
        private System.Windows.Forms.Label lblCiudadDest;
        private System.Windows.Forms.Label lblPatente;
    }
}