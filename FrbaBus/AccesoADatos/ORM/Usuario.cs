using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace FrbaBus.AccesoADatos.Orm
{
    public class Usuario
    {
        public Int16 Id { get; set; }
        public String NombreUsr { get; set; }
        public String Password { get; set; }
        public Rol UsuarioRol { get; set; }
        public Int16 CantIntentos { get; set; }
        
        public Usuario()
        {
        }

        public bool TienePermiso(string formulario)
        {
            return UsuarioRol.TienePermiso(formulario);
        }

        public bool TraerUsuario(string nick)
        {
            DataTable dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.usuario, " +
                       " NOT_NULL.rol where USR_nick = '" + nick + "' AND USR_idRol = ROL_idRol AND " +
                       " ROL_habilitado = '1';");

            if (dt.Rows.Count > 0)
            {
                Id = Convert.ToInt16(dt.Rows[0]["USR_idUsuario"]);
                NombreUsr = dt.Rows[0]["USR_Nombre"] + " " + dt.Rows[0]["USR_Apellido"];
                Password = dt.Rows[0]["USR_Password"].ToString();
                CantIntentos = Convert.ToInt16(dt.Rows[0]["USR_intentos"]);

                UsuarioRol = new Rol(Convert.ToInt16(dt.Rows[0]["ROL_idRol"]), 
                    Convert.ToBoolean(dt.Rows[0]["ROL_habilitado"]), dt.Rows[0]["ROL_nombre"].ToString());
                          
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        ///  Cambia la cantidad de intentos fallidos en la tabla Usuario.
        /// </summary>
        /// <param name="usrId">Id del usuario a modificar</param>
        /// <param name="cant">Cantidad de intentos fallidos</param>
        public bool CambiarCantIntentos(int usrId, int cant)
        {
            try
            {
                string sql = "update NOT_NULL.usuario " +
                       " set USR_intentos = '" + Convert.ToString(cant) + "' where USR_idUsuario = '" +
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
