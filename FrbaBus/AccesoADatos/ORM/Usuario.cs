using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace AccesoADatos.Orm
{
    public class Usuario
    {
        public Int16 Id { get; set; }
        public String NombreUsr { get; set; }
        public String Password { get; set; }
        public String Rol { get; set; }
        public Int16 CantIntentos { get; set; }
        public ArrayList Permisos { get; set; }
        private Int16 IdRol;
        
        public Usuario()
        {
            Permisos = new ArrayList();
        }

        public void AgregarPermiso(String formulario)
        {
            Permisos.Add(formulario);
        }

        public bool TienePermiso(String formulario)
        {
            return Permisos.Contains(formulario);
        }

        public bool TraerUsuario(String nick)
        {
            DataTable dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.usuario, " +
                       " NOT_NULL.rol where USR_nick = '" + nick + "' AND USR_idRol = ROL_idRol;");

            if (dt.Rows.Count > 0)
            {
                Id = Convert.ToInt16(dt.Rows[0]["USR_idUsuario"]);
                NombreUsr = dt.Rows[0]["USR_Nombre"] + " " + dt.Rows[0]["USR_Apellido"];
                Password = dt.Rows[0]["USR_Password"].ToString();
                Rol = dt.Rows[0]["ROL_nombre"].ToString();
                IdRol = Convert.ToInt16(dt.Rows[0]["ROL_idRol"]);
                CantIntentos = Convert.ToInt16(dt.Rows[0]["USR_intentos"]);
                
                dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.funcionalidadXRol, " + 
                       " NOT_NULL.funcionalidad where FXR_idRol = '" + IdRol.ToString() + 
                       "' AND FXR_idFuncionalidad = FNC_idFuncionalidad;");
                       
                for(int i = 0; i < dt.Rows.Count; i++)
                    Permisos.Add(dt.Rows[i]["FNC_formAsoc"]);
                            
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool IncrementarIntentos(int usrId)
        {
            try
            {
                string sql = "update NOT_NULL.usuario " +
                       " set USR_intentos = USR_intentos + 1 where USR_idUsuario = '" +
                       Convert.ToString(usrId) + "';";

                Conector.Datos.EjecutarComando(sql);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
