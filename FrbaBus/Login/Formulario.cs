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

            OleDbConnection con = new OleDbConnection();

            con.ConnectionString = "Provider=SQLOLEDB;Data Source=" +
                 Configuracion.Instance().getServidorBase() +
                 ";Initial Catalog=" + Configuracion.Instance().getBaseDatos() +
                 ";User ID=" + Configuracion.Instance().getUsuario() +
                 ";Password=" + Configuracion.Instance().getClave() + ";";

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from NOT_NULL.usuario where USR_nombre = '" +
                    this.Usuario.Text + "' and usr_password = '" + SHA256Encrypt(this.Password.Text) + "';",
                    con);

            Int16 i = Int16.Parse(cmd.ExecuteScalar().ToString());
                     
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
