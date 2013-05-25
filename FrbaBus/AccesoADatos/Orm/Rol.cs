﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace AccesoADatos.Orm
{
    public class Rol
    {
        public Int32 Id { get; set; }
        public Boolean Habilitado { get; set; }
        public String Nombre { get; set; }

        public Rol(DataGridViewRow fila)
        {
            Id = Convert.ToInt32(fila.Cells["Id"].Value);
            Habilitado = Convert.ToBoolean(fila.Cells["Habilitado"].Value);
            Nombre = fila.Cells["Nombre"].Value.ToString();            
        }
   
        public bool TraerRolPorClave(int id)
        {
            DataTable dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.ROL " +
                       " where ROL_idRol = '" + Convert.ToString(id) + "';");

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

        //public bool InsertarRol(int numero, int microId, int piso, string tipo)
        //{
        //    this. = Convert.ToInt16(numero);
        //    this.Piso = Convert.ToInt16(piso);
        //    this.Tipo = tipo;

        //    return InsertarButaca();
        //}

        //public bool InsertarButaca()
        //{
        //    try
        //    {
        //        Conector.Datos.EjecutarComando("insert into NOT_NULL.butaca " +
        //               " (BUT_numeroAsiento, BUT_microId, BUT_piso, BUT_tipo) values ('" +
        //               Convert.ToString(this.Numero) + "', '" + Convert.ToString(this.MicroId) +
        //               "', '" + Convert.ToString(this.Piso) + "', '" + this.Tipo + "');");

        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}