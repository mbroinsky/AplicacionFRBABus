using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.Registrar_LLegada_Micro
{
    public partial class RegistrarLlegada : Form
    {
        public RegistrarLlegada()
        {
            InitializeComponent();

            fechaLlegada.Value = DateTime.Now;

            Ciudad.LlenarCombo(ciudadOrigen);
            Ciudad.LlenarCombo(ciudadDestino);
        }


    }
}
