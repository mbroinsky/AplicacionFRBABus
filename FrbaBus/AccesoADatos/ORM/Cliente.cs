using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using AccesoADatos;

namespace FrbaBus.AccesoADatos.Orm
{
    class Cliente
    {
        public static DataTable obtenerPuntosCliente(int dni)
        {
            /* try
             {
                 DataTable dt = new DataTable();
                 Hashtable parametros = new Hashtable();


                 parametros.Add("@Patente", this.Patente);

                 dt = Conector.Datos.EjecutarComandoADataTable("select PTS_idPunto as Puntos, 'Descripcion' from ", parametros);

             }
             catch
             {*/
                 return null;
             //}
        }
    }
}