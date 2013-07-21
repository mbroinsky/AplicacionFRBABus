namespace FrbaBus.Abm_Recorrido
{
    partial class ABMRecorrido
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblTipoServ = new System.Windows.Forms.Label();
            this.tipoServicio = new System.Windows.Forms.ComboBox();
            this.ciudadDestino = new System.Windows.Forms.ComboBox();
            this.ciudadOrigen = new System.Windows.Forms.ComboBox();
            this.precioBase = new System.Windows.Forms.TextBox();
            this.precioKilo = new System.Windows.Forms.TextBox();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.lblPrecioKg = new System.Windows.Forms.Label();
            this.tiempoViaje = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(87, 293);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Location = new System.Drawing.Point(181, 293);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(100, 15);
            this.codigo.MaxLength = 18;
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(156, 20);
            this.codigo.TabIndex = 0;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(12, 128);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 16;
            this.lblDestino.Text = "Destino";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(12, 92);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 15;
            this.lblOrigen.Text = "Origen";
            // 
            // lblTipoServ
            // 
            this.lblTipoServ.AutoSize = true;
            this.lblTipoServ.Location = new System.Drawing.Point(8, 55);
            this.lblTipoServ.Name = "lblTipoServ";
            this.lblTipoServ.Size = new System.Drawing.Size(84, 13);
            this.lblTipoServ.TabIndex = 14;
            this.lblTipoServ.Text = "Tipo de Servicio";
            // 
            // tipoServicio
            // 
            this.tipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoServicio.FormattingEnabled = true;
            this.tipoServicio.Location = new System.Drawing.Point(100, 52);
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.Size = new System.Drawing.Size(156, 21);
            this.tipoServicio.TabIndex = 1;
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadDestino.FormattingEnabled = true;
            this.ciudadDestino.Location = new System.Drawing.Point(100, 125);
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.Size = new System.Drawing.Size(156, 21);
            this.ciudadDestino.TabIndex = 3;
            // 
            // ciudadOrigen
            // 
            this.ciudadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadOrigen.FormattingEnabled = true;
            this.ciudadOrigen.Location = new System.Drawing.Point(100, 89);
            this.ciudadOrigen.Name = "ciudadOrigen";
            this.ciudadOrigen.Size = new System.Drawing.Size(156, 21);
            this.ciudadOrigen.TabIndex = 2;
            // 
            // precioBase
            // 
            this.precioBase.Location = new System.Drawing.Point(155, 161);
            this.precioBase.MaxLength = 11;
            this.precioBase.Name = "precioBase";
            this.precioBase.Size = new System.Drawing.Size(100, 20);
            this.precioBase.TabIndex = 4;
            this.precioBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // precioKilo
            // 
            this.precioKilo.Location = new System.Drawing.Point(155, 198);
            this.precioKilo.MaxLength = 11;
            this.precioKilo.Name = "precioKilo";
            this.precioKilo.Size = new System.Drawing.Size(100, 20);
            this.precioKilo.TabIndex = 5;
            this.precioKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(12, 164);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(64, 13);
            this.lblPrecioBase.TabIndex = 19;
            this.lblPrecioBase.Text = "Precio Base";
            // 
            // lblPrecioKg
            // 
            this.lblPrecioKg.AutoSize = true;
            this.lblPrecioKg.Location = new System.Drawing.Point(12, 201);
            this.lblPrecioKg.Name = "lblPrecioKg";
            this.lblPrecioKg.Size = new System.Drawing.Size(74, 13);
            this.lblPrecioKg.TabIndex = 20;
            this.lblPrecioKg.Text = "Precio por Kg.";
            // 
            // tiempoViaje
            // 
            this.tiempoViaje.Location = new System.Drawing.Point(155, 235);
            this.tiempoViaje.MaxLength = 5;
            this.tiempoViaje.Name = "tiempoViaje";
            this.tiempoViaje.Size = new System.Drawing.Size(100, 20);
            this.tiempoViaje.TabIndex = 6;
            this.tiempoViaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTiempo
            // 
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Location = new System.Drawing.Point(12, 238);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(90, 26);
            this.lblTiempo.TabIndex = 22;
            this.lblTiempo.Text = "Tiempo de viaje (HH:mm)";
            // 
            // ABMRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelar;
            this.ClientSize = new System.Drawing.Size(263, 328);
            this.ControlBox = false;
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.tiempoViaje);
            this.Controls.Add(this.lblPrecioKg);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.precioKilo);
            this.Controls.Add(this.precioBase);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblTipoServ);
            this.Controls.Add(this.tipoServicio);
            this.Controls.Add(this.ciudadDestino);
            this.Controls.Add(this.ciudadOrigen);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.lblCodigo);
            this.Name = "ABMRecorrido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM de Recorrido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblTipoServ;
        private System.Windows.Forms.ComboBox tipoServicio;
        private System.Windows.Forms.ComboBox ciudadDestino;
        private System.Windows.Forms.ComboBox ciudadOrigen;
        private System.Windows.Forms.TextBox precioBase;
        private System.Windows.Forms.TextBox precioKilo;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.Label lblPrecioKg;
        private System.Windows.Forms.TextBox tiempoViaje;
        private System.Windows.Forms.Label lblTiempo;
    }
}
