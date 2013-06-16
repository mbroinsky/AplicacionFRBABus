using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoADatos;
using System.Collections;

namespace AccesoADatos.Orm
{
    class Viaje
    {
        private Int32 NumMicro { get; set; }
        private Int32 IdRecorrido { get; set; }
        private DateTime FechaSalida { get; set; }
        private DateTime FechaLlegada { get; set; }
        private DateTime FechaEstimadaLlegada { get; set; }

        public Viaje(int numMicro, int idRecorrido, DateTime fecSalida)
        {
            NumMicro = numMicro;
            IdRecorrido = idRecorrido;
            FechaSalida = fecSalida;
        }

        public bool Insertar()
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@NumMicro", NumMicro);
                parametros.Add("@IdRecorrido", IdRecorrido);
                parametros.Add("@FechaSalida", FechaSalida.ToString("yyyy-MM-dd HH:mm:ss"));
                
                Conector.Datos.EjecutarComando("insert into NOT_NULL.Viaje " +
                       " (VIA_numMicro, VIA_codRecorrido, VIA_fecSalida, VIA_fecLlegadaEstimada) " +
                       " Select @NumMicro, @IdRecorrido, @FechaSalida, " +
                       " dateadd(minute, datepart(minute, REC_tiempoViaje), dateadd(hour, datepart(hour, REC_tiempoViaje), @fechaSalida)) " +
                       " from NOT_NULL.Recorrido where REC_id = @idRecorrido;", parametros);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void RegistrarLlegada(DateTime fecLlegada, int idMicro, int idOrigen, int idDestino)
        {
            Conector.Datos.EjecutarProcedure("NOT_NULL.RegistrarLlegadas", fecLlegada,
                        idMicro, idOrigen, idDestino);

            return;
        }
    }


}
