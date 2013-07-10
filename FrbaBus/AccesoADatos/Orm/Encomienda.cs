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
    class Encomienda
    {
        public static Int64 TraerNumerador()
        {
            try
            {
                Int64 numero = 0;

                numero = Convert.ToInt64(Conector.Datos.TraerValorOutput("NOT_NULL.TraerNumerador", "Encomienda", numero));

                return numero;

            }
            catch
            {
                return -1;
            }
        }

        public static bool CancelarEncomienda(int idPasaje, String motivo)
        {
            try
            {

                Conector.Datos.EjecutarProcedure("NOT_NULL.CancelarEncomienda", idPasaje, motivo, Configuracion.Instance().FechaSistema);

                return true;
         
            }
            catch
            {
                return false;
            }
        }

        public static bool Insertar(Int64 idVenta, Int32 idViaje, Int32 idCliente, Double cantKilos, Double precio)
        {
            try
            {
                Int64 codigo = TraerNumerador();

                Hashtable parametros = new Hashtable();

                parametros.Add("@idVenta", idVenta);
                parametros.Add("@codigo", codigo);
                parametros.Add("@idViaje", idViaje);
                parametros.Add("@idCliente", idCliente);
                parametros.Add("@cantKilos", cantKilos);
                parametros.Add("@precio", precio);

                Conector.Datos.EjecutarSql("insert into NOT_NULL.encomienda VALUES (@idVenta, @codigo, " +
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