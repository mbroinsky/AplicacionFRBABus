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

namespace FrbaBus.Abm_Micro
{
    public partial class ABMMicro : Form
    {
        public Micro micro { get; set; }
        public bool esModificacion { get; set; }

        public ABMMicro()
        {
            InitializeComponent();

            micro = new Micro();

            esModificacion = false;

            cargarDropDowns();

            //if (esModificacion) { cargarValoresMicro(); };
        }

        public ABMMicro(Micro microAModificar)
        {
            micro = new Micro();
            micro = microAModificar;

            esModificacion = true;

            InitializeComponent();
            cargarDropDowns();
            agregarButacas.Visible = false;
            cargarValoresMicro();
        }

        private void cargarDropDowns()
        {
            servicio.DataSource = Servicio.ListarComboServicio();
            servicio.ValueMember = ((DataTable)servicio.DataSource).Columns[0].ColumnName;
            servicio.DisplayMember = ((DataTable)servicio.DataSource).Columns[1].ColumnName;

            marca.DataSource = Marca.ListarComboMarca();
            marca.ValueMember = ((DataTable)marca.DataSource).Columns[0].ColumnName;
            marca.DisplayMember = ((DataTable)marca.DataSource).Columns[1].ColumnName;

            cargarComboBoxModelo(Convert.ToInt32(marca.SelectedValue));
        }

        private void cargarValoresMicro()
        {
            this.patente.Text = micro.Patente;
            this.servicio.SelectedValue = micro.IdTipoDeServicio;
            this.modelo.SelectedValue = micro.IdModelo;
            this.marca.SelectedValue = micro.IdMarca;
            this.capacidad.Text = Convert.ToString(micro.KilosEncomiendas);
            this.hibilitado.Checked = micro.Habilitado;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (Validador.esPantenteValida(patente.Text))
            {
                if (Validador.esNumeroReal(capacidad.Text))
                {
                    if (micro.Butacas.Rows.Count > 1)
                    {
                        micro.Patente = patente.Text;
                        micro.IdTipoDeServicio = Convert.ToInt16(servicio.SelectedValue);
                        micro.KilosEncomiendas = Convert.ToDecimal(capacidad.Text);
                        micro.Habilitado = hibilitado.Checked;
                        micro.IdMarca = Convert.ToInt16(marca.SelectedValue);
                        micro.IdModelo = Convert.ToInt16(modelo.SelectedValue);

                        if (esModificacion)
                        {
                            if (micro.Modificar(micro.Id)) { this.Close(); }
                            else { MessageBox.Show("Se produjo un error al insertar el Micro"); }
                        }
                        else
                        {
                            if (micro.Insertar()) 
                            { 
                                this.Close(); 
                            }
                            else { MessageBox.Show("Se produjo un error al insertar el Micro"); }
                        }

                    }
                    else
                    {
                        MessageBox.Show("El micro que desea insertar no contiene butacas");
                    }
                }
                else
                {
                    MessageBox.Show("La capacidad debe ser un valor numerico entero");
                }
            }
            else
            {
                MessageBox.Show("El formato de la patente debe ser AAA-999");
            }
        }

        private void agregarButacas_Click(object sender, EventArgs e)
        {
            ABMButacas log;
            //if (esModificacion) { log = new Abm_Micro.ABMButacas(micro.Butacas); }
            //else { log = new Abm_Micro.ABMButacas(); };

            log = new Abm_Micro.ABMButacas(micro.Butacas);
            
            this.SetVisibleCore(false);
            log.ShowDialog();
            this.micro.Butacas = (DataTable)log.Butacas.DataSource;
            log.Close();
            this.SetVisibleCore(true);
        }

        private void cargarComboBoxModelo(int idMarca)
        {
            modelo.DataSource = Modelo.ListarComboModelo(idMarca);
            modelo.ValueMember = ((DataTable)modelo.DataSource).Columns[0].ColumnName;
            modelo.DisplayMember = ((DataTable)modelo.DataSource).Columns[1].ColumnName;
        }

        private void marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboBoxModelo(Convert.ToInt32(marca.SelectedIndex));
        }

    }
}
