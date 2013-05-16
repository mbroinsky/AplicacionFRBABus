using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace AccesoADatos.ORM
{
    public class Usuario
    {
        public Int16 Id { get; set; }
        public String NombreUsr { get; set; }
        public String Password { get; set; }
        public String Rol { get; set; }
        public ArrayList Permisos { get; set; }

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

        public bool getUsuario(String usuario)
        {
            DataTable dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.usuario where USR_nick = '" + usuario + "';");

            if (dt.Rows.Count > 0)
            {
                Id = Convert.ToInt16(dt.Rows[0]["USR_idUsuario"]);
                NombreUsr = dt.Rows[0]["USR_Nombre"] + " " + dt.Rows[0]["USR_Apellido"];
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
