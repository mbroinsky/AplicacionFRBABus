using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccesoADatos.Orm;
using Utilidades;

namespace Abm_Recorrido
{
    public partial class ABMRecorrido : Form
    {
        private Boolean _Modificacion;
        private Recorrido _Recorrido;

        public ABMRecorrido()
        {
            InitializeComponent();

            _Modificacion = false;
        }


        public ABMRecorrido(int idRec)
        {
            InitializeComponent();

            _Modificacion = true;

            _Recorrido = new Recorrido(idRec);

            codigo.Text = _Recorrido.Codigo;
            habilitado.Checked = _Recorrido.Habilitado;
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            if (codigo.Text == "")
            {
                MessageBox.Show("El codigo no puede quedar vacío");
                return;
            }

            if (!Validador.esNumericoEnteroPositivo(codigo.Text))
            {
                MessageBox.Show("El codigo debe ser numérico");
                return;
            }

            if (_Modificacion)
            {
                //if (!_Rol.Habilitado && !habilitado.Checked)
                //{
                //    MessageBox.Show("No se pueden realizar cambios en un rol que no esta habilitado, " +
                //        "para modificarlo habilítelo primero");
                //    return;
                //}
                
                //if (!_Rol.Modificar(codigo.Text, habilitado.Checked, otorgados.Rows))
                //{
                //    MessageBox.Show("Ocurrió un error de actualización");
                //    return;
                //}
            }
            else
            {
                //_Rol = new Rol();

                //if (!_Rol.Insertar(codigo.Text, habilitado.Checked, otorgados.Rows))
                //{
                //    MessageBox.Show("Ocurrió un error de actualización");
                //    return;
                //}
 
            }
            
            this.Close();
        }
    }
}

