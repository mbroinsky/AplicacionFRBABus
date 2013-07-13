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
    public partial class AlternativaMicro : Form
    {
        public int idViaje;
        public int idRecorrido;
        public DateTime fechaInicio;
        public DateTime fechaFin;
        
        public AlternativaMicro()
        {
            InitializeComponent();

            Micro.LlenarComboDisponibles(idRecorrido, fechaInicio, microsDisp);
        }

    }
}
