using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AccesoADatos;

namespace FrbaBus.AccesoADatos.Orm
{
    class Recorrido
    {
        public static DataTable ListarCombo()
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarComandoADataTable("select REC_id as id, " +
                    " (a.CIU_nombre + '-' + b.CIU_nombre + ' (' + SRV_nombreServicio + ')') as detalleRec " +
                    " from NOT_NULL.Recorrido, NOT_NULL.Ciudad a, NOT_NULL.Ciudad b, NOT_NULL.TipoServicio " +
                    " where REC_idCiudadOrigen = a.CIU_idCiudad AND REC_idCiudadDestino = b.CIU_idCiudad AND " +
                    " REC_idTipoServicio = SRV_idTipoServicio order by detalleRec;");

                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
