using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccesoADatos.Orm;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus.Abm_Micro
{
    public partial class AM_Micro : Form
    {
        public Micro micro{get; set;}

        public AM_Micro()
        {
            InitializeComponent();

            servicio.DataSource = Servicio.ListarComboServicio();
            servicio.ValueMember = ((DataTable)servicio.DataSource).Columns[0].ColumnName;
            servicio.DisplayMember = ((DataTable)servicio.DataSource).Columns[1].ColumnName;

            marca.DataSource = Marca.ListarComboMarca();
            marca.ValueMember = ((DataTable)marca.DataSource).Columns[0].ColumnName;
            marca.DisplayMember = ((DataTable)marca.DataSource).Columns[1].ColumnName;

            micro = new Micro(); 

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
                      micro.KilosEncomiendas = Convert.ToInt16(capacidad.Text);
                      micro.Habilitado = hibilitado.Checked;
                      micro.IdMarca = Convert.ToInt16(marca.SelectedValue);

                      if (micro.Insertar()) { this.Close(); }
                      else { MessageBox.Show("Se produjo un error al insertar el Micro"); }
                     
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
            var log = new Abm_Micro.ABM_Butacas();

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
    }
}
