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

namespace FrbaBus.Abm_Micro
{
    public partial class AM_Micro : Form
    {
        public Micro micro{get; set;}
        public bool esModificacion{get; set;}

        public AM_Micro()
        {
            InitializeComponent();

            micro = new Micro();

            esModificacion = false;

            cargarDropDowns();

            if (esModificacion) { cargarValoresMicro(); };
                       
        }

        public AM_Micro(Micro microAModificar)

        {
            micro = new Micro();
            micro = microAModificar;

            esModificacion = true;

            InitializeComponent();
            cargarDropDowns();

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
            this.patente.Text           = micro.Patente;
            this.servicio.SelectedValue = micro.IdTipoDeServicio;
            this.modelo.SelectedValue   = micro.IdModelo;
            this.marca.SelectedValue    = micro.IdMarca;
            this.capacidad.Text         = Convert.ToString(micro.KilosEncomiendas);
            this.hibilitado.Checked     = micro.Habilitado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Matrícula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         if (Validador.esPantenteValida(patente.Text))
         {
              if (Validador.esNumericoEnteroPositivo(capacidad.Text))
              {
                  if(micro.Butacas.Rows.Count > 1)
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
                          if (micro.Insertar()) { this.Close(); }
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
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {
            ABM_Butacas log;
            if (esModificacion) { log = new Abm_Micro.ABM_Butacas(micro.Butacas); }
            else { log = new Abm_Micro.ABM_Butacas(); };
            this.SetVisibleCore(false);
            log.ShowDialog();
            this.micro.Butacas = (DataTable)log.Butacas.DataSource;
            log.Close();
            this.SetVisibleCore(true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
