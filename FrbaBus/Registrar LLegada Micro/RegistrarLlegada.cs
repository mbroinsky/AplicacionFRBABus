﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;
using FrbaBus.AccesoADatos;


namespace FrbaBus.Registrar_LLegada_Micro
{
    public partial class RegistrarLlegada : Form
    {
        public RegistrarLlegada()
        {
            InitializeComponent();

            fechaLlegada.Value = Configuracion.Instance().FechaSistema;

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

            if (fechaLlegada.Value.ToString("yyyy-MM-dd HH:mm:ss").CompareTo(Configuracion.Instance().FechaSistema.ToString("yyyy-MM-dd HH:mm:ss")) > 0)
            {
                MessageBox.Show("La fecha de arribo no puede ser superior a hoy");
                return;
            }

            llegadasCargadas.Rows.Add(patentesMicros.Text, ciudadesOrigen.Text,
                                    ciudadesDestino.Text, fechaLlegada.Value,
                                    patentesMicros.SelectedValue, ciudadesOrigen.SelectedValue,
                                    ciudadesDestino.SelectedValue);

            fechaLlegada.Value = Configuracion.Instance().FechaSistema;
            ciudadesDestino.SelectedIndex = 0;
            ciudadesOrigen.SelectedIndex = 0;
            patentesMicros.SelectedIndex = 0;
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            Conector.Datos.IniciarTransaccion();

            foreach (DataGridViewRow fila in llegadasCargadas.Rows)
            {
                try
                {
                    Viaje.RegistrarLlegada(Convert.ToDateTime(fila.Cells["fecLlegada"].Value), 
                       Convert.ToInt32(fila.Cells["idMicro"].Value), 
                       Convert.ToInt32(fila.Cells["idOrigen"].Value), 
                       Convert.ToInt32(fila.Cells["idDestino"].Value));
                }
                catch
                {
                    MessageBox.Show("Ocurrió un error al registrar las llegadas, por favor intente nuevamente");
                    Conector.Datos.AbortarTransaccion();
                    return;
                }
            }

            Conector.Datos.TerminarTransaccion();

            this.Close();
        }
    }
}
