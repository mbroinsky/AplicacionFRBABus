﻿namespace FrbaBus
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
            this.ABMMicro = new System.Windows.Forms.Button();
            this.ABMRol = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.generarViaje = new System.Windows.Forms.Button();
            this.registrarLlegadas = new System.Windows.Forms.Button();
            this.abmRecorridos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ABMMicro
            // 
            this.ABMMicro.Location = new System.Drawing.Point(12, 92);
            this.ABMMicro.Name = "ABMMicro";
            this.ABMMicro.Size = new System.Drawing.Size(75, 45);
            this.ABMMicro.TabIndex = 0;
            this.ABMMicro.Text = "ABM Micros";
            this.ABMMicro.UseVisualStyleBackColor = true;
            this.ABMMicro.Click += new System.EventHandler(this.AMicro_Click);
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
            this.Salir.Location = new System.Drawing.Point(598, 92);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 44);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // generarViaje
            // 
            this.generarViaje.Location = new System.Drawing.Point(175, 92);
            this.generarViaje.Name = "generarViaje";
            this.generarViaje.Size = new System.Drawing.Size(75, 45);
            this.generarViaje.TabIndex = 3;
            this.generarViaje.Text = "Generar Viaje";
            this.generarViaje.UseVisualStyleBackColor = true;
            this.generarViaje.Click += new System.EventHandler(this.GenerarViaje_Click);
            // 
            // registrarLlegadas
            // 
            this.registrarLlegadas.Location = new System.Drawing.Point(256, 93);
            this.registrarLlegadas.Name = "registrarLlegadas";
            this.registrarLlegadas.Size = new System.Drawing.Size(75, 44);
            this.registrarLlegadas.TabIndex = 4;
            this.registrarLlegadas.Text = "Registrar Llegadas";
            this.registrarLlegadas.UseVisualStyleBackColor = true;
            this.registrarLlegadas.Click += new System.EventHandler(this.registrarLlegadas_Click);
            // 
            // abmRecorridos
            // 
            this.abmRecorridos.Location = new System.Drawing.Point(338, 93);
            this.abmRecorridos.Name = "abmRecorridos";
            this.abmRecorridos.Size = new System.Drawing.Size(75, 44);
            this.abmRecorridos.TabIndex = 5;
            this.abmRecorridos.Text = "ABM Recorridos";
            this.abmRecorridos.UseVisualStyleBackColor = true;
            this.abmRecorridos.Click += new System.EventHandler(this.abmRecorridos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 149);
            this.ControlBox = false;
            this.Controls.Add(this.abmRecorridos);
            this.Controls.Add(this.registrarLlegadas);
            this.Controls.Add(this.generarViaje);
            this.Controls.Add(this.ABMRol);
            this.Controls.Add(this.ABMMicro);
            this.Controls.Add(this.Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRBABus Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ABMMicro;
        private System.Windows.Forms.Button ABMRol;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button generarViaje;
        private System.Windows.Forms.Button registrarLlegadas;
        private System.Windows.Forms.Button abmRecorridos;
    }
}
