using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccesoADatos.Orm;

namespace FrbaBus.ListadoEstadistico
{
    public partial class SeleccionListado : Form
    {
        public SeleccionListado()
        {
            InitializeComponent();

            comienzoSemestre.Value = Configuracion.Instance().FechaSistema.AddMonths(-6);
        }

        private void ver_Click(object sender, EventArgs e)
        {
            if (tipoListado.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de listado");
                return;
            }

            switch (tipoListado.SelectedIndex)
            {
                case 0:
                    resultados.DataSource = Listado.ListadoDestinosConMasPasajes(comienzoSemestre.Value, 
                        comienzoSemestre.Value.AddMonths(6));
                    break;
                case 1:
                    resultados.DataSource = Listado.ListadoDestinosConMicrosMasVacios(comienzoSemestre.Value,
                        comienzoSemestre.Value.AddMonths(6));
                    break;
                case 2:
                    resultados.DataSource = Listado.ListadoClientesConMasPuntos(comienzoSemestre.Value, 
                        comienzoSemestre.Value.AddMonths(6));
                    break;
                case 3:
                    resultados.DataSource = Listado.ListadoDestinosConMasCancelaciones(comienzoSemestre.Value, 
                        comienzoSemestre.Value.AddMonths(6));
                    break;
                case 4:
                    resultados.DataSource = Listado.ListadoMicrosConMenosDisponibilidad(comienzoSemestre.Value,
                        comienzoSemestre.Value.AddMonths(6));
                    break;
            }
        }
    }
}
