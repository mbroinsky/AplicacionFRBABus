namespace FrbaBus.Abm_Micro
{
    partial class AM_Micro
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
            this.patente = new System.Windows.Forms.TextBox();
            this.matricula = new System.Windows.Forms.Label();
            this.servicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hibilitado = new System.Windows.Forms.CheckBox();
            this.modelo = new System.Windows.Forms.ComboBox();
            this.marca = new System.Windows.Forms.ComboBox();
            this.capacidad = new System.Windows.Forms.TextBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agregarButacas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patente
            // 
            this.patente.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.patente.Location = new System.Drawing.Point(170, 45);
            this.patente.MaxLength = 7;
            this.patente.Name = "patente";
            this.patente.Size = new System.Drawing.Size(100, 20);
            this.patente.TabIndex = 0;
            this.patente.TextChanged += new System.EventHandler(this.Matrícula_TextChanged);
            // 
            // matricula
            // 
            this.matricula.AutoSize = true;
            this.matricula.Location = new System.Drawing.Point(74, 48);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(55, 13);
            this.matricula.TabIndex = 1;
            this.matricula.Text = "Matrícula:";
            this.matricula.Click += new System.EventHandler(this.label1_Click);
            // 
            // servicio
            // 
            this.servicio.FormattingEnabled = true;
            this.servicio.Location = new System.Drawing.Point(170, 74);
            this.servicio.Name = "servicio";
            this.servicio.Size = new System.Drawing.Size(121, 21);
            this.servicio.TabIndex = 2;
            this.servicio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de servicio:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capacidad (KG):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Habilitado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Modelo:";
            // 
            // hibilitado
            // 
            this.hibilitado.AutoSize = true;
            this.hibilitado.Location = new System.Drawing.Point(170, 135);
            this.hibilitado.Name = "hibilitado";
            this.hibilitado.Size = new System.Drawing.Size(15, 14);
            this.hibilitado.TabIndex = 8;
            this.hibilitado.UseVisualStyleBackColor = true;
            this.hibilitado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // modelo
            // 
            this.modelo.FormattingEnabled = true;
            this.modelo.Location = new System.Drawing.Point(170, 161);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(121, 21);
            this.modelo.TabIndex = 9;
            this.modelo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // marca
            // 
            this.marca.FormattingEnabled = true;
            this.marca.Location = new System.Drawing.Point(170, 190);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(121, 21);
            this.marca.TabIndex = 10;
            // 
            // capacidad
            // 
            this.capacidad.Location = new System.Drawing.Point(170, 106);
            this.capacidad.Name = "capacidad";
            this.capacidad.Size = new System.Drawing.Size(100, 20);
            this.capacidad.TabIndex = 11;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(195, 262);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 12;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Location = new System.Drawing.Point(274, 262);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 13;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agregarButacas);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 242);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Micros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_2);
            // 
            // agregarButacas
            // 
            this.agregarButacas.Location = new System.Drawing.Point(155, 206);
            this.agregarButacas.Name = "agregarButacas";
            this.agregarButacas.Size = new System.Drawing.Size(121, 23);
            this.agregarButacas.TabIndex = 0;
            this.agregarButacas.Text = "Agregar butacas";
            this.agregarButacas.UseVisualStyleBackColor = true;
            this.agregarButacas.Click += new System.EventHandler(this.button3_Click);
            // 
            // AM_Micro
            // 
            this.AcceptButton = this.aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar;
            this.ClientSize = new System.Drawing.Size(367, 297);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.capacidad);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.hibilitado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicio);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.patente);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AM_Micro";
            this.Text = "Administración de Micros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patente;
        private System.Windows.Forms.Label matricula;
        private System.Windows.Forms.ComboBox servicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox modelo;
        private System.Windows.Forms.ComboBox marca;
        private System.Windows.Forms.TextBox capacidad;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button agregarButacas;
        private System.Windows.Forms.CheckBox hibilitado;
    }
}