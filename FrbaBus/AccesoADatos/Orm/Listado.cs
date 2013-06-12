using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoADatos;
using System.Windows.Forms;
using System.Data;

namespace AccesoADatos.Orm
{
    public abstract class Listado
    {
        public static DataTable ListadoDestinosConMasPasajes(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.RankingDestinos", 
                    fechaInicio, fechaFin);

                return dt;
            }
            catch
            {
                MessageBox.Show("Falló al intentar mostrar el listado");
                return null;
            }
        }
    }
}
