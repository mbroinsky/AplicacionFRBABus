using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace AccesoADatos.Orm
{
    public class Butaca
    {
        public Int16 Numero { get; set; }
        public Int16 MicroId { get; set; }
        public Int16 Piso { get; set; }
        public String Tipo { get; set; }
        
        public bool TraerButacaPorClave(int numero, int microId)
        {
            DataTable dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.butaca " +
                       " where BUT_numeroAsiento = '" + Convert.ToString(numero) + "' AND But_numMicro = '" + 
                        Convert.ToString(microId) + "';");

            if (dt.Rows.Count > 0)
            {
                Numero = Convert.ToInt16(dt.Rows[0]["BUT_numeroAsiento"]);
                MicroId = Convert.ToInt16(dt.Rows[0]["BUT_numMicro"]);
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
            try
            {
                Conector.Datos.EjecutarComando("insert into NOT_NULL.butaca " +
                       " (BUT_numeroAsiento, BUT_microId, BUT_piso, BUT_tipo) values ('" +
                       Convert.ToString(numero) + "', '" + Convert.ToString(microId) +
                       "', '" + Convert.ToString(piso) + "', '" + tipo + "');");

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
