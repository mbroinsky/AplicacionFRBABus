using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccesoADatos.Orm;

namespace Registrar_LLegada_Micro
{
    public partial class RegistrarLlegada : Form
    {
        public RegistrarLlegada()
        {
            InitializeComponent();

            fechaLlegada.Value = DateTime.Now;

            Ciudad.LlenarCombo(ciudadesOrigen);
            Ciudad.LlenarCombo(ciudadesDestino);
            Micro.LlenarCombo(patentesMicros);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (ciudadesDestino.SelectedIndex == ciudadesOrigen.SelectedIndex)
            {
                MessageBox.Show("La ciudad de destino no puede coincidir con la ciudad de origen");
                return;
            }

            if (fechaLlegada.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de arribo no puede ser superior a hoy");
                return;
            }

            llegadasCargadas.Rows.Add(patentesMicros.Text, ciudadesOrigen.Text,
                                    ciudadesDestino.Text, fechaLlegada.Value,
                                    patentesMicros.SelectedValue, ciudadesOrigen.SelectedValue,
                                    ciudadesDestino.SelectedValue);

            fechaLlegada.Value = DateTime.Now;
            ciudadesDestino.SelectedIndex = 0;
            ciudadesOrigen.SelectedIndex = 0;
            patentesMicros.SelectedIndex = 0;
        }


    }
}
