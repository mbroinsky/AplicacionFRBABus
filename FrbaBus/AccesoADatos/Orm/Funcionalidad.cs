using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AccesoADatos;

namespace FrbaBus.AccesoADatos.Orm
{
    class Funcionalidad
    {
        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public String FormularioAsoc { get; set; }

        public Funcionalidad(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public static DataTable Listar()
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarComandoADataTable("select FNC_idFuncionalidad as Id, FNC_nombre as Funcionalidad from NOT_NULL.Funcionalidad order by FNC_nombre;");

                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable ListarPermitidasPorRol(int idRol)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarComandoADataTable("select FNC_idFuncionalidad as Id, " +
                    " FNC_nombre as Funcionalidad from NOT_NULL.Funcionalidad " +
                    " where FNC_idFuncionalidad in (select FXR_idFuncionalidad from NOT_NULL.FuncionalidadXRol " +
                    " where FXR_idRol = '" + Convert.ToString(idRol) + "') order by FNC_nombre;");

                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable ListarDenegadasPorRol(int idRol)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarComandoADataTable("select FNC_idFuncionalidad as Id, " +
                    " FNC_nombre as Funcionalidad from NOT_NULL.Funcionalidad " +
                    " where FNC_idFuncionalidad not in (select FXR_idFuncionalidad from NOT_NULL.FuncionalidadXRol " +
                    " where FXR_idRol = '" + Convert.ToString(idRol) + "') order by FNC_nombre;");

                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static void BorrarFuncXRol(int idRol)
        {
            try
            {
                Conector.Datos.EjecutarComando("delete from NOT_NULL.funcionalidadxrol " +
                    "where FXR_idRol = '" + Convert.ToString(idRol) + "';");
            }
            catch
            {
                throw new Exception("No se pueden borrar la tabla de permisos");
            }
        }

        public void InsertarFuncXRol(int idRol)
        {
            try
            {
                Conector.Datos.EjecutarComando("insert into NOT_NULL.funcionalidadxrol values ('" +
                    Convert.ToString(idRol) + "', '" + Convert.ToString(Id) + "');");
            }
            catch
            {
                throw new Exception("No se puede insertar en la tabla de permisos");
            }
        }
    }
}


