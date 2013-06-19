using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrbaBus.AccesoADatos;

namespace FrbaBus.AccesoADatos.Orm
{
    class Modelo
    {

        public static DataTable ListarComboModelo(int idMarca)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarComandoADataTable("select MOD_idModelo as id, " +
                    " MOD_nombreModelo as Modelo" +
                    " FROM NOT_NULL.Modelo "+
                    " WHERE MOD_idMarca = " + idMarca
                );

                return dt;
            }
            catch
            {
                return null;
            }

        }
    }
}
