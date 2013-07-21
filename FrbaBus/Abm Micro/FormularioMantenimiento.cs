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

            fechaDeAlta.Value = Convert.ToDateTime(Configuracion.Instance().FechaSistema.ToString("dd/MM/yyyy"));

            fechaDeBaja.Value = Convert.ToDateTime(Configuracion.Instance().FechaSistema.ToString("dd/MM/yyyy"));
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (fechaDeBaja.Value.ToString("yyyy-MM-dd").CompareTo(Configuracion.Instance().FechaSistema.ToString("yyyy-MM-dd")) <= 0)
            {
                MessageBox.Show("La fecha de ingreso a mantenimiento debe ser mayor a hoy");
                return;
            }

            if (fechaDeAlta.Value <= fechaDeBaja.Value)
            {
                MessageBox.Show("La fecha de reincorporación debe ser mayor a la fecha de mantenimiento");
                return;
            }

            Micro.registarMantenimiento(id, fechaDeBaja.Value, fechaDeAlta.Value);

            result = true;
            fechaInicio = fechaDeBaja.Value;
            fechaFin = fechaDeAlta.Value; 

            this.Close();
        }
    }
}
