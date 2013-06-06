using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AccesoADatos;

namespace FrbaBus.AccesoADatos.Orm
{
    class Servicio
    {
        public static DataTable ListarComboServicio()
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarComandoADataTable("select SRV_idTipoServicio as id, " +
                    " SRV_nombreServicio as Servicio" +
                    " FROM NOT_NULL.TipoServicio"
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
