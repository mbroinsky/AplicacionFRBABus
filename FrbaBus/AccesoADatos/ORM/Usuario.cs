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

        public bool getUsuario(String nick)
        {
            DataTable dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.usuario, " +
                       " NOT_NULL.rol where USR_nick = '" + nick + "' AND USR_idRol = ROL_id;");

            if (dt.Rows.Count > 0)
            {
                Id = Convert.ToInt16(dt.Rows[0]["USR_idUsuario"]);
                NombreUsr = dt.Rows[0]["USR_Nombre"] + " " + dt.Rows[0]["USR_Apellido"];
                Password = dt.Rows[0]["USR_Clave"];
                Rol = dt.Rows[0]["ROL_nombre"];
                IdRol = Convert.ToInt16(dt.Rows[0]["ROL_id"]);
                
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
