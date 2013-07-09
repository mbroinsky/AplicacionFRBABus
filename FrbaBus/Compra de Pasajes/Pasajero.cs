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
        public bool Cancelado { get; set; }
        public Int32 IdViaje { get; set; }
        public bool HayDiscapacitado { get; set; }
        public Int16 NumAsiento { get; set; }
        public Int32 IdMicro { get; set; }

        public Pasajero(Int32 idViaje, Boolean hayDisc)
        {
            InitializeComponent();

            fechaNacimiento.Value = Configuracion.Instance().FechaSistema;
            this.IdViaje = idViaje;
            HayDiscapacitado = hayDisc;

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
            if (butacasLibres.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una butaca");
                return;
            }

            if (nombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nombre válido");
                return;
            }        

            if (apellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un Apellido válido");
                return;
            }

            if (direccion.Text == "")
            {
                MessageBox.Show("Debe ingresar una dirección válida");
                return;
            }

            if (HayDiscapacitado && esDiscapacitado.Checked)
            {
                MessageBox.Show("No se puede cargar más de una persona con capacidades especiales por Compra");
                return;
            }

            if (!Validador.esNumericoEnteroPositivo(telefono.Text))
            {
                MessageBox.Show("Debe ingresar un teléfono válido");
                return;
            }

            if (!Validador.esNumericoEnteroPositivo(dni.Text))
            {
                MessageBox.Show("Debe cargar un DNI válido");
                return;
            }

            if (mail.Text != "" && !Validador.esEmailValido(mail.Text))
            {
                MessageBox.Show("Debe cargar un email válido");
                return;
            }

            if (!femenino.Checked && !masculino.Checked)
            {
                MessageBox.Show("Debe seleccionar el sexo del pasajero");
                return;
            }

            if (fechaNacimiento.Value >= Configuracion.Instance().FechaSistema)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a hoy");
                return;
            }

            //Actualizo cliente o inserto uno nuevo
            this.Clie.Mail = mail.Text;
            this.Clie.Telefono = telefono.Text;
            this.Clie.Sexo = femenino.Checked ? 'F' : 'M';
            this.Clie.Discapacitado = esDiscapacitado.Checked;
            this.Clie.Nombre = nombre.Text;
            this.Clie.Apellido = apellido.Text;
            this.Clie.Dni = Convert.ToInt32(dni.Text);
            this.Clie.FecNac = fechaNacimiento.Value;
            this.Clie.Direccion = direccion.Text;

            if (this.Clie.Id == -1)
            {
                if(!this.Clie.Insertar())
                {
                    MessageBox.Show("Ocurrió un error al agregar el cliente, por favor intente nuevamente");
                    return;
                }
            }
            else
            {
                if (!this.Clie.Modificar())
                {
                    MessageBox.Show("Ocurrió un error al actualizar los datos del cliente, por favor intente nuevamente");
                    return;
                }
            }

            NumAsiento = Convert.ToInt16(butacasLibres.SelectedRows[0].Cells["Número"].Value);
            IdMicro = Convert.ToInt32(butacasLibres.SelectedRows[0].Cells["numMicro"].Value);

            this.Hide();
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
            }

            datos.Enabled = true;
            panelDocumento.Enabled = false;
        }

        private void butacasDisp_Click(object sender, EventArgs e)
        {
            butaca.Enabled = true;
            this.butacasLibres.DataSource = Butaca.TraerButacasLibres(this.IdViaje);
            this.butacasLibres.Columns["numMicro"].Visible = false;
        }
    }
}
