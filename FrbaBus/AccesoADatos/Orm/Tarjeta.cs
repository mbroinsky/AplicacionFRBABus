using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using FrbaBus.AccesoADatos;
using System.Windows.Forms;

namespace FrbaBus.AccesoADatos.Orm
{
    class Tarjeta
    {
        public static bool Insertar(String numero, String fecVenc, Int32 tipo, Int16 codSeg)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@numero", numero);
                parametros.Add("@fecVenc", fecVenc);
                parametros.Add("@tipo", tipo);
                parametros.Add("@codSeg", codSeg);

                Conector.Datos.EjecutarSql("insert into NOT_NULL.tarjeta VALUES (@idVenta, @codigo, " +
                    "@idViaje, @idCliente, @cantKilos, @precio, '0');", parametros);

                return true;
            }
            catch
            {
                return false;
            }
        }

    }

}