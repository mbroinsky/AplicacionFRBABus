namespace FrbaBus.Compra_de_Pasajes
{
    partial class Pasajero
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
            this.cancelar = new System.Windows.Forms.Button();
            this.dni = new System.Windows.Forms.TextBox();
            this.documento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.siguiente = new System.Windows.Forms.Button();
            this.femenino = new System.Windows.Forms.RadioButton();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butaca = new System.Windows.Forms.GroupBox();
            this.butacasLibres = new System.Windows.Forms.DataGridView();
            this.datos = new System.Windows.Forms.GroupBox();
            this.butacasDisp = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.continuar = new System.Windows.Forms.Button();
            this.esDiscapacitado = new System.Windows.Forms.CheckBox();
            this.panelDocumento = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.butaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.butacasLibres)).BeginInit();
            this.datos.SuspendLayout();
            this.panelDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(12, 501);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 12;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(111, 19);
            this.dni.MaxLength = 8;
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(135, 20);
            this.dni.TabIndex = 0;
            // 
            // documento
            // 
            this.documento.AutoSize = true;
            this.documento.Location = new System.Drawing.Point(12, 22);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(62, 13);
            this.documento.TabIndex = 2;
            this.documento.Text = "Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 63);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(111, 19);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(162, 20);
            this.nombre.TabIndex = 1;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(111, 60);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(162, 20);
            this.apellido.TabIndex = 2;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 106);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(111, 103);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(233, 20);
            this.direccion.TabIndex = 3;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(111, 145);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(96, 20);
            this.telefono.TabIndex = 4;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(12, 148);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "Teléfono";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimiento.Location = new System.Drawing.Point(111, 187);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(96, 20);
            this.fechaNacimiento.TabIndex = 5;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(12, 191);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(91, 13);
            this.lblNacimiento.TabIndex = 12;
            this.lblNacimiento.Text = "Fecha nacimiento";
            // 
            // siguiente
            // 
            this.siguiente.Location = new System.Drawing.Point(291, 501);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(75, 23);
            this.siguiente.TabIndex = 13;
            this.siguiente.Text = "Siguiente >";
            this.siguiente.UseVisualStyleBackColor = true;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // femenino
            // 
            this.femenino.AutoSize = true;
            this.femenino.Location = new System.Drawing.Point(28, 19);
            this.femenino.Name = "femenino";
            this.femenino.Size = new System.Drawing.Size(71, 17);
            this.femenino.TabIndex = 6;
            this.femenino.TabStop = true;
            this.femenino.Text = "Femenino";
            this.femenino.UseVisualStyleBackColor = true;
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(28, 42);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(73, 17);
            this.masculino.TabIndex = 7;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femenino);
            this.groupBox1.Controls.Add(this.masculino);
            this.groupBox1.Location = new System.Drawing.Point(225, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 78);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // butaca
            // 
            this.butaca.Controls.Add(this.butacasLibres);
            this.butaca.Enabled = false;
            this.butaca.Location = new System.Drawing.Point(6, 356);
            this.butaca.Name = "butaca";
            this.butaca.Size = new System.Drawing.Size(366, 139);
            this.butaca.TabIndex = 17;
            this.butaca.TabStop = false;
            this.butaca.Text = "Seleccione su butaca";
            // 
            // butacasLibres
            // 
            this.butacasLibres.AllowUserToAddRows = false;
            this.butacasLibres.AllowUserToDeleteRows = false;
            this.butacasLibres.AllowUserToResizeColumns = false;
            this.butacasLibres.AllowUserToResizeRows = false;
            this.butacasLibres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.butacasLibres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.butacasLibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.butacasLibres.Location = new System.Drawing.Point(12, 19);
            this.butacasLibres.MultiSelect = false;
            this.butacasLibres.Name = "butacasLibres";
            this.butacasLibres.RowHeadersVisible = false;
            this.butacasLibres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.butacasLibres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.butacasLibres.Size = new System.Drawing.Size(345, 104);
            this.butacasLibres.TabIndex = 11;
            // 
            // datos
            // 
            this.datos.Controls.Add(this.esDiscapacitado);
            this.datos.Controls.Add(this.butacasDisp);
            this.datos.Controls.Add(this.lblMail);
            this.datos.Controls.Add(this.mail);
            this.datos.Controls.Add(this.groupBox1);
            this.datos.Controls.Add(this.lblNacimiento);
            this.datos.Controls.Add(this.fechaNacimiento);
            this.datos.Controls.Add(this.lblTel);
            this.datos.Controls.Add(this.telefono);
            this.datos.Controls.Add(this.direccion);
            this.datos.Controls.Add(this.lblDireccion);
            this.datos.Controls.Add(this.apellido);
            this.datos.Controls.Add(this.nombre);
            this.datos.Controls.Add(this.lblApellido);
            this.datos.Controls.Add(this.lblNombre);
            this.datos.Enabled = false;
            this.datos.Location = new System.Drawing.Point(6, 55);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(366, 295);
            this.datos.TabIndex = 18;
            this.datos.TabStop = false;
            this.datos.Text = "Datos Pasajero";
            // 
            // butacasDisp
            // 
            this.butacasDisp.Location = new System.Drawing.Point(244, 266);
            this.butacasDisp.Name = "butacasDisp";
            this.butacasDisp.Size = new System.Drawing.Size(113, 23);
            this.butacasDisp.TabIndex = 10;
            this.butacasDisp.Text = "Ver butacas";
            this.butacasDisp.UseVisualStyleBackColor = true;
            this.butacasDisp.Click += new System.EventHandler(this.butacasDisp_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 228);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 13);
            this.lblMail.TabIndex = 18;
            this.lblMail.Text = "E-Mail";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(111, 225);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(233, 20);
            this.mail.TabIndex = 8;
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(282, 17);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(75, 23);
            this.continuar.TabIndex = 19;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // esDiscapacitado
            // 
            this.esDiscapacitado.AutoSize = true;
            this.esDiscapacitado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.esDiscapacitado.Location = new System.Drawing.Point(9, 266);
            this.esDiscapacitado.Name = "esDiscapacitado";
            this.esDiscapacitado.Size = new System.Drawing.Size(141, 17);
            this.esDiscapacitado.TabIndex = 9;
            this.esDiscapacitado.Text = "Capacidades especiales";
            this.esDiscapacitado.UseVisualStyleBackColor = true;
            // 
            // panelDocumento
            // 
            this.panelDocumento.Controls.Add(this.continuar);
            this.panelDocumento.Controls.Add(this.dni);
            this.panelDocumento.Controls.Add(this.documento);
            this.panelDocumento.Location = new System.Drawing.Point(6, 3);
            this.panelDocumento.Name = "panelDocumento";
            this.panelDocumento.Size = new System.Drawing.Size(366, 46);
            this.panelDocumento.TabIndex = 20;
            this.panelDocumento.TabStop = false;
            // 
            // Pasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 529);
            this.ControlBox = false;
            this.Controls.Add(this.panelDocumento);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.butaca);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.cancelar);
            this.Name = "Pasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.butaca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.butacasLibres)).EndInit();
            this.datos.ResumeLayout(false);
            this.datos.PerformLayout();
            this.panelDocumento.ResumeLayout(false);
            this.panelDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label documento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.RadioButton femenino;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox butaca;
        private System.Windows.Forms.DataGridView butacasLibres;
        private System.Windows.Forms.GroupBox datos;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.Button butacasDisp;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.CheckBox esDiscapacitado;
        private System.Windows.Forms.GroupBox panelDocumento;
    }
}