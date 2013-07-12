using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrbaBus.AccesoADatos;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;

namespace FrbaBus.AccesoADatos.Orm
{
    class Recorrido
    {
        public Int32 Id { get; set; }
        public String Codigo { get; set; }
        public Int32 IdTipoServ { get; set; }
        public Int32 IdCiuOri { get; set; }
        public Int32 IdCiuDest { get; set; }
        public Double PrecBase { get; set; }
        public Double PrecKilo { get; set; }
        public Boolean Habilitado { get; set; }
        public DateTime TiempoViaje { get; set; }

        public Recorrido(int idRec)
        {
            try
            {
                Hashtable param = new Hashtable();

                param.Add("@idRecorrido", idRec);

                String sql = "select REC_codigo, REC_idTipoServicio, REC_idCiudadOrigen, REC_idCiudadDestino," +
                    "REC_precioBase, REC_precioKilo, REC_habilitado, REC_tiempoViaje FROM NOT_NULL.Recorrido WHERE " +
                    "REC_id = @idRecorrido;";

                using (DataTable dt = Conector.Datos.EjecutarComandoADataTable(sql, param))
                {
                    if (dt.Rows.Count == 1)
                    {
                        Codigo = Convert.ToString(dt.Rows[0]["REC_codigo"]);
                        IdTipoServ = Convert.ToInt32(dt.Rows[0]["REC_idTipoServicio"]);
                        IdCiuOri = Convert.ToInt32(dt.Rows[0]["REC_idCiudadOrigen"]);
                        IdCiuDest = Convert.ToInt32(dt.Rows[0]["REC_idCiudadDestino"]);
                        PrecBase = Convert.ToDouble(dt.Rows[0]["REC_precioBase"]);
                        PrecKilo = Convert.ToDouble(dt.Rows[0]["REC_precioKilo"]);
                        Habilitado = Convert.ToBoolean(dt.Rows[0]["REC_habilitado"]);
                        TiempoViaje = DateTime.Parse(dt.Rows[0]["REC_tiempoViaje"].ToString());
                        Id = idRec;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        public Recorrido(int id, string codigo, int idTipoServ, int idCiuOri, int idCiuDest, double precBase, 
            double precKilo, bool habilitado, DateTime tiempoViaje)
        {
            Id = id;
            Codigo = codigo;
            IdTipoServ = idTipoServ;
            IdCiuOri = idCiuOri;
            IdCiuDest = idCiuDest;
            PrecBase = precBase;
            PrecKilo = precKilo;
            Habilitado = habilitado;
            TiempoViaje = tiempoViaje;
        }

        public static void ListarCombo(ComboBox recorridos)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarComandoADataTable("select REC_id as id, " +
                    " (a.CIU_nombre + '-' + b.CIU_nombre + ' (' + SRV_nombreServicio + ')') as detalleRec " +
                    " from NOT_NULL.Recorrido, NOT_NULL.Ciudad a, NOT_NULL.Ciudad b, NOT_NULL.TipoServicio " +
                    " where REC_idCiudadOrigen = a.CIU_idCiudad AND REC_idCiudadDestino = b.CIU_idCiudad AND " +
                    " REC_idTipoServicio = SRV_idTipoServicio order by detalleRec;");

                recorridos.DataSource = dt;
                recorridos.ValueMember = "id";
                recorridos.DisplayMember = "detalleRec";

                return;
            }
            catch
            {
                MessageBox.Show("No se puede cargar el combo");

                return;
            }
        }

        public static DataTable Listar(bool habilitado, string codigo, int? idRecorrido, int? idTipServ,
                                int? idOrigen, int? idDestino)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.ListarRecorridos",
                                        idRecorrido, codigo, idTipServ, idOrigen, idDestino, habilitado);

                return dt;
            }
            catch
            {
                return null;
            }
        }

        public bool Insertar()
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@codigo", Codigo);
                parametros.Add("@idTipoServ", IdTipoServ);
                parametros.Add("@idCiuOrigen", IdCiuOri);
                parametros.Add("@idCiuDest", IdCiuDest);
                parametros.Add("@precioBase", PrecBase);
                parametros.Add("@precioKilo", PrecKilo);
                parametros.Add("@habilitado", Habilitado);
                parametros.Add("@tiempoViaje", TiempoViaje);

                if (Conector.Datos.EjecutarSql("insert into NOT_NULL.Recorrido " +
                           " (REC_codigo, REC_idTipoServicio, REC_idCiudadOrigen, REC_idCiudadDestino, " +
                            "REC_precioBase, REC_precioKilo, REC_habilitado, REC_tiempoViaje)" +
                           " values (@codigo, @idTipoServ, @idCiuOrigen, @idCiuDest, @precioBase, @precioKilo," +
                           "@habilitado, @tiempoViaje);", parametros) == 0)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Modificar()
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@codigo", Codigo);
                parametros.Add("@idTipoServ", IdTipoServ);
                parametros.Add("@idCiuOrigen", IdCiuOri);
                parametros.Add("@idCiuDest", IdCiuDest);
                parametros.Add("@precioBase", PrecBase);
                parametros.Add("@precioKilo", PrecKilo);
                parametros.Add("@habilitado", Habilitado);
                parametros.Add("@idRec", Id);
                parametros.Add("@tiempoViaje", TiempoViaje);

                if (Conector.Datos.EjecutarSql("update NOT_NULL.Recorrido SET " +
                           "REC_codigo = @codigo, REC_idTipoServicio = @idTipoServ, " +
                           "REC_idCiudadOrigen = @idCiuOrigen, REC_idCiudadDestino = @idCiuDest, " +
                           "REC_precioBase = @precioBase, REC_precioKilo = @precioKilo, " +
                           "REC_habilitado = @habilitado, REC_tiempoViaje = @tiempoViaje WHERE REC_id = @idRec;", parametros) == 0)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool TieneViajesAsociados()
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@idRec", Id);

                var cant = Convert.ToInt32(Conector.Datos.TraerEscalarDeComando("select count(*) from " +
                           "NOT_NULL.viaje WHERE VIA_codRecorrido = @idRec;", parametros));

                return (cant > 0);
            }
            catch
            {
                //Ante un error, por las dudas asumo que tiene viajes asociados
                return true;
            }
        }

        public static bool ExisteRecorrido(int idTipoServ, int idCiuOri, int idCiuDest)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@idTipoServicio", idTipoServ);
                parametros.Add("@idCiuOri", idCiuOri);
                parametros.Add("@idCiuDest", idCiuDest);

                var cant = Convert.ToInt32(Conector.Datos.TraerEscalarDeComando("select count(*) from " +
                           "NOT_NULL.recorrido WHERE REC_idTipoServicio = @idTipoServicio AND " +
                           "REC_idCiudadOrigen = @idCiuOri AND REC_idCiudadDestino = @idCiuDest AND " +
                           "REC_habilitado = '1';", parametros));

                return (cant > 0);
            }
            catch (Exception e)
            {
                //Ante un error, por las dudas asumo que existe un recorrido
                return true;
            }
        }

        public static bool Deshabilitar(int idRec)
        {
            try
            {
                DateTime fecHora = Configuracion.Instance().FechaSistema;
                
                Conector.Datos.EjecutarProcedure("NOT_NULL.DeshabilitarRecorrido",idRec, fecHora);
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
