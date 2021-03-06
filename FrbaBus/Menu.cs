﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Compra_de_Pasajes;

namespace FrbaBus
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ABMRol_Click(object sender, EventArgs e)
        {
            AbrirDialogo(new FrbaBus.Abm_Permisos.SeleccionRol());
        }
        
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AMicro_Click(object sender, EventArgs e)
        {
            AbrirDialogo(new FrbaBus.Abm_Micro.SeleccionMicro());
        }

        private void GenerarViaje_Click(object sender, EventArgs e)
        {
            AbrirDialogo(new FrbaBus.GenerarViaje.GenerarViaje());
        }

        private void AbrirDialogo(Form dialogo)
        {
            if (!Globales.oInstance.usr.TienePermiso(dialogo.Name))
            {
                MessageBox.Show("Ud. no tiene permiso para acceder a la pantalla solicitada");
                return;
            }

            dialogo.ShowDialog();
        }

        private void registrarLlegadas_Click(object sender, EventArgs e)
        {
            AbrirDialogo(new Registrar_LLegada_Micro.RegistrarLlegada());
        }

        private void abmRecorridos_Click(object sender, EventArgs e)
        {
            AbrirDialogo(new Abm_Recorrido.SeleccionRecorrido());
        }

        private void listadosEstadisticos_Click(object sender, EventArgs e)
        {
            AbrirDialogo(new ListadoEstadistico.SeleccionListado());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirDialogo(new Consulta_Puntos_Adquiridos.ConsultaDePuntos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirDialogo(new Canje_de_Ptos.CanjeDePuntos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirDialogo(new CancelarPasajesYEncomiendas.CancelarPasajesYEncomiendas());
        }

        private void vender_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);

            GenerarCompra.Generar(true);

            this.SetVisibleCore(true);
        }
    }
}
