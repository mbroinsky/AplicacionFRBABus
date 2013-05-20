namespace FrbaBus.Abm_Permisos
{
    partial class SeleccionRol
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
            this.Roles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // Roles
            // 
            this.Roles.AllowUserToAddRows = false;
            this.Roles.AllowUserToDeleteRows = false;
            this.Roles.AllowUserToResizeColumns = false;
            this.Roles.AllowUserToResizeRows = false;
            this.Roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Roles.Location = new System.Drawing.Point(12, 130);
            this.Roles.MultiSelect = false;
            this.Roles.Name = "Roles";
            this.Roles.ReadOnly = true;
            this.Roles.RowHeadersVisible = false;
            this.Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Roles.ShowEditingIcon = false;
            this.Roles.Size = new System.Drawing.Size(370, 259);
            this.Roles.TabIndex = 0;
            // 
            // SeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 401);
            this.ControlBox = false;
            this.Controls.Add(this.Roles);
            this.Name = "SeleccionRol";
            this.Text = "Seleccion de Rol";
            ((System.ComponentModel.ISupportInitialize)(this.Roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Roles;
    }
}