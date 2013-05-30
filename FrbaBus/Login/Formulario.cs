using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;  

namespace FrbaBus.Login
{
    public partial class Formulario : Form
    {
        public Boolean LoginOk { get; set; } 

        public Formulario()
        {
            LoginOk = false;

            InitializeComponent();
        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            if (this.Usuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
                return;
            }

            if (this.Password.Text == "")
            {
                MessageBox.Show("Debe ingresar una clave");
                return;
            }
            
            var user = Globales.Instance().usr;
            
            if (user.TraerUsuario(this.Usuario.Text))
            {
                if (user.CantIntentos > 2)
                {
                    MessageBox.Show("Máxima cantidad de intentos alcanzada");
                    Usuario.Text = "";
                    Password.Text = "";

                    return;
                }
                
                if (user.Password != SHA256Encrypt(this.Password.Text))
                {
                    MessageBox.Show("Usuario o password erróneo");
                    Usuario.Text = "";
                    Password.Text = "";
                    
                    user.CambiarCantIntentos(user.Id, user.CantIntentos + 1);
                    return;
                }

                //Si el usuario tiene cantidad de intentos fallidos mayor que 0 y el último intento fue
                //ok, se debe volver a 0
                if (user.CantIntentos > 0)
                    user.CambiarCantIntentos(user.Id, 0);

                LoginOk = true;

                this.Close();
            } 
            else
            {
                MessageBox.Show("Usuario o password erróneo");
                Usuario.Text = "";
                Password.Text = "";
                return;
            }
        }

        private string SHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }  

        private void Volver_Click(object sender, EventArgs e)
        {
            var acceso = new AccesoSistema();

            this.Close();

            acceso.Show();
        }
    }
}
