using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.Abm_Micro
{
    public partial class FormularioMantenimiento : Form
    {
        public int id;
        public bool result;
        public DateTime fechaInicio;
        public DateTime fechaFin;

        public FormularioMantenimiento()
        {
            InitializeComponent();

            fechaDeAlta.Value = Configuracion.Instance().FechaSistema;

            fechaDeBaja.Value = Configuracion.Instance().FechaSistema;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (fechaDeBaja.Value < Configuracion.Instance().FechaSistema)
            {
                MessageBox.Show("Debe seleccionar igual o mayor a la de hoy");
                return;
            }

            if (fechaDeAlta.Value <= fechaDeBaja.Value)
            {
                MessageBox.Show("La fecha de reincorporación debe ser mayor a la fecha de mantenimiento");
                return;
            }

            Micro.registarMantenimiento(id, Convert.ToString(fechaDeBaja.Value), Convert.ToString(fechaDeAlta.Value));

            result = true;
            fechaInicio = fechaDeBaja.Value;
            fechaFin = fechaDeAlta.Value; 

            this.Close();

        }
    }
}
