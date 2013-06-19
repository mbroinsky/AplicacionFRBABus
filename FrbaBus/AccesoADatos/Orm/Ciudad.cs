using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrbaBus.AccesoADatos;
using System.Windows.Forms;

namespace FrbaBus.AccesoADatos.Orm
{
    class Ciudad
    {
        public Int32 Id { get; set; }
        public String Nombre { get; set; }

        public static void LlenarCombo(ComboBox ciudades)
        {
            try
            {
                ciudades.DataSource = Conector.Datos.EjecutarComandoADataTable("select CIU_idCiudad as id, " +
                    " CIU_nombre as nombre from NOT_NULL.Ciudad order by CIU_nombre;"); ;

                ciudades.DisplayMember = "nombre";
                ciudades.ValueMember = "id";

                return;
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al buscar las ciudades");
                return;
            }
        }
    }
}
