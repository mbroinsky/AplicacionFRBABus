﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.GenerarViaje
{
    public partial class GenerarViaje : Form
    {
        public GenerarViaje()
        {
            InitializeComponent();
            fechaSalida.Value = Configuracion.Instance().FechaSistema;
            
            Recorrido.ListarCombo(recorridos);

            generar.Enabled = false;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (recorridos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un recorrido");
                return;
            }

            //Se controla que la fecha de viaje no sea inferior a hoy dentro de 3 horas
            //Esto es para que haya tiempo para vender pasajes
            if (fechaSalida.Value < Configuracion.Instance().FechaSistema.AddHours(3))
            {
                MessageBox.Show("Debe seleccionar una fecha mayor hoy. El viaje debe salir en 3 hs como mínimo.");
                return;
            }

            grpMicros.Enabled = true;
            grpPreseleccion.Enabled = false;

            volver.Enabled = true;
            buscar.Enabled = false;
            generar.Enabled = true;
            
            Micro.LlenarComboDisponibles(Convert.ToInt32(recorridos.SelectedValue), fechaSalida.Value, microsDisp);
        }

        private void volver_Click(object sender, EventArgs e)
        {
            grpMicros.Enabled = false;
            grpPreseleccion.Enabled = true;

            volver.Enabled = false;
            buscar.Enabled = true;
            generar.Enabled = false;

            microsDisp.DataSource = null;
        }

        private void generar_Click(object sender, EventArgs e)
        {
            if (microsDisp.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un micro de la lista");
                return;
            }

            var viaje = new Viaje(Convert.ToInt32(microsDisp.SelectedValue),
                                Convert.ToInt32(recorridos.SelectedValue),
                                fechaSalida.Value);

            if (!viaje.Insertar())
            {
                MessageBox.Show("Ocurrió un error al insertar el viaje");
                return;
            }

            this.Close();
        }
    }
}
