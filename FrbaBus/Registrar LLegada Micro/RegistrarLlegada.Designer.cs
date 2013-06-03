namespace Registrar_LLegada_Micro
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
            this.llegadasCargadas = new System.Windows.Forms.DataGridView();
            this.patenteMicro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMicro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.ciudadesOrigen = new System.Windows.Forms.ComboBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.cargar = new System.Windows.Forms.Button();
            this.ciudadesDestino = new System.Windows.Forms.ComboBox();
            this.patentesMicros = new System.Windows.Forms.ComboBox();
            this.agregar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCiudadOri = new System.Windows.Forms.Label();
            this.lblCiudadDest = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.llegadasCargadas)).BeginInit();
            this.SuspendLayout();
            // 
            // llegadasCargadas
            // 
            this.llegadasCargadas.AllowUserToAddRows = false;
            this.llegadasCargadas.AllowUserToDeleteRows = false;
            this.llegadasCargadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.llegadasCargadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.llegadasCargadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patenteMicro,
            this.ciudadOrigen,
            this.ciudadDestino,
            this.FecLlegada,
            this.idMicro,
            this.idOrigen,
            this.idDestino});
            this.llegadasCargadas.Location = new System.Drawing.Point(12, 169);
            this.llegadasCargadas.Name = "llegadasCargadas";
            this.llegadasCargadas.ReadOnly = true;
            this.llegadasCargadas.RowHeadersVisible = false;
            this.llegadasCargadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.llegadasCargadas.Size = new System.Drawing.Size(362, 203);
            this.llegadasCargadas.TabIndex = 0;
            // 
            // patenteMicro
            // 
            this.patenteMicro.Frozen = true;
            this.patenteMicro.HeaderText = "Micro";
            this.patenteMicro.Name = "patenteMicro";
            this.patenteMicro.ReadOnly = true;
            this.patenteMicro.Width = 58;
            // 
            // ciudadOrigen
            // 
            this.ciudadOrigen.Frozen = true;
            this.ciudadOrigen.HeaderText = "Origen";
            this.ciudadOrigen.Name = "ciudadOrigen";
            this.ciudadOrigen.ReadOnly = true;
            this.ciudadOrigen.Width = 63;
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.Frozen = true;
            this.ciudadDestino.HeaderText = "Destino";
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.ReadOnly = true;
            this.ciudadDestino.Width = 68;
            // 
            // FecLlegada
            // 
            this.FecLlegada.Frozen = true;
            this.FecLlegada.HeaderText = "Fecha Llegada";
            this.FecLlegada.Name = "FecLlegada";
            this.FecLlegada.ReadOnly = true;
            this.FecLlegada.Width = 95;
            // 
            // idMicro
            // 
            this.idMicro.Frozen = true;
            this.idMicro.HeaderText = "idMicro";
            this.idMicro.Name = "idMicro";
            this.idMicro.ReadOnly = true;
            this.idMicro.Visible = false;
            this.idMicro.Width = 66;
            // 
            // idOrigen
            // 
            this.idOrigen.Frozen = true;
            this.idOrigen.HeaderText = "idOrigen";
            this.idOrigen.Name = "idOrigen";
            this.idOrigen.ReadOnly = true;
            this.idOrigen.Visible = false;
            this.idOrigen.Width = 71;
            // 
            // idDestino
            // 
            this.idDestino.Frozen = true;
            this.idDestino.HeaderText = "idDestino";
            this.idDestino.Name = "idDestino";
            this.idDestino.ReadOnly = true;
            this.idDestino.Visible = false;
            this.idDestino.Width = 76;
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
            // ciudadesOrigen
            // 
            this.ciudadesOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadesOrigen.FormattingEnabled = true;
            this.ciudadesOrigen.Location = new System.Drawing.Point(154, 39);
            this.ciudadesOrigen.Name = "ciudadesOrigen";
            this.ciudadesOrigen.Size = new System.Drawing.Size(200, 21);
            this.ciudadesOrigen.TabIndex = 2;
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
            // ciudadesDestino
            // 
            this.ciudadesDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadesDestino.FormattingEnabled = true;
            this.ciudadesDestino.Location = new System.Drawing.Point(154, 66);
            this.ciudadesDestino.Name = "ciudadesDestino";
            this.ciudadesDestino.Size = new System.Drawing.Size(200, 21);
            this.ciudadesDestino.TabIndex = 5;
            // 
            // patentesMicros
            // 
            this.patentesMicros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patentesMicros.FormattingEnabled = true;
            this.patentesMicros.Location = new System.Drawing.Point(154, 93);
            this.patentesMicros.Name = "patentesMicros";
            this.patentesMicros.Size = new System.Drawing.Size(200, 21);
            this.patentesMicros.TabIndex = 6;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(279, 131);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 7;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
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
            this.lblPatente.Location = new System.Drawing.Point(12, 96);
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
            this.Controls.Add(this.patentesMicros);
            this.Controls.Add(this.ciudadesDestino);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.ciudadesOrigen);
            this.Controls.Add(this.fechaLlegada);
            this.Controls.Add(this.llegadasCargadas);
            this.Name = "RegistrarLlegada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de llegadas";
            ((System.ComponentModel.ISupportInitialize)(this.llegadasCargadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView llegadasCargadas;
        private System.Windows.Forms.DateTimePicker fechaLlegada;
        private System.Windows.Forms.ComboBox ciudadesOrigen;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.ComboBox ciudadesDestino;
        private System.Windows.Forms.ComboBox patentesMicros;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCiudadOri;
        private System.Windows.Forms.Label lblCiudadDest;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn patenteMicro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMicro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDestino;
    }
}