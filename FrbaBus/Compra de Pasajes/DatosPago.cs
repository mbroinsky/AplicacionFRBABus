using System;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Utilidades;
using FrbaBus.AccesoADatos.Orm;


namespace FrbaBus.Compra_de_Pasajes
{
    public partial class DatosPago : Form
    {
        public Cliente Clie { get; set; }
        public bool Cancelado { get; set; }
        private Double TotalAPagar;
        public bool Efectivo { get; set; }
        public Tarjeta Tar { get; set; }

        public DatosPago(Double valorTotal, Boolean habEfectivo)
        {
            InitializeComponent();

            fechaNacimiento.Value = Configuracion.Instance().FechaSistema;
            TotalAPagar = valorTotal;

            Cancelado = false;

            lblTotalAPagar.Text = "Total a pagar: $" + Convert.ToString(valorTotal);

            if (habEfectivo)
                efectivo.Visible = true;
            else
                efectivo.Visible = false;

            Tarjeta.LlenarComboTipos(tipos);
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

            if (!efectivo.Checked)
            {
                if (!Validador.esVencTarjValido(vencimiento.Text))
                {
                    MessageBox.Show("El vencimiento de la tarjeta no es válido");
                    return;
                }

                if (!Validador.esTarjetaValida(numero.Text))
                {
                    MessageBox.Show("El número de la tarjeta no es válido");
                    return;
                }

                if (!Validador.esNumericoEnteroPositivo(codigo.Text) || codigo.TextLength < 3)
                {
                    MessageBox.Show("El código de seguridad de la tarjeta no es válido");
                    return;
                }

                Tar = new Tarjeta(numero.Text, vencimiento.Text, Convert.ToInt32(tipos.SelectedValue), Convert.ToInt16(codigo.Text));

                if (!Tar.Insertar())
                {
                    MessageBox.Show("Ocurrió un error al cargar la tarjeta, por favor intente nuevamente");
                    return;
                }
            }
            else
            {
                Tar = new Tarjeta();
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
                if (!this.Clie.Insertar())
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

            if (!efectivo.Checked)
                datosTarjeta.Enabled = true;
            
            panelDocumento.Enabled = false;
        }

        private void efectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (efectivo.Checked)
                datosTarjeta.Enabled = false;
            else
                datosTarjeta.Enabled = true;
        }
    }
}
