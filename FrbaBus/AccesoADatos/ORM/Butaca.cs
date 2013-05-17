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
        public String Piso { get; set; }
        public String Tipo { get; set; }
        
        public bool TraerButacaPorClave(int numero, int microId)
        {
            DataTable dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.butaca " +
                       " where BUT_numero = '" + Convert.ToString(numero) + "' AND But_Microid = '" + 
                        Convert.ToString(microId) + "';");

            if (dt.Rows.Count > 0)
            {
                Numero = Convert.ToInt16(dt.Rows[0]["BUT_numero"]);
                MicroId = Convert.ToInt16(dt.Rows[0]["BUT_MicroId"]);
                Piso = dt.Rows[0]["USR_Clave"];
                Tipo = dt.Rows[0]["BUT_Tipo"];
                
                dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.funcXRol, " + 
                       " NOT_NULL.funcionalidad where FXR_idRol = '" + IdRol.ToString() + 
                       "' AND FXR_idFunc = FUN_id;");
                       
                for(int i = 0; i < dt.Rows.Count; i++)
                    Permisos.Add(dt.Rows[i]["FUN_nombre"]);
                            
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool IncrementarIntentos(int usrId)
        {
            Conector.Datos.EjecutarComando("update NOT_NULL.usuario, " +
                       " set USR_intentos = USR_intentos + 1 where USR_id = '" + Convert.ToString(usrId) + "';");
        }
    }
}
