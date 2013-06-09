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

        public Viaje(int numMicro, int idRecorrido, DateTime fecSalida, DateTime fecLlegadaEst)
        {
            NumMicro = numMicro;
            IdRecorrido = idRecorrido;
            FechaSalida = fecSalida;
            FechaEstimadaLlegada = fecLlegadaEst;
        }

        public bool Insertar()
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@NumMicro", NumMicro);
                parametros.Add("@IdRecorrido", IdRecorrido);
                parametros.Add("@FechaSalida", FechaSalida.ToString("yyyy-MM-dd HH:mm:ss"));
                parametros.Add("@FechaEstimadaLlegada", FechaEstimadaLlegada.ToString("yyyy-MM-dd HH:mm:ss"));

                Conector.Datos.EjecutarComando("insert into NOT_NULL.Viaje " +
                       " (VIA_numMicro, VIA_codRecorrido, VIA_fecSalida, VIA_fecLlegadaEstimada) " +
                       " values (@NumMicro, @IdRecorrido, @FechaSalida, @FechaEstimadaLlegada);", parametros);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }


}
