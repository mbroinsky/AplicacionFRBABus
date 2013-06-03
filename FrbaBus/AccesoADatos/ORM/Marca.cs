using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AccesoADatos;

namespace FrbaBus.AccesoADatos.Orm
{
    class Marca
    {
        public static DataTable ListarComboMarca()
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarComandoADataTable("select MAR_idMarca as id, " +
                    " MAR_nombreMarca as Marca" +
                    " FROM NOT_NULL.Marca"
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
