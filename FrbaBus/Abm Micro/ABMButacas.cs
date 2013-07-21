using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Utilidades;

namespace FrbaBus.Abm_Micro
{
    public partial class ABMButacas : Form
    {
        public DataTable butacas{get;set;}
        public DataGridViewComboBoxColumn comboBoxPasilloVentana;

        public ABMButacas()
        {
            InitializeComponent();
            butacas = new DataTable();
            butacas.Columns.Add("idMicro");
            butacas.Columns.Add("Piso");
            butacas.Columns.Add("Nro. Asiento");
            butacas.Columns.Add("Tipo de Asiento");
            prepararGrilla();
            piso.Text = "1";
        }

        public ABMButacas(DataTable butacasMicro)
        {
            InitializeComponent();
            this.butacas = butacasMicro;
            prepararGrilla();

            if (butacas.Rows.Count == 0)
                piso.Text = "1";
            else
                piso.Text = Convert.ToString(Convert.ToInt32(butacas.Rows[butacas.Rows.Count - 1][1]) + 1);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (Validador.esNumericoEnteroPositivo(cantidad.Text) && Validador.esNumericoEnteroPositivo(piso.Text))
            {
                if (cantidad.Text.Length > 0 && piso.Text.Length > 0)
                {
                    int asientos;

                    if (butacas.Rows.Count == 0)
                        asientos = 1;
                    else
                        asientos = Convert.ToInt32(butacas.Rows[butacas.Rows.Count - 1][2]) + 1;

                    for (int agregar = 1; agregar <= Convert.ToInt32(cantidad.Text); asientos++, agregar++)
                    {
                        butacas.Rows.Add(new object[] { 0, Convert.ToInt32(piso.Text), asientos, "Pasillo" });
                    }

                    piso.Text = Convert.ToString(Convert.ToInt32(piso.Text)+1);
                }
                else
                {
                    MessageBox.Show("Los valores ingresados deben ser mayores a cero");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Los valores ingresados deben ser numéricos");
                return;
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            butacas.Clear();
            piso.Text = "1";
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
        }

        private void prepararGrilla()
        {
            Butacas.Columns.Clear();

            DataGridViewColumn cMicro = new DataGridViewTextBoxColumn(); ;
            cMicro.HeaderText = "idMicro";
            cMicro.DataPropertyName = "idMicro";

            DataGridViewColumn cPiso = new DataGridViewTextBoxColumn();
            cPiso.HeaderText = "Piso";
            cPiso.DataPropertyName = "Piso";

            DataGridViewColumn cNroAsiento = new DataGridViewTextBoxColumn();
            cNroAsiento.HeaderText = "Nro. Asiento";
            cNroAsiento.DataPropertyName = "Nro. Asiento";

            DataGridViewComboBoxColumn cTipoDeAsiento = new DataGridViewComboBoxColumn();
            var tipo = new List<string>() { "Pasillo", "Ventanilla" };
            cTipoDeAsiento.DataSource = tipo;
            cTipoDeAsiento.HeaderText = "Tipo de Asiento";
            cTipoDeAsiento.DataPropertyName = "Tipo de Asiento";

            Butacas.Columns.AddRange(cMicro, cPiso, cNroAsiento, cTipoDeAsiento);
            Butacas.Columns[0].Visible = false;
            Butacas.Columns[0].ReadOnly = true;
            Butacas.Columns[1].ReadOnly = true;
            Butacas.Columns[2].ReadOnly = true;
            Butacas.Columns[3].ReadOnly = false;

            Butacas.DataSource = butacas;
        }
    }
}
