namespace FrbaBus
{
    partial class Menu
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
            this.AMicro = new System.Windows.Forms.Button();
            this.ABMRol = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.GenerarViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AMicro
            // 
            this.AMicro.Location = new System.Drawing.Point(12, 92);
            this.AMicro.Name = "AMicro";
            this.AMicro.Size = new System.Drawing.Size(75, 45);
            this.AMicro.TabIndex = 0;
            this.AMicro.Text = "ABM Micros";
            this.AMicro.UseVisualStyleBackColor = true;
            this.AMicro.Click += new System.EventHandler(this.AMicro_Click);
            // 
            // ABMRol
            // 
            this.ABMRol.Location = new System.Drawing.Point(93, 92);
            this.ABMRol.Name = "ABMRol";
            this.ABMRol.Size = new System.Drawing.Size(75, 45);
            this.ABMRol.TabIndex = 1;
            this.ABMRol.Text = "ABM Rol";
            this.ABMRol.UseVisualStyleBackColor = true;
            this.ABMRol.Click += new System.EventHandler(this.ABMRol_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(598, 114);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // GenerarViaje
            // 
            this.GenerarViaje.Location = new System.Drawing.Point(175, 92);
            this.GenerarViaje.Name = "GenerarViaje";
            this.GenerarViaje.Size = new System.Drawing.Size(75, 45);
            this.GenerarViaje.TabIndex = 3;
            this.GenerarViaje.Text = "Generar Viaje";
            this.GenerarViaje.UseVisualStyleBackColor = true;
            this.GenerarViaje.Click += new System.EventHandler(this.GenerarViaje_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 149);
            this.ControlBox = false;
            this.Controls.Add(this.GenerarViaje);
            this.Controls.Add(this.ABMRol);
            this.Controls.Add(this.AMicro);
            this.Controls.Add(this.Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRBABus Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AMicro;
        private System.Windows.Forms.Button ABMRol;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button GenerarViaje;
    }
}
