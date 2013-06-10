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

            CargarCombos();

            ciudadOrigen.SelectedIndex = -1;
            ciudadDestino.SelectedIndex = -1;
            tipoServicio.SelectedIndex = -1;
        }


        public ABMRecorrido(int idRec)
        {
            InitializeComponent();

            _Modificacion = true;

            _Recorrido = new Recorrido(idRec);

            CargarCombos();

            codigo.Text = _Recorrido.Codigo;
            habilitado.Checked = _Recorrido.Habilitado;
            ciudadOrigen.SelectedValue = _Recorrido.IdCiuOri;
            ciudadDestino.SelectedValue = _Recorrido.IdCiuDest;
            tipoServicio.SelectedValue = _Recorrido.IdTipoServ;
            precioBase.Text = Convert.ToString(_Recorrido.PrecBase);
            precioKilo.Text = Convert.ToString(_Recorrido.PrecKilo);
        }

        private void CargarCombos()
        {
            tipoServicio.DataSource = Servicio.ListarComboServicio();
            tipoServicio.ValueMember = ((DataTable)tipoServicio.DataSource).Columns[0].ColumnName;
            tipoServicio.DisplayMember = ((DataTable)tipoServicio.DataSource).Columns[1].ColumnName;

            Ciudad.LlenarCombo(ciudadOrigen);
            Ciudad.LlenarCombo(ciudadDestino);
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

            if (!Validador.esNumeroReal(precioKilo.Text))
            {
                MessageBox.Show("El precio por kg. debe ser un valor monetario");
                return;
            }

            if (!Validador.esNumeroReal(precioBase.Text))
            {
                MessageBox.Show("El precio de base debe ser un valor monetario");
                return;
            }

            if (_Modificacion)
            {
                if (!_Recorrido.Habilitado && !habilitado.Checked)
                {
                    MessageBox.Show("No se pueden realizar cambios en un recorrido que no esta habilitado, " +
                        "para modificarlo habilítelo primero");
                    return;
                }
                
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

