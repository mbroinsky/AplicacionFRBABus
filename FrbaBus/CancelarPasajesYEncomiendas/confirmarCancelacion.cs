using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;
using FrbaBus.Utilidades;

namespace FrbaBus.CancelarPasajesYEncomiendas
{
    public partial class confirmarCancelacion : Form
    {
        public String tipo;
        public int id;

        public confirmarCancelacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (motivo.Text.Length != 0)
            {
                if (MessageBox.Show("¿Está seguro que quiere cancelar el pasaje/encomienda?", "Cancelar pasaje/encomienda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (tipo == "Pasaje")
                    {
                        Pasaje.CancelarPasaje(id, motivo.Text);
                    }
                    else
                    {
                        Encomienda.CancelarEncomienda(id, motivo.Text);
                    }

                    this.SetVisibleCore(false);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un motivo");
            }
        }
    }
}
