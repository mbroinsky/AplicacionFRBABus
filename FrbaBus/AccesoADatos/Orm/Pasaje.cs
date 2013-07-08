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
    public class Pasaje
    {
        public static Int64 traerNumerador()
        {
            try
            {
            	Int64 numero = 0;
            
                numero = Convert.ToInt64(Conector.Datos.TraerValorOutput("NOT_NULL.TraerNumerador", "Pasaje", numero));

                return numero;

            }
            catch
            {
                return -1;
            }
        }
    }
}