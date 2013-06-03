using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public Int16 KilosEncomiendas { get; set; }
        public bool Habilitado { get; set; }
        public Int16 IdMarca { get; set; }
        public Int16 IdModelo { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool FueraDeServicio { get; set; }
        public DateTime FechaFueraDeServicio { get; set; }
        public DateTime FechaReinicioServicio { get; set; }
        public DateTime FechaDeBaja { get; set; }
        
        public ArrayList Butacas { get; set; }


        public Micro()
        {
            Butacas = new ArrayList();
        }

        public void AgregarButaca(Butaca but)
        {
            Butacas.Add(but);
        }

        public bool TraerMicro(int idMicro)
        {
            //DataTable dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.usuario, " +
            //           " NOT_NULL.rol where USR_nick = '" + nick + "' AND USR_idRol = ROL_id;");

            //if (dt.Rows.Count > 0)
            //{
            //    Id = Convert.ToInt16(dt.Rows[0]["USR_idUsuario"]);
            //    NombreUsr = dt.Rows[0]["USR_Nombre"] + " " + dt.Rows[0]["USR_Apellido"];
            //    Password = dt.Rows[0]["USR_Clave"];
            //    Rol = dt.Rows[0]["ROL_nombre"];
            //    IdRol = Convert.ToInt16(dt.Rows[0]["ROL_id"]);
                
            //    dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.funcXRol, " + 
            //           " NOT_NULL.funcionalidad where FXR_idRol = '" + IdRol.ToString() + 
            //           "' AND FXR_idFunc = FUN_id;");
                       
            //    for(int i = 0; i < dt.Rows.Count; i++)
            //        Permisos.Add(dt.Rows[i]["FUN_nombre"]);
                            
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return false;
        }

        public static DataTable BuscarMicro(String patenteABuscar, int idtipoDeServicio, int idMarca, int idModelo, String Capacidad)
        {

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
                                  "MIC_fecBaja as 'Baja definitiva' " +
                                  "from NOT_NULL.Micro, NOT_NULL.Marca, NOT_NULL.TipoServicio where " +
                                  "MIC_idMarca = MAR_idMarca and " +
                                  "MIC_idTipoServicio = SRV_idTipoServicio and ";
             
            if (patenteABuscar.Length != 0) { query += " MIC_patente = '" + patenteABuscar + "' and "; };
            if (++idtipoDeServicio != 0) { query += "MIC_idTipoServicio = " + idtipoDeServicio + " and "; };
            if (idModelo != 0) { query += "MIC_modelo = " + idModelo + " and "; };
            if (++idMarca != 0) { query += "MIC_idMarca = " + idMarca + " and "; };
            if (Capacidad.Length != 0) { query += "MIC_kilosEncomiendas = " + Capacidad + " and" ; };
            
            query += " 1=1";

            DataTable dt = Conector.Datos.EjecutarComandoADataTable(query);
            
            if (dt.Rows.Count > 0)
            {
                /*
                Id = Convert.ToInt16(dt.Rows[0]["MIC_numMicro"]);
                Patente = Convert.ToString(dt.Rows[0]["MIC_patente"]);
                IdTipoDeServicio = Convert.ToInt16(dt.Rows[0]["MIC_idTipoServicio"]);
                KilosEncomiendas = Convert.ToInt16(dt.Rows[0]["MIC_kilosEncomiendas"]);
                Habilitado = Convert.ToBoolean(dt.Rows[0]["MIC_habilitado"]);
                IdMarca = Convert.ToInt16(dt.Rows[0]["MIC_idMarca"]);
                iIdModelo = Convert.ToInt16(dt.Rows[0]["MIC_modelo"]);
                FechaAlta = Convert.ToDateTime(dt.Rows[0]["MIC_fechaAlta"]);
                FueraDeServicio = Convert.ToBoolean(dt.Rows[0]["MIC_fueraDeServicio"]);
                FechaFueraDeServicio = Convert.ToDateTime(dt.Rows[0]["MIC_fecFueraServ"]);
                FechaReinicioServicio = Convert.ToDateTime(dt.Rows[0]["MIC_fecReinicioServ"]);
                FechaDeBaja = Convert.ToDateTime(dt.Rows[0]["MIC_fecBaja"]);
                Butacas = null;
            */
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
       
        
        public bool InsertarMicro()
        {
            return true;
        }
    }
}
