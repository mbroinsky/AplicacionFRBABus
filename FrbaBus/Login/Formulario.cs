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
        public Formulario()
        {
            InitializeComponent();
        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            DataTable usuario = null;

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

            usuario = Globales.Instance().cons.getUsuario(this.Usuario.Text).Tables[0];

            if (usuario.Rows.Count > 0)
            {
                if ((Int16)usuario.Rows[0]["USR_intentos"] > 2)
                {
                    MessageBox.Show("Máxima cantidad de intentos alcanzada");
                    Usuario.Text = "";
                    Password.Text = "";

                    return;
                }

                if (usuario.Rows[0]["USR_password"].ToString() != SHA256Encrypt(this.Password.Text))
                {
                    MessageBox.Show("Usuario o password erróneo");
                    Usuario.Text = "";
                    Password.Text = "";
                    //TODO: Incrementar contador
                    return;
                }

                Globales.Instance().usr.NombreUsr = usuario.Rows[0]["USR_Nombre"] + " " + usuario.Rows[0]["USR_Apellido"];
                Globales.Instance().usr.Id = (Int16)usuario.Rows[0]["USR_idUsuario"];
                Globales.Instance().usr.Rol = (String)usuario.Rows[0]["USR_idRol"];
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
            this.Close();
        }
    }
}
