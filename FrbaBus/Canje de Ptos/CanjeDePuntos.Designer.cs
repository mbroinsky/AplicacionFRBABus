namespace FrbaBus.Canje_de_Ptos
{
    partial class CanjeDePuntos
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
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.campoDNICliente = new System.Windows.Forms.TextBox();
            this.listarProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaProductos
            // 
            this.grillaProductos.AllowUserToAddRows = false;
            this.grillaProductos.AllowUserToDeleteRows = false;
            this.grillaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grillaProductos.Location = new System.Drawing.Point(12, 39);
            this.grillaProductos.MultiSelect = false;
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.RowHeadersVisible = false;
            this.grillaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaProductos.Size = new System.Drawing.Size(268, 217);
            this.grillaProductos.TabIndex = 7;
            this.grillaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPuntos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI";
            // 
            // campoDNICliente
            // 
            this.campoDNICliente.Location = new System.Drawing.Point(44, 12);
            this.campoDNICliente.Name = "campoDNICliente";
            this.campoDNICliente.Size = new System.Drawing.Size(123, 20);
            this.campoDNICliente.TabIndex = 5;
            this.campoDNICliente.TextChanged += new System.EventHandler(this.campoDNICliente_TextChanged);
            // 
            // listarProductos
            // 
            this.listarProductos.Location = new System.Drawing.Point(173, 10);
            this.listarProductos.Name = "listarProductos";
            this.listarProductos.Size = new System.Drawing.Size(107, 23);
            this.listarProductos.TabIndex = 4;
            this.listarProductos.Text = "Listar Productos";
            this.listarProductos.UseVisualStyleBackColor = true;
            this.listarProductos.Click += new System.EventHandler(this.listarProductos_Click);
            // 
            // CanjeDePuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.grillaProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoDNICliente);
            this.Controls.Add(this.listarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanjeDePuntos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Canje de Puntos";
            this.Load += new System.EventHandler(this.CanjeDePuntos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoDNICliente;
        private System.Windows.Forms.Button listarProductos;
    }
}