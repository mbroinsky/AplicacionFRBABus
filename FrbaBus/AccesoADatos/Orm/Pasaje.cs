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
    public class Pasaje
    {
        public static Int64 TraerNumerador()
        {
            try
            {
            	Int64 numero = 0;

                numero = Convert.ToInt64(Conector.Datos.TraerValorOutput("NOT_NULL.TraerNumerador", "Pasaje", numero));

                return numero;

            }
            catch 
            {
                return -1;
            }
        }

        public static bool CancelarPasaje(int idPasaje, String motivo)
        {
            try
            {

                Conector.Datos.EjecutarProcedure("NOT_NULL.CancelarPasaje", idPasaje, motivo, Configuracion.Instance().FechaSistema);

                return true;
         
            }
            catch
            {
                return false;
            }       
        }

        public static bool Insertar(Int64 idVenta, Int32 idViaje, Int32 idCliente, Int32 nroButaca, Int32 nroMicro, Double precio)
        {
            try
            {
                Int64 codigo = TraerNumerador();

                Hashtable parametros = new Hashtable();

                parametros.Add("@idVenta", idVenta);
                parametros.Add("@codigo", codigo);
                parametros.Add("@idViaje", idViaje);
                parametros.Add("@idCliente", idCliente);
                parametros.Add("@nroButaca", nroButaca);
                parametros.Add("@nroMicro", nroMicro);
                parametros.Add("@precio", precio);

                Conector.Datos.EjecutarSql("insert into NOT_NULL.pasaje VALUES (@idVenta, @codigo, " +
                    "@idViaje, @idCliente, @nroButaca, @nroMicro,@precio, '0');", parametros);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Devolver(Int32 idDev, Int32 idPas)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@idDev", idDev);
                parametros.Add("@idPas", idPas);

                Conector.Datos.EjecutarSql("update not_null.pasaje set PAS_cancelado = '1' where PAS_numPasaje = @idPas", parametros);
               
                Conector.Datos.EjecutarSql("insert into NOT_NULL.devxpas VALUES (@idDev, @idPas);", parametros);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}