using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using FrbaBus;
using System.Data.SqlClient;

namespace FrbaBus.AccesoADatos.Orm
{
    public class Micro
    {
        public Int16 Id { get; set; }
        public String Patente { get; set; }
        public Int16 IdTipoDeServicio { get; set; }
        public Decimal KilosEncomiendas { get; set; }
        public bool Habilitado { get; set; }
        public Int16 IdMarca { get; set; }
        public Int16 IdModelo { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool FueraDeServicio { get; set; }
        public DateTime FechaFueraDeServicio { get; set; }
        public DateTime FechaReinicioServicio { get; set; }
        public DateTime FechaDeBaja { get; set; }

        public DataTable Butacas { get; set; }


        public Micro()
        {
            Butacas = new DataTable();
            Butacas.Columns.Add("idMicro");
            Butacas.Columns.Add("Piso");
            Butacas.Columns.Add("Nro. Asiento");
            Butacas.Columns.Add("Tipo de Asiento");
        }

        /// <summary>
        ///  Recupera un micro determinado dado su id
        /// </summary>
        /// <param name="idMicro">Id del Micro Buscado</param>
        public static Micro BuscarMicroPorId(int idMicro)
        {
            Micro micro = new Micro();

            String query = "select MIC_numMicro as 'ID', " +
                            "MIC_patente as 'Matricula', " +
                            "MIC_idTipoServicio as 'Tipo de Serv.', " +
                            "MIC_kilosEncomiendas as 'Capacidad', " +
                            "MIC_habilitado as 'Habilitado', " +
                            "MIC_idMarca as 'Marca', " +
                            "MIC_idModelo as 'Modelo', " +
                            "MIC_fechaAlta as 'Fec. Alta', " +
                            "MIC_fecBaja as 'Fec. Baja definitiva' " +
                            "from NOT_NULL.Micro where " +
                            "MIC_numMicro = " + Convert.ToString(idMicro);

            DataTable dt = Conector.Datos.EjecutarComandoADataTable(query);
            var row = dt.Rows[0];

            micro.Id = Convert.ToInt16(row["ID"].ToString());
            micro.Patente = (row["Matricula"].ToString());
            micro.IdTipoDeServicio = Convert.ToInt16(row["Tipo de Serv."].ToString());
            micro.KilosEncomiendas = Convert.ToDecimal(row["Capacidad"].ToString());
            micro.Habilitado = Convert.ToBoolean(row["Habilitado"].ToString());
            micro.IdMarca = Convert.ToInt16(row["Marca"].ToString());
            micro.IdModelo = Convert.ToInt16(row["Modelo"].ToString());
            micro.FechaAlta = Convert.ToDateTime(row["Fec. Alta"].ToString());

            micro.Butacas = Orm.Butaca.TraerButacasPorMicro(micro.Id);

            return micro;
        }

        public static DataTable BuscarMicro(String patenteABuscar, String idtipoDeServicio, String idMarca, String idModelo, String capacidad)
        {

            if (patenteABuscar.Length == 0) { patenteABuscar = null; };
            if (idtipoDeServicio.Length == 0) { idtipoDeServicio = null; };
            if (idMarca.Length == 0) { idMarca = null; };
            if (idModelo.Length == 0) { idModelo = null; };
            if (capacidad.Length == 0) { capacidad = null; };


            DataSet ds = Conector.Datos.EjecutarProcedure("NOT_NULL.BuscarMicros", patenteABuscar, idtipoDeServicio, idMarca, idModelo, capacidad);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///  Trae los micros disponibles para generar un viaje para una fecha determinada 
        ///  y con un tipo de servicio que sea igual al del recorrido que se asociará al viaje.
        ///  El micro no debe estar en mantenimiento en la fecha de inicio del viaje.
        /// </summary>
        /// <param name="idRecorrido">Id del recorrido</param>
        /// <param name="fecSalid">Fecha de salida del viaje</param>
        /// <param name="micros">Combo a llenar</param>
        public static void LlenarComboDisponibles(Int32 idRecorrido, DateTime fecSalida, ComboBox micros)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                var sql = "select MIC_numMicro as id, MIC_patente " +
                    " from NOT_NULL.Micro, NOT_NULL.Recorrido " +
                    " where MIC_idTipoServicio = REC_idTipoServicio AND " +
                    " REC_id = @idRecorrido AND " +
                    " MIC_Habilitado = 1 AND " +
                    " MIC_numMicro NOT IN (SELECT HMAN_idMicro FROM NOT_NULL.HistoricoMantenimiento WHERE " +
                    " convert(varchar, @fecSalida, 120) BETWEEN convert(varchar, HMAN_fecInicio, 120) " +
                    " AND convert(varchar, HMAN_fecFin, 120)) AND " +
                    " MIC_numMicro NOT IN (SELECT VIA_numMicro from NOT_NULL.Viaje WHERE " +
                    " datediff(hour, convert(varchar, VIA_fecLlegadaEstimada, 120), @fecSalida) < 24)";

                parametros.Add("@idRecorrido", idRecorrido);
                parametros.Add("@fecSalida", fecSalida.ToString("yyyy-MM-dd HH:mm:ss"));

                micros.DataSource = Conector.Datos.EjecutarComandoADataTable(sql, parametros);
                micros.ValueMember = "id";
                micros.DisplayMember = "MIC_patente";

                return;
            }
            catch
            {
                MessageBox.Show("No se pueden mostrar los micros disponibles");

                return;
            }
        }

        public static void LlenarCombo(ComboBox micros)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                var sql = "select MIC_numMicro as id, MIC_patente " +
                    " from NOT_NULL.Micro order by MIC_patente";

                micros.DataSource = Conector.Datos.EjecutarComandoADataTable(sql, parametros);
                micros.ValueMember = "id";
                micros.DisplayMember = "MIC_patente";

                return;
            }
            catch
            {
                MessageBox.Show("No se pueden mostrar los micros");

                return;
            }
        }

        public bool Insertar()
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Patente", this.Patente);
                parametros.Add("@IdTipoServicio", this.IdTipoDeServicio);
                parametros.Add("@KilosEncomiendas", this.KilosEncomiendas);
                parametros.Add("@Habilitado", this.Habilitado);
                parametros.Add("@IdMarca", this.IdMarca);
                parametros.Add("@IdModelo", this.IdModelo);
                parametros.Add("@FechaAlta", Configuracion.Instance().FechaSistema);

                Conector.Datos.IniciarTransaccion();

                Conector.Datos.EjecutarComando("insert into NOT_NULL.Micro " +
                                                " (MIC_patente, MIC_idTipoServicio, MIC_kilosEncomiendas, MIC_habilitado, MIC_idMarca, MIC_idModelo, MIC_fechaAlta) " +
                                                " values (@Patente, @IdTipoServicio, @KilosEncomiendas, @Habilitado, @IdMarca, @IdModelo, @FechaAlta)", parametros);

                if (!Butaca.InsertarTablaDeButacas(this.Butacas, Conector.Datos.TraerUltimoId()))
                {
                    Conector.Datos.AbortarTransaccion();

                    return false;
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

        public static bool cambiarHabilitado(int numMicro, int estado)
        {
            try
            {
                Hashtable parametros = new Hashtable();
                parametros.Add("@numMicro", numMicro);

                if (estado == 0)
                {
                    Conector.Datos.EjecutarComando("UPDATE NOT_NULL.Micro SET MIC_habilitado = 1 where MIC_numMicro = @numMicro", parametros);
                }
                else
                {
                    Conector.Datos.EjecutarComando("UPDATE NOT_NULL.Micro SET MIC_habilitado = 0 where MIC_numMicro = @numMicro", parametros);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool registarMantenimiento(int numMicro, DateTime inicioMantenimiento, DateTime finMantenimiento)
        {
            try
            {
                Hashtable parametros = new Hashtable();
                parametros.Add("@numMicro", numMicro);
                parametros.Add("@inicioMan", inicioMantenimiento.ToString("yyyy-MM-dd HH:mm:ss"));
                parametros.Add("@finMan", finMantenimiento.ToString("yyyy-MM-dd HH:mm:ss"));

                Conector.Datos.EjecutarComando("INSERT INTO NOT_NULL.HistoricoMantenimiento (HMAN_idMicro, HMAN_fecInicio, HMAN_fecFin) VALUES ( @numMicro, @inicioMan, @finMan)", parametros);

                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static void bajaDefinitiva(int numMicro)
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@fecha", Configuracion.Instance().FechaSistema);
            parametros.Add("@numMicro", numMicro);

            Conector.Datos.EjecutarComando("UPDATE NOT_NULL.Micro SET MIC_fecBaja = @fecha where MIC_numMicro = @numMicro", parametros);
        }

        internal bool Modificar(int idMicro)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@IdMicro", this.Id);
                parametros.Add("@Patente", this.Patente);
                parametros.Add("@IdTipoServicio", this.IdTipoDeServicio);
                parametros.Add("@KilosEncomiendas", this.KilosEncomiendas);
                parametros.Add("@Habilitado", this.Habilitado);
                parametros.Add("@IdMarca", this.IdMarca);
                parametros.Add("@IdModelo", this.IdModelo);
                parametros.Add("@fueraDeServicio", false);

                Conector.Datos.EjecutarComando("UPDATE NOT_NULL.Micro  SET MIC_patente = @Patente, MIC_idTipoServicio = @IdTipoServicio, MIC_kilosEncomiendas = @KilosEncomiendas, MIC_habilitado = @Habilitado, MIC_idMarca = @IdMarca, MIC_idModelo = @IdModelo WHERE MIC_numMicro = @IdMicro", parametros);
                Butaca.InsertarTablaDeButacas(this.Butacas, this.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static DataTable buscarViajesYRecorridosEnPeriodo(int idMicro, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                Hashtable parametros = new Hashtable();
                
                parametros.Add("@IdMicro", idMicro);
                parametros.Add("@fechaInicio", fechaInicio.ToString("yyyy-MM-dd HH:mm:ss"));
                parametros.Add("@fechaFin", fechaFin.ToString("yyyy-MM-dd HH:mm:ss"));
                
                DataTable dt = Conector.Datos.EjecutarComandoADataTable(
                    "SELECT VIA_numViaje, VIA_codRecorrido, VIA_fecSalida " +
                    "FROM NOT_NULL.Viaje " +
                    "WHERE VIA_numMicro = @IdMicro AND " +
                    "((convert(varchar, VIA_fecLlegadaEstimada, 120) >= @fechaInicio AND " + 
                    "convert(varchar, VIA_fecLlegadaEstimada, 120) <= @fechaFin) OR " +
                    "(convert(varchar, VIA_fecSalida, 120) >= @fechaInicio AND " + 
                    "convert(varchar, VIA_fecSalida, 120) <= @fechaFin))", parametros);

                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
