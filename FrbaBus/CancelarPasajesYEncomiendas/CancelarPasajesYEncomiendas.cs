using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;
using FrbaBus.Utilidades;
using FrbaBus.AccesoADatos;

namespace FrbaBus.CancelarPasajesYEncomiendas
{
    public partial class CancelarPasajesYEncomiendas : Form
    {

        public CancelarPasajesYEncomiendas()
        {
            InitializeComponent();
        }

        private void buscarPasajesYEncomiendas_Click(object sender, EventArgs e)
        {
            if (Validador.esNumericoEnteroPositivo(textBoxIdVenta.Text))
            {
                this.cargarGrilla();
            }
            else
            {
                MessageBox.Show("El valor ingresado debe ser un número positivo");
            }
        }

        private void cargarGrilla()
        {
            grillaPasajesYEncomiendas.Columns.Clear();

            DataTable dt = Venta.TraerPasajesYEncomiendas(Convert.ToInt32(textBoxIdVenta.Text));

            if (dt.Rows.Count == 0) 
            { 
                MessageBox.Show("No se encontraron datos para esa venta"); 
            }
            else
            {
                grillaPasajesYEncomiendas.DataSource = dt;
            }
        }


        private void cancelarPasEnc_Click(object sender, EventArgs e)
        {
            if (grillaPasajesYEncomiendas.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionó pasajes para cancelar");
                return;
            }

            if (motivo.Text == "")
            {
                MessageBox.Show("Debe informar el motivo de la cancelación");
                return;
            }

            Conector.Datos.IniciarTransaccion();

            var idDev = Venta.GeneraDevolucion(motivo.Text, Configuracion.Instance().FechaSistema);

            if (idDev == -1)
            {
                MessageBox.Show("Falló la devolución");
                Conector.Datos.AbortarTransaccion();
                return;
            }

            foreach (DataGridViewRow fila in grillaPasajesYEncomiendas.SelectedRows)
            {
                if (fila.Cells["Tipo"].Value.ToString() == "Pasaje")
                {
                    if (!Pasaje.Devolver(idDev, Convert.ToInt32(fila.Cells["Id"].Value)))
                    {
                        MessageBox.Show("Falló la devolución");
                        Conector.Datos.AbortarTransaccion();
                        return;
                    }
                }
                else
                {
                    if (!Encomienda.Devolver(idDev, Convert.ToInt32(fila.Cells["Id"].Value)))
                    {
                        MessageBox.Show("Falló la devolución");
                        Conector.Datos.AbortarTransaccion();
                        return;
                    }
                }
            }

            Conector.Datos.TerminarTransaccion();

            MessageBox.Show("La devolución se realizo con éxito");

            this.Close();
        }
    }
}
