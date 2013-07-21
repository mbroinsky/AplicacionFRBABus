namespace FrbaBus.Compra_de_Pasajes
{
    partial class DatosPago
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
            this.datos = new System.Windows.Forms.GroupBox();
            this.esDiscapacitado = new System.Windows.Forms.CheckBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.continuar = new System.Windows.Forms.Button();
            this.panelDocumento = new System.Windows.Forms.GroupBox();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.datosTarjeta = new System.Windows.Forms.GroupBox();
            this.lblFormatoCodSeg = new System.Windows.Forms.Label();
            this.lblFormatoFecVenc = new System.Windows.Forms.Label();
            this.lblFormatoTarjeta = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblFecVenc = new System.Windows.Forms.Label();
            this.vencimiento = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.lblTipos = new System.Windows.Forms.Label();
            this.tipos = new System.Windows.Forms.ComboBox();
            this.efectivo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.datos.SuspendLayout();
            this.panelDocumento.SuspendLayout();
            this.datosTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(5, 554);
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
            this.nombre.MaxLength = 30;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(162, 20);
            this.nombre.TabIndex = 1;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(111, 60);
            this.apellido.MaxLength = 30;
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
            this.direccion.MaxLength = 50;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(233, 20);
            this.direccion.TabIndex = 3;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(111, 145);
            this.telefono.MaxLength = 15;
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
            this.siguiente.Location = new System.Drawing.Point(292, 554);
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
            // datos
            // 
            this.datos.Controls.Add(this.esDiscapacitado);
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
            this.datos.Location = new System.Drawing.Point(6, 106);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(366, 295);
            this.datos.TabIndex = 18;
            this.datos.TabStop = false;
            this.datos.Text = "Datos Pasajero";
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
            this.mail.MaxLength = 50;
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
            // panelDocumento
            // 
            this.panelDocumento.Controls.Add(this.continuar);
            this.panelDocumento.Controls.Add(this.dni);
            this.panelDocumento.Controls.Add(this.documento);
            this.panelDocumento.Location = new System.Drawing.Point(6, 54);
            this.panelDocumento.Name = "panelDocumento";
            this.panelDocumento.Size = new System.Drawing.Size(366, 46);
            this.panelDocumento.TabIndex = 20;
            this.panelDocumento.TabStop = false;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(12, 9);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(0, 24);
            this.lblTotalAPagar.TabIndex = 21;
            // 
            // datosTarjeta
            // 
            this.datosTarjeta.Controls.Add(this.lblFormatoCodSeg);
            this.datosTarjeta.Controls.Add(this.lblFormatoFecVenc);
            this.datosTarjeta.Controls.Add(this.lblFormatoTarjeta);
            this.datosTarjeta.Controls.Add(this.codigo);
            this.datosTarjeta.Controls.Add(this.lblCodigo);
            this.datosTarjeta.Controls.Add(this.lblFecVenc);
            this.datosTarjeta.Controls.Add(this.vencimiento);
            this.datosTarjeta.Controls.Add(this.lblNumero);
            this.datosTarjeta.Controls.Add(this.numero);
            this.datosTarjeta.Controls.Add(this.lblTipos);
            this.datosTarjeta.Controls.Add(this.tipos);
            this.datosTarjeta.Enabled = false;
            this.datosTarjeta.Location = new System.Drawing.Point(6, 408);
            this.datosTarjeta.Name = "datosTarjeta";
            this.datosTarjeta.Size = new System.Drawing.Size(366, 140);
            this.datosTarjeta.TabIndex = 22;
            this.datosTarjeta.TabStop = false;
            this.datosTarjeta.Text = "Datos Tarjeta";
            // 
            // lblFormatoCodSeg
            // 
            this.lblFormatoCodSeg.AutoSize = true;
            this.lblFormatoCodSeg.Location = new System.Drawing.Point(283, 121);
            this.lblFormatoCodSeg.Name = "lblFormatoCodSeg";
            this.lblFormatoCodSeg.Size = new System.Drawing.Size(34, 13);
            this.lblFormatoCodSeg.TabIndex = 10;
            this.lblFormatoCodSeg.Text = "(###)";
            // 
            // lblFormatoFecVenc
            // 
            this.lblFormatoFecVenc.AutoSize = true;
            this.lblFormatoFecVenc.Location = new System.Drawing.Point(101, 121);
            this.lblFormatoFecVenc.Name = "lblFormatoFecVenc";
            this.lblFormatoFecVenc.Size = new System.Drawing.Size(45, 13);
            this.lblFormatoFecVenc.TabIndex = 9;
            this.lblFormatoFecVenc.Text = "(MMAA)";
            // 
            // lblFormatoTarjeta
            // 
            this.lblFormatoTarjeta.AutoSize = true;
            this.lblFormatoTarjeta.Location = new System.Drawing.Point(101, 74);
            this.lblFormatoTarjeta.Name = "lblFormatoTarjeta";
            this.lblFormatoTarjeta.Size = new System.Drawing.Size(134, 13);
            this.lblFormatoTarjeta.TabIndex = 8;
            this.lblFormatoTarjeta.Text = "(####-####-####-####)";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(282, 94);
            this.codigo.MaxLength = 3;
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(75, 20);
            this.codigo.TabIndex = 7;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(211, 97);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código Seg.";
            // 
            // lblFecVenc
            // 
            this.lblFecVenc.AutoSize = true;
            this.lblFecVenc.Location = new System.Drawing.Point(12, 97);
            this.lblFecVenc.Name = "lblFecVenc";
            this.lblFecVenc.Size = new System.Drawing.Size(65, 13);
            this.lblFecVenc.TabIndex = 5;
            this.lblFecVenc.Text = "Vencimiento";
            // 
            // vencimiento
            // 
            this.vencimiento.Location = new System.Drawing.Point(101, 94);
            this.vencimiento.MaxLength = 4;
            this.vencimiento.Name = "vencimiento";
            this.vencimiento.Size = new System.Drawing.Size(100, 20);
            this.vencimiento.TabIndex = 4;
            // 
            // lblNumero
            // 
            this.lblNumero.Location = new System.Drawing.Point(12, 50);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(101, 47);
            this.numero.MaxLength = 19;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(256, 20);
            this.numero.TabIndex = 2;
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Location = new System.Drawing.Point(12, 22);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(75, 13);
            this.lblTipos.TabIndex = 1;
            this.lblTipos.Text = "Tipo de tarjeta";
            // 
            // tipos
            // 
            this.tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipos.FormattingEnabled = true;
            this.tipos.Location = new System.Drawing.Point(101, 19);
            this.tipos.Name = "tipos";
            this.tipos.Size = new System.Drawing.Size(256, 21);
            this.tipos.TabIndex = 0;
            // 
            // efectivo
            // 
            this.efectivo.AutoSize = true;
            this.efectivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.efectivo.Location = new System.Drawing.Point(264, 31);
            this.efectivo.Name = "efectivo";
            this.efectivo.Size = new System.Drawing.Size(108, 17);
            this.efectivo.TabIndex = 23;
            this.efectivo.Text = "Paga en Efectivo";
            this.efectivo.UseVisualStyleBackColor = true;
            this.efectivo.CheckedChanged += new System.EventHandler(this.efectivo_CheckedChanged);
            // 
            // DatosPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 577);
            this.ControlBox = false;
            this.Controls.Add(this.efectivo);
            this.Controls.Add(this.datosTarjeta);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.panelDocumento);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.cancelar);
            this.Name = "DatosPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos Pagador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.datos.ResumeLayout(false);
            this.datos.PerformLayout();
            this.panelDocumento.ResumeLayout(false);
            this.panelDocumento.PerformLayout();
            this.datosTarjeta.ResumeLayout(false);
            this.datosTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox datos;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.CheckBox esDiscapacitado;
        private System.Windows.Forms.GroupBox panelDocumento;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.GroupBox datosTarjeta;
        private System.Windows.Forms.CheckBox efectivo;
        private System.Windows.Forms.ComboBox tipos;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFecVenc;
        private System.Windows.Forms.TextBox vencimiento;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label lblFormatoCodSeg;
        private System.Windows.Forms.Label lblFormatoFecVenc;
        private System.Windows.Forms.Label lblFormatoTarjeta;
    }
}