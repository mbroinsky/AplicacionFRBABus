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
            butacas = new DataTable(); 
            this.butacas = butacasMicro;
            prepararGrilla();
           
            Butacas.Columns[0].Visible = false;

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (Validador.esNumericoEnteroPositivo(cantidad.Text) && Validador.esNumericoEnteroPositivo(piso.Text))
            {
                if (cantidad.Text.Length > 0 && piso.Text.Length > 0)
                {
                    int asientos;
                    for (asientos = 1; asientos <= Convert.ToInt32(cantidad.Text); asientos++)
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
        }

        private void piso_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
        }

        private void prepararGrilla()
        {

            Butacas.Columns.Clear();

            DataGridViewColumn cMicro = new DataGridViewTextBoxColumn();;
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

            Butacas.DataSource = butacas;
           
        }

    }
}
