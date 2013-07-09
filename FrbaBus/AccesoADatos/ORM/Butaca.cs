using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace FrbaBus.AccesoADatos.Orm
{
    public class Butaca
    {
        public Int16 Numero { get; set; }
        public Int32 MicroId { get; set; }
        public Int16 Piso { get; set; }
        public String Tipo { get; set; }

        public bool TraerButacaPorClave(int numero, int microId)
        {
            Hashtable parametros = new Hashtable();

            parametros.Add("@numero", numero);
            parametros.Add("@microId", microId);

            DataTable dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.butaca " +
                       " where BUT_numeroAsiento = @numero AND But_numMicro = @microId;", parametros);

            if (dt.Rows.Count > 0)
            {
                Numero = Convert.ToInt16(dt.Rows[0]["BUT_numeroAsiento"]);
                MicroId = Convert.ToInt32(dt.Rows[0]["BUT_numMicro"]);
                Piso = Convert.ToInt16(dt.Rows[0]["BUT_Piso"]);
                Tipo = dt.Rows[0]["BUT_Tipo"].ToString();

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertarButaca(int numero, int microId, int piso, string tipo)
        {
            this.MicroId = Convert.ToInt32(microId);
            this.Numero = Convert.ToInt16(numero);
            this.Piso = Convert.ToInt16(piso);
            this.Tipo = tipo;

            return InsertarButaca();
        }

        public bool InsertarButaca()
        {
            try
            {
                Conector.Datos.EjecutarComando("insert into NOT_NULL.butaca " +
                       " (BUT_numeroAsiento, BUT_microId, BUT_piso, BUT_tipo) values ('" +
                       Convert.ToString(this.Numero) + "', '" + Convert.ToString(this.MicroId) +
                       "', '" + Convert.ToString(this.Piso) + "', '" + this.Tipo + "');");

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool InsertarTablaDeButacas(DataTable dtButacas, int microId)
        {
            try
            {
                String sql = "insert into NOT_NULL.butaca (BUT_numeroAsiento, BUT_numMicro, BUT_piso, BUT_tipo)" +
                             "  values ";

                foreach (DataRow row in dtButacas.Rows)
                {
                    sql += "(";

                    sql += row[2] + ", " +  microId + ", " + row[1] + ", " + "'"+row[3]+"'";

                    sql += "),";
                }

                sql = sql.Remove(sql.Length - 1);

                Conector.Datos.EjecutarComando(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool actualizarTablaButacas(DataTable dtButacas, int microId)
        {
            try
            {
                String sql = "insert into NOT_NULL.butaca (BUT_numeroAsiento, BUT_microId, BUT_piso, BUT_tipo)" +
                             "  values ";

                foreach (DataRow row in dtButacas.Rows)
                {
                    sql += "(";

                    sql += row[0] + ", " + microId + ", " + row[1] + ", " + row[2] + ", " + row[3];


                    sql += ")";
                }
                Conector.Datos.EjecutarComando(" ");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable TraerButacasPorMicro(int microId)
        {
            Hashtable parametros = new Hashtable();

            parametros.Add("@microId", microId);

            String query = "SELECT BUT_numMicro as 'idMicro', BUT_piso as 'Piso', "+
                " BUT_numeroAsiento as 'Nro. Asiento', BUT_tipo as 'Tipo de Asiento' "+
                " FROM NOT_NULL.Butaca where BUT_numMicro = @microId";

            DataTable dt = Conector.Datos.EjecutarComandoADataTable(query, parametros);

            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public static DataTable TraerButacasLibres(int viajeId)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.TraerButacasVacias", viajeId);

                return dt;
            }
            catch
            {
                return null;
            }
        }

    } 
}
