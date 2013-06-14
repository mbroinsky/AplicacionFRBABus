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

        internal static object ListadoClientesConMasPuntos(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.RankingClientesXPuntosAcumulados",
                    fechaInicio, fechaFin);

                return dt;
            }
            catch
            {
                MessageBox.Show("Falló al intentar mostrar el listado");
                return null;
            }
        }

        internal static object ListadoDestinosConMasCancelaciones(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.RankingDestinosXPasajesCancelados",
                    fechaInicio, fechaFin);

                return dt;
            }
            catch
            {
                MessageBox.Show("Falló al intentar mostrar el listado");
                return null;
            }
        }

        internal static object ListadoDestinosConMicrosMasVacios(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.RankingDestinosXMicrosVacios",
                    fechaInicio, fechaFin);

                return dt;
            }
            catch
            {
                MessageBox.Show("Falló al intentar mostrar el listado");
                return null;
            }
        }

        internal static object ListadoMicrosConMenosDisponibilidad(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.RankingMicrosFueraServ",
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
