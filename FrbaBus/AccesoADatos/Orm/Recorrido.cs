using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AccesoADatos;
using System.Windows.Forms;

namespace AccesoADatos.Orm
{
    class Recorrido
    {
        public static void ListarCombo(ComboBox recorridos)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarComandoADataTable("select REC_id as id, " +
                    " (a.CIU_nombre + '-' + b.CIU_nombre + ' (' + SRV_nombreServicio + ')') as detalleRec " +
                    " from NOT_NULL.Recorrido, NOT_NULL.Ciudad a, NOT_NULL.Ciudad b, NOT_NULL.TipoServicio " +
                    " where REC_idCiudadOrigen = a.CIU_idCiudad AND REC_idCiudadDestino = b.CIU_idCiudad AND " +
                    " REC_idTipoServicio = SRV_idTipoServicio order by detalleRec;");

                recorridos.DataSource = dt;
                recorridos.ValueMember = "id";
                recorridos.DisplayMember = "detalleRec";

                return;
            }
            catch
            {
                MessageBox.Show("No se puede cargar el combo");

                return;
            }
        }

        public static DataTable Listar(string codigo, int?idRecorrido, int? idTipServ, int? idOrigen,
                                       int? idDestino)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.ListarRecorridos",
                                        idRecorrido, codigo, idTipServ, idOrigen, idDestino);

                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
