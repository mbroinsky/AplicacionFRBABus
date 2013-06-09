using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace AccesoADatos.Orm
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
        }

       /*
        public void AgregarButaca(Butaca but)
        {
            Butacas.Add(but);
        }
        */
        public static Micro BuscarMicroPorId(int idMicro)
        {
            Micro micro = new Micro();

            String query =  "select MIC_numMicro as 'ID', " +
                            "MIC_patente as 'Matrícula', " +
                            "MIC_idTipoServicio as 'Tipo de Serv.', " +
                            "MIC_kilosEncomiendas as 'Capacidad', " +
                            "MIC_habilitado as 'Habilitado', " +
                            "MIC_idMarca as 'Marca', " +
                            "MIC_modelo as 'Modelo', " +
                            "MIC_fechaAlta as 'Fec. Alta', " +
                            "MIC_fueraDeServicio as 'Fuera de Servicio', " +
                            "MIC_fecFueraServ as 'Fec. Fuera de Serv.', " +
                            "MIC_fecReinicioServ as 'Fec. Reinicio Serv.', " +
                            "MIC_fecBaja as 'Fec. Baja definitiva' " +
                            "from NOT_NULL.Micro where " +
                            "MIC_numMicro = " + Convert.ToString(idMicro);

            DataTable dt = Conector.Datos.EjecutarComandoADataTable(query);
            var row = dt.Rows[0];

            micro.Id = Convert.ToInt16(row["ID"].ToString());
            micro.Patente = (row["Matrícula"].ToString());
            micro.IdTipoDeServicio = Convert.ToInt16(row["Tipo de Serv."].ToString());
            micro.KilosEncomiendas = Convert.ToDecimal(row["Capacidad"].ToString());
            micro.Habilitado = Convert.ToBoolean(row["Habilitado"].ToString());
            micro.IdMarca = Convert.ToInt16(row["Marca"].ToString());
            micro.FechaAlta = Convert.ToDateTime(row["Fec. Alta"].ToString());
            micro.FueraDeServicio = Convert.ToBoolean(row["Fuera de Servicio"].ToString());
            if (row["Fec. Reinicio Serv."].ToString().Length != 0) { micro.FechaReinicioServicio = Convert.ToDateTime(row["Fec. Reinicio Serv."].ToString()); }
            if (row["Fec. Baja definitiva"].ToString().Length != 0) { micro.FechaDeBaja = Convert.ToDateTime(row["Fec. Baja definitiva"].ToString()); }

            micro.Butacas = Orm.Butaca.TraerButacasPorMicro(micro.Id);           

            return micro;
        }

        public static DataTable BuscarMicro(String patenteABuscar, String idtipoDeServicio, String idMarca, String idModelo, String Capacidad)
        {
            //MODIFICAR USANDO HASH TABLE DE PARÁMETROS
            String query = "select MIC_numMicro as 'ID', " +
                                  "MIC_patente as 'Matrícula', " +
                                  "SRV_nombreServicio as 'Tipo de Serv.', " +
                                  "MIC_kilosEncomiendas as 'Capacidad', " +
                                  "MIC_habilitado as 'Habilitado', " +
                                  "MAR_nombreMarca as 'Marca', " +
                                  "MIC_modelo as 'Modelo', " +
                                  "MIC_fechaAlta as 'Fec. Alta', " +
                                  "MIC_fueraDeServicio as 'Fuera de Servicio', " +
                                  "MIC_fecFueraServ as 'Fec. Fuera de Serv.', " +
                                  "MIC_fecReinicioServ as 'Fec. Reinicio Serv.', " +
                                  "MIC_fecBaja as 'Fec. Baja definitiva' " +
                                  "from NOT_NULL.Micro, NOT_NULL.Marca, NOT_NULL.TipoServicio where " +
                                  "MIC_idMarca = MAR_idMarca and " +
                                  "MIC_idTipoServicio = SRV_idTipoServicio and ";
             
            if (patenteABuscar.Length != 0) { query += " MIC_patente = '" + patenteABuscar + "' and "; };
            if (idtipoDeServicio.Length != 0) { query += "MIC_idTipoServicio = " + idtipoDeServicio + " and "; };
            if (idModelo.Length != 0) { query += "MIC_modelo = " + idModelo + " and "; };
            if (idMarca.Length != 0) { query += "MIC_idMarca = " + idMarca + " and "; };
            if (Capacidad.Length != 0) { query += "MIC_kilosEncomiendas = " + Capacidad + " and " ; };
            query += " 1=1";

            DataTable dt = Conector.Datos.EjecutarComandoADataTable(query);
            
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

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
                    " (MIC_fueraDeServicio = 0 OR MIC_fecReinicioServ < @fecSalida) AND" +
                    " MIC_numMicro NOT IN (SELECT VIA_numMicro from NOT_NULL.Viaje WHERE " +
                    " datediff(hour, VIA_fecSalida, @fecSalida) < 24)";

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
                parametros.Add("@fueraDeServicio", false);

                Conector.Datos.EjecutarComando( "insert into NOT_NULL.Micro " +
                                                " (MIC_patente, MIC_idTipoServicio, MIC_kilosEncomiendas, MIC_habilitado, MIC_idMarca, MIC_modelo, MIC_fechaAlta, MIC_fueraDeServicio) " +
                                                " values (@Patente, @IdTipoServicio, @KilosEncomiendas, @Habilitado, @IdMarca, @IdModelo, GETDATE (), @fueraDeServicio);", parametros);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool InhabilitarMicro(int numMicro) 
        {
            try
            {
                Hashtable parametros = new Hashtable();
                parametros.Add("@numMicro", numMicro);

                Conector.Datos.EjecutarComando("UPDATE NOT_NULL.Micro SET MIC_habilitado = 0 where MIC_numMicro = @numMicro", parametros);
                return true;
            }
            catch
            {
                return false;
            }
        }



        internal static bool cambiarHabilitado(int numMicro, int estado)
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
        internal static bool cambiarEstado(int numMicro, int estado)
        {
            try
            {
                Hashtable parametros = new Hashtable();
                parametros.Add("@numMicro", numMicro);

                if (estado == 0)
                {
                    Conector.Datos.EjecutarComando("UPDATE NOT_NULL.Micro SET MIC_fueraDeServicio = 1, MIC_fecFueraServ = GETDATE() where MIC_numMicro = @numMicro", parametros);
                }
                else
                {
                    Conector.Datos.EjecutarComando("UPDATE NOT_NULL.Micro SET MIC_fueraDeServicio = 0,  MIC_fecReinicioServ = GETDATE() where MIC_numMicro = @numMicro", parametros);
                }

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
          parametros.Add("@numMicro", numMicro);
          Conector.Datos.EjecutarComando("UPDATE NOT_NULL.Micro SET MIC_fecBaja = GETDATE() where MIC_numMicro = @numMicro", parametros);
        }

        internal bool Modificar()
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

                Conector.Datos.EjecutarComando("UPDATE NOT_NULL.Micro  MIC_patente = @Patente, MIC_idTipoServicio = @IdTipoServicio, MIC_kilosEncomiendas = @KilosEncomiendas, MIC_habilitado = @Habilitado, MIC_idMarca = @IdMarca, MIC_modelo = @IdModelo WHERE MIC_numMicro = @IdMicro", parametros);
             
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
