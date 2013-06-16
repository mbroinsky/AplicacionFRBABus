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

            tiempoViaje.Text = "00:00";
        }
        
        public ABMRecorrido(int idRec)
        {
            InitializeComponent();

            _Modificacion = true;

            _Recorrido = new Recorrido(idRec);

            CargarCombos();

            codigo.Text = _Recorrido.Codigo;
            ciudadOrigen.SelectedValue = _Recorrido.IdCiuOri;
            ciudadDestino.SelectedValue = _Recorrido.IdCiuDest;
            tipoServicio.SelectedValue = _Recorrido.IdTipoServ;
            precioBase.Text = Convert.ToString(_Recorrido.PrecBase);
            precioKilo.Text = Convert.ToString(_Recorrido.PrecKilo);
            tiempoViaje.Text = _Recorrido.TiempoViaje.ToString("HH:mm");
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

            if (!Validador.esHoraValida(tiempoViaje.Text))
            {
                MessageBox.Show("El tiempo de viaje no es válido, debe ser de 00:00 a 23:59");
                return;
            }

            if (_Modificacion)
            {
                if (_Recorrido.IdCiuDest != Convert.ToInt32(ciudadDestino.SelectedValue) ||
                   _Recorrido.IdTipoServ != Convert.ToInt32(tipoServicio.SelectedValue) ||
                   _Recorrido.IdCiuOri != Convert.ToInt32(ciudadOrigen.SelectedValue) ||
                   _Recorrido.Codigo != codigo.Text ||
                   _Recorrido.PrecBase != Convert.ToDouble(precioBase.Text) ||
                   _Recorrido.PrecKilo != Convert.ToDouble(precioKilo.Text) ||
                   _Recorrido.TiempoViaje != DateTime.Parse(tiempoViaje.Text))
                {
                    _Recorrido.Codigo = codigo.Text;
                    _Recorrido.IdTipoServ = Convert.ToInt32(tipoServicio.SelectedValue);
                    _Recorrido.IdCiuOri = Convert.ToInt32(ciudadOrigen.SelectedValue); 
                    _Recorrido.IdCiuDest = Convert.ToInt32(ciudadDestino.SelectedValue); 
                    _Recorrido.PrecBase = Convert.ToDouble(precioBase.Text);
                    _Recorrido.PrecKilo = Convert.ToDouble(precioKilo.Text);
                    _Recorrido.TiempoViaje = Convert.ToDateTime(tiempoViaje.Text);
                    
                    if (!_Recorrido.Modificar())
                    {
                        MessageBox.Show("Ocurrió un error de actualización");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No se produjeron modificaciones");
                    return;
                }
            }
            else
            {
                _Recorrido = new Recorrido(-1, codigo.Text, Convert.ToInt32(tipoServicio.SelectedValue),
                                   Convert.ToInt32(ciudadOrigen.SelectedValue), 
                                   Convert.ToInt32(ciudadDestino.SelectedValue), 
                                   Convert.ToDouble(precioBase.Text),
                                   Convert.ToDouble(precioKilo.Text), true, 
                                   Convert.ToDateTime(tiempoViaje.Text));

                if (!_Recorrido.Insertar())
                {
                    MessageBox.Show("Ocurrió un error al agregar el nuevo recorrido");
                    return;
                }
 
            }
            
            this.Close();
        }
    }
}

