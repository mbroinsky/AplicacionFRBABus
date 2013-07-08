using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using FrbaBus.AccesoADatos;

namespace FrbaBus.AccesoADatos.Orm
{
    class Venta
    {
        public static Int64 TraerNumerador()
        {
            try
            {
            	Int64 numero = 0;
            
                numero = Convert.ToInt64(Conector.Datos.TraerValorOutput("NOT_NULL.TraerNumerador", "Venta", numero));

                return numero;

            }
            catch
            {
                return -1;
            }
        }
      

        public static DataTable traerPasajesYEncomiendas(int idVenta)
        {

            DataTable dt = new DataTable();

            dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.listarPasajesYEncomiendas", idVenta);

            return dt;

        }


    }
}