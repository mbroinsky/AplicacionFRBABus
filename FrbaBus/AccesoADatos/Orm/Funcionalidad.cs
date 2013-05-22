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
    }
}
