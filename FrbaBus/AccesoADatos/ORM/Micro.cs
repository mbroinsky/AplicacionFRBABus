using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

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

        public static DataTable BuscarMicro(String patenteABuscar, String idtipoDeServicio, String idModelo, String idMarca, String Capacidad)
        {

            String query = "select * from NOT_NULL.Micro";

            if (patenteABuscar.Length != 0) { query += "where MIC_patente = " + patenteABuscar + " and "; };
            if (idtipoDeServicio.Length != 0) { query += "MIC_idTipoServicio = " + idtipoDeServicio + " and"; };
            if (idModelo.Length != 0) { query += "MIC_modelo = " + idModelo + " and "; };
            if (idMarca.Length != 0) { query += "MIC_idMarca = " + idMarca + " and "; };
            if (Capacidad.Length != 0) { query += "MIC_kilosEncomiendas = " + Capacidad ; };

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
       
        
        public bool InsertarMicro()
        {
            return true;
        }
    }
}
