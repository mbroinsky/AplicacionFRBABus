namespace FrbaBus.Compra_de_Pasajes
{
    partial class SeleccionDeViaje
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
            this.ciudadDestino = new System.Windows.Forms.ComboBox();
            this.ciudadOrigen = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.fechaViaje = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscar = new System.Windows.Forms.Button();
            this.viajesDisponibles = new System.Windows.Forms.DataGridView();
            this.cancelar = new System.Windows.Forms.Button();
            this.siguiente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viajesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadDestino.FormattingEnabled = true;
            this.ciudadDestino.Location = new System.Drawing.Point(59, 72);
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.Size = new System.Drawing.Size(207, 21);
            this.ciudadDestino.TabIndex = 2;
            // 
            // ciudadOrigen
            // 
            this.ciudadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadOrigen.FormattingEnabled = true;
            this.ciudadOrigen.Location = new System.Drawing.Point(59, 45);
            this.ciudadOrigen.Name = "ciudadOrigen";
            this.ciudadOrigen.Size = new System.Drawing.Size(207, 21);
            this.ciudadOrigen.TabIndex = 1;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(10, 75);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 18;
            this.lblDestino.Text = "Destino";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(10, 48);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 17;
            this.lblOrigen.Text = "Origen";
            // 
            // fechaViaje
            // 
            this.fechaViaje.CustomFormat = "dd/MM/yyyy";
            this.fechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaViaje.Location = new System.Drawing.Point(59, 19);
            this.fechaViaje.Name = "fechaViaje";
            this.fechaViaje.Size = new System.Drawing.Size(108, 20);
            this.fechaViaje.TabIndex = 0;
            this.fechaViaje.Value = new System.DateTime(2013, 7, 2, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.fechaViaje);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ciudadOrigen);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.ciudadDestino);
            this.groupBox1.Controls.Add(this.lblOrigen);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del viaje";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(300, 70);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(135, 23);
            this.buscar.TabIndex = 3;
            this.buscar.Text = "Buscar disponibilidad";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // viajesDisponibles
            // 
            this.viajesDisponibles.AllowUserToAddRows = false;
            this.viajesDisponibles.AllowUserToDeleteRows = false;
            this.viajesDisponibles.AllowUserToResizeColumns = false;
            this.viajesDisponibles.AllowUserToResizeRows = false;
            this.viajesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viajesDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viajesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viajesDisponibles.Location = new System.Drawing.Point(2, 110);
            this.viajesDisponibles.Name = "viajesDisponibles";
            this.viajesDisponibles.ReadOnly = true;
            this.viajesDisponibles.RowHeadersVisible = false;
            this.viajesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viajesDisponibles.Size = new System.Drawing.Size(598, 232);
            this.viajesDisponibles.TabIndex = 22;
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Location = new System.Drawing.Point(2, 348);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // siguiente
            // 
            this.siguiente.Location = new System.Drawing.Point(525, 348);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(75, 23);
            this.siguiente.TabIndex = 5;
            this.siguiente.Text = "Siguiente >";
            this.siguiente.UseVisualStyleBackColor = true;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // SeleccionDeViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 375);
            this.ControlBox = false;
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.viajesDisponibles);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SeleccionDeViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de pasajes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viajesDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ciudadDestino;
        private System.Windows.Forms.ComboBox ciudadOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.DateTimePicker fechaViaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView viajesDisponibles;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button siguiente;
    }
}