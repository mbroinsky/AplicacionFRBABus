namespace FrbaBus.Consulta_Puntos_Adquiridos
{
    partial class ConsultaDePuntos
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
            this.button1 = new System.Windows.Forms.Button();
            this.campoDNICliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaPuntos = new System.Windows.Forms.DataGridView();
            this.totalDePuntos = new System.Windows.Forms.Label();
            this.totalPuntos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // campoDNICliente
            // 
            this.campoDNICliente.Location = new System.Drawing.Point(44, 10);
            this.campoDNICliente.Name = "campoDNICliente";
            this.campoDNICliente.Size = new System.Drawing.Size(146, 20);
            this.campoDNICliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // grillaPuntos
            // 
            this.grillaPuntos.AllowUserToAddRows = false;
            this.grillaPuntos.AllowUserToDeleteRows = false;
            this.grillaPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPuntos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grillaPuntos.Location = new System.Drawing.Point(12, 37);
            this.grillaPuntos.Name = "grillaPuntos";
            this.grillaPuntos.ReadOnly = true;
            this.grillaPuntos.RowHeadersVisible = false;
            this.grillaPuntos.Size = new System.Drawing.Size(268, 217);
            this.grillaPuntos.TabIndex = 3;
            // 
            // totalDePuntos
            // 
            this.totalDePuntos.AutoSize = true;
            this.totalDePuntos.Location = new System.Drawing.Point(12, 261);
            this.totalDePuntos.Name = "totalDePuntos";
            this.totalDePuntos.Size = new System.Drawing.Size(87, 13);
            this.totalDePuntos.TabIndex = 4;
            this.totalDePuntos.Text = "Total de puntos: ";
            this.totalDePuntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPuntos
            // 
            this.totalPuntos.AutoSize = true;
            this.totalPuntos.Location = new System.Drawing.Point(95, 261);
            this.totalPuntos.Name = "totalPuntos";
            this.totalPuntos.Size = new System.Drawing.Size(13, 13);
            this.totalPuntos.TabIndex = 5;
            this.totalPuntos.Text = "0";
            // 
            // ConsultaDePuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 283);
            this.Controls.Add(this.totalPuntos);
            this.Controls.Add(this.totalDePuntos);
            this.Controls.Add(this.grillaPuntos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoDNICliente);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaDePuntos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Puntos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox campoDNICliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaPuntos;
        private System.Windows.Forms.Label totalDePuntos;
        private System.Windows.Forms.Label totalPuntos;
    }
}