using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using FrbaBus.AccesoADatos;
using System.Windows.Forms;

namespace FrbaBus.AccesoADatos.Orm
{
    class Pasaje
    {
        public static Long traerNumerador()
        {
            try
            {
            	long numero;
            
                numero = Convert.ToLong(Conector.Datos.TraerValorOutput("NOT_NULL.TraerNumerador", "Pasaje", numero);

                return numero;

            }
            catch
            {
                return -1;
            }
        }
    }
}