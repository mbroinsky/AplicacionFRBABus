namespace FrbaBus.Compra_de_Pasajes
{
    partial class Paso2
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
            this.cantPasajes = new System.Windows.Forms.ComboBox();
            this.cantKilos = new System.Windows.Forms.TextBox();
            this.lblPasajes = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.siguiente = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cantPasajes
            // 
            this.cantPasajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cantPasajes.FormattingEnabled = true;
            this.cantPasajes.Location = new System.Drawing.Point(147, 20);
            this.cantPasajes.Name = "cantPasajes";
            this.cantPasajes.Size = new System.Drawing.Size(58, 21);
            this.cantPasajes.TabIndex = 0;
            // 
            // cantKilos
            // 
            this.cantKilos.Location = new System.Drawing.Point(147, 52);
            this.cantKilos.Name = "cantKilos";
            this.cantKilos.Size = new System.Drawing.Size(58, 20);
            this.cantKilos.TabIndex = 1;
            this.cantKilos.Text = "0";
            this.cantKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPasajes
            // 
            this.lblPasajes.AutoSize = true;
            this.lblPasajes.Location = new System.Drawing.Point(12, 23);
            this.lblPasajes.Name = "lblPasajes";
            this.lblPasajes.Size = new System.Drawing.Size(103, 13);
            this.lblPasajes.TabIndex = 2;
            this.lblPasajes.Text = "Cantidad de pasajes";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(12, 55);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(64, 13);
            this.lblKg.TabIndex = 3;
            this.lblKg.Text = "Kg. a enviar";
            // 
            // siguiente
            // 
            this.siguiente.Location = new System.Drawing.Point(130, 119);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(75, 23);
            this.siguiente.TabIndex = 4;
            this.siguiente.Text = "Siguiente >";
            this.siguiente.UseVisualStyleBackColor = true;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(15, 119);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Paso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 145);
            this.ControlBox = false;
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.lblPasajes);
            this.Controls.Add(this.cantKilos);
            this.Controls.Add(this.cantPasajes);
            this.Name = "Paso2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad a comprar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cantPasajes;
        private System.Windows.Forms.TextBox cantKilos;
        private System.Windows.Forms.Label lblPasajes;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.Button cancelar;
    }
}