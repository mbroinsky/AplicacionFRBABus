using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.AccesoADatos;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace FrbaBus.AccesoADatos.Orm
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

        public static DataTable TraerDisponibles(DateTime fecViaje, int idOrigen, int idDestino)
        {
            try
            {
                string sql = "select VIA_numviaje as ID, convert(TIME, VIA_FecSalida, 108) as Horario, " +
                    "convert(time, VIA_fecllegadaEstimada, 108) as Llegada, SRV_nombreServicio as Servicio, " +
                    "convert(decimal(10,2), REC_precioBase + (REC_precioBase * SRV_porcentajeAdic) / 100) as 'Precio de pasaje', " +
                    "REC_precioKilo as 'Precio Encomienda(x Kg)', " +
                    "NOT_NULL.ButacasVacias(VIA_numViaje) as 'Butacas libres', " +
                    "NOT_NULL.KilogramosDisponibles(VIA_numViaje) as 'Kg. libres' " +
                    "FROM NOT_NULL.Viaje, NOT_NULL.Recorrido, NOT_NULL.TipoServicio " +
                    "WHERE VIA_codRecorrido = REC_id AND REC_idTipoServicio = SRV_idTipoServicio AND " +
                    "convert(varchar, VIA_fecSalida, 103) = convert(varchar, @fecViaje, 103) AND ";

                Hashtable parametros = new Hashtable();

                if (fecViaje.ToString("dd/MM/yyyy").CompareTo(Configuracion.Instance().FechaSistema.ToString("dd/MM/yyyy")) == 0)
                {
                    sql += "VIA_fecSalida >= dateadd(hour, 1, @fecViaje) AND ";

                    parametros.Add("@fecViaje", Configuracion.Instance().FechaSistema);
                }
                else
                    parametros.Add("@fecViaje", fecViaje);
                
                sql += "@idOrigen = REC_idCiudadOrigen AND @idDestino = REC_idCiudadDestino AND VIA_habilitado = '1'" +
                    "order by 2;";

                parametros.Add("@idOrigen", idOrigen);
                parametros.Add("@idDestino", idDestino);
 
                DataTable dt = Conector.Datos.EjecutarComandoADataTable(sql, parametros);

                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error, no se pueden cargar viajes disponibles:" + e.Message.ToString());

                return null;
            }
        }
    }


}
