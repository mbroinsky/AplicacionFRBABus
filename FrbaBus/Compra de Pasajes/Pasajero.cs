using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Utilidades;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class Pasajero : Form
    {
        public Cliente Clie { get; set; }
        public Pasaje Pas { get; set; }
        public bool Cancelado { get; set; }

        public Pasajero()
        {
            InitializeComponent();

            fechaNacimiento.Value = Configuracion.Instance().FechaSistema;

            Cancelado = false;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar la compra?",
               "Cancelación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            
            Cancelado = true;

            this.Hide();
        }

        private void siguiente_Click(object sender, EventArgs e)
        {

        }

        private void continuar_Click(object sender, EventArgs e)
        {
            if (!Validador.esNumericoEnteroPositivo(dni.Text))
            {
                MessageBox.Show("El DNI ingresado no es válido");
                dni.Text = "";
                return;
            }

            this.Clie = new Cliente(Convert.ToInt32(dni.Text));

            if (Clie.Id == -1)
            {
                if (MessageBox.Show("El DNI ingresado no existe ¿Desea cargar un nuevo pasajero en el sistema?",
                    "DNI Inexistente",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    dni.Text = "";
                    dni.Focus();
                    return;
                }

                datos.Enabled = true;
            }
            else
            {
                this.nombre.Text = Clie.Nombre;
                this.apellido.Text = Clie.Apellido;
                this.direccion.Text = Clie.Direccion;
                this.telefono.Text = Clie.Telefono;
                this.mail.Text = Clie.Mail;
                this.fechaNacimiento.Value = Clie.FecNac;

                if (Clie.Sexo == 'M')
                    masculino.Checked = true;
                else if (Clie.Sexo == 'S')
                    femenino.Checked = true;
                
                datos.Enabled = true;
            }
        }

        private void butacasDisp_Click(object sender, EventArgs e)
        {
            butaca.Enabled = true;
        }
    }
}
