using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus
{
    public partial class AccesoSistema : Form
    {
        public AccesoSistema()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login.Formulario log = new Login.Formulario();

            this.Close();

            log.Show();
        }

        private void ComprarPasajes_Click(object sender, EventArgs e)
        {

        }
    }
}
