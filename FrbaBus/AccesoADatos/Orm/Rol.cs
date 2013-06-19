using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using FrbaBus.AccesoADatos.Orm;
using System.Collections;

namespace FrbaBus.AccesoADatos.Orm
{
    public class Rol
    {
        public Int32 Id { get; set; }
        public Boolean Habilitado { get; set; }
        public String Nombre { get; set; }
        private ArrayList Permisos;

        public Rol()
        {
            Permisos = new ArrayList();
        }

        public Rol(int id, bool habilitado, string nombre)
        {
            Id = id;
            Habilitado = habilitado;
            Nombre = nombre;
            Permisos = Funcionalidad.FuncionalidadesPermitidasPorRol(id);
        }

        public Rol(DataGridViewRow fila)
        {
            Id = Convert.ToInt32(fila.Cells["Id"].Value);
            Habilitado = Convert.ToBoolean(fila.Cells["Habilitado"].Value);
            Nombre = fila.Cells["Nombre"].Value.ToString();

            Permisos = new ArrayList();
        }

        public bool TienePermiso(string formAsoc)
        {
            foreach (Funcionalidad fun in Permisos)
            {
                if (fun.FormularioAsoc == formAsoc)
                    return true;
            }
            return false;
        }
   
        public bool TraerRolPorClave(int id)
        {
            DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.ListarRoles", id, DBNull.Value);

            if (dt.Rows.Count > 0)
            {
                Id = Convert.ToInt32(dt.Rows[0]["ROL_idRol"]);
                Nombre = dt.Rows[0]["ROL_nombre"].ToString();
                Habilitado = Convert.ToBoolean(dt.Rows[0]["ROL_habilitado"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable Listar()
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.ListarRoles");

                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable Listar(string nombreRol)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.ListarRoles", DBNull.Value, nombreRol);

                return dt;
            }
            catch
            {
                return null;
            }
        }

        public bool Insertar(string nombre, bool habilitado, DataGridViewRowCollection permisos)
        {
            this.Nombre = nombre;
            this.Habilitado = Convert.ToBoolean(habilitado);

            foreach (DataGridViewRow fila in permisos)
            {
                var permiso = new Funcionalidad(Convert.ToInt32(fila.Cells["Id"].Value), Convert.ToString(fila.Cells["funcionalidad"].Value), "");

                this.Permisos.Add(permiso);
            }

            return this.Insertar();
        }

        public bool Insertar()
        {
            try
            {
                int aux;

                Conector.Datos.IniciarTransaccion();

                Conector.Datos.EjecutarComando("insert into NOT_NULL.Rol " +
                       " (ROL_nombre, ROL_habilitado) values ('" + this.Nombre + 
                       "','" + (this.Habilitado ? "1": "0") + "');");

                //Traigo el id del rol que inserte recien
                aux = Conector.Datos.TraerUltimoId();

                Funcionalidad.BorrarFuncXRol(this.Id);

                foreach (Funcionalidad permiso in this.Permisos)
                {
                    permiso.InsertarFuncXRol(aux);
                }

                Conector.Datos.TerminarTransaccion();

                return true;
            }
            catch
            {
                Conector.Datos.AbortarTransaccion();

                return false;
            }
        }


        public bool Modificar(string nombre, bool habilitado, DataGridViewRowCollection permisos)
        {
            this.Nombre = nombre;
            this.Habilitado = Convert.ToBoolean(habilitado);

            this.Permisos.Clear();

            foreach (DataGridViewRow fila in permisos)
            {
                var permiso = new Funcionalidad(Convert.ToInt32(fila.Cells["Id"].Value), Convert.ToString(fila.Cells["funcionalidad"].Value), "");

                this.Permisos.Add(permiso);
            }

            return this.Modificar();
        }

        public bool Modificar()
        {
            try
            {
                Conector.Datos.IniciarTransaccion();

                Conector.Datos.EjecutarComando("update NOT_NULL.Rol " +
                       " set ROL_nombre = '" + this.Nombre + "', ROL_habilitado = '" +
                       (this.Habilitado ? "1" : "0")  + "' where ROL_idRol = '" +
                           Convert.ToString(this.Id) + "';");

                Funcionalidad.BorrarFuncXRol(this.Id);

                foreach (Funcionalidad permiso in this.Permisos)
                {
                    permiso.InsertarFuncXRol(this.Id);
                }

                Conector.Datos.TerminarTransaccion();

                return true;
            }
            catch
            {
                Conector.Datos.AbortarTransaccion();

                return false;
            }
        }
    }
}
