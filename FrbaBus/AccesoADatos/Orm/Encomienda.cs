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
    class Encomienda
    {
         public static Int64 TraerNumerador()
         {
             try
             {
             	Int64 numero = 0;
             
                numero = Convert.ToInt64(Conector.Datos.TraerValorOutput("NOT_NULL.TraerNumerador", "Encomienda", numero));
 
                return numero;
 
             }
             catch
             {
                 return -1;
             }
        }
    }
}