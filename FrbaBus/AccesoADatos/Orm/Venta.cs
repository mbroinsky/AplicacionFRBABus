using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using FrbaBus.AccesoADatos;

namespace FrbaBus.AccesoADatos.Orm
{
    class Venta
    {
        public Int64 IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public Double PrecioTotal { get; set; }
        public Int32 IdTarjeta { get; set; }

        public Venta(DateTime fechaVenta)
        {
            PrecioTotal = 0;
            FechaVenta = fechaVenta;
            IdTarjeta = -1;
        }

        public static Int64 TraerNumerador()
        {
            try
            {
            	Int64 numero = 0;
            
                numero = Convert.ToInt64(Conector.Datos.TraerValorOutput("NOT_NULL.TraerNumerador", "Venta", numero));

                return numero;

            }
            catch
            {
                return -1;
            }
        }
      

        public static DataTable TraerPasajesYEncomiendas(int idVenta)
        {

            DataTable dt = new DataTable();

            dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.listarPasajesYEncomiendas", idVenta);

            return dt;

        }

        public bool Insertar()
        {
            String sql;

            try
            {
                IdVenta = TraerNumerador();

                Hashtable parametros = new Hashtable();

                parametros.Add("@idVenta", IdVenta);
                parametros.Add("@fecVenta", FechaVenta);
                parametros.Add("@total", PrecioTotal);

                sql = "insert into NOT_NULL.Venta VALUES (@idVenta, @fecVenta, " +
                    "@total";

                if (IdTarjeta > -1)
                {
                    parametros.Add("@idTarjeta", IdTarjeta);
                    sql += ",@idTarjeta";
                }
                else
                {
                    sql += ",null";
                }

                sql += ");";

                Conector.Datos.EjecutarSql(sql, parametros);

                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool Actualizar()
        {
            String sql;

            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@idVenta", IdVenta);
                parametros.Add("@fecVenta", FechaVenta);
                parametros.Add("@total", PrecioTotal);

                sql = "update NOT_NULL.Venta set VEN_fecVenta = @fecVenta, " +
                    "VEN_total = @total ";

                if (IdTarjeta > -1)
                {
                    parametros.Add("@idTarjeta", IdTarjeta);
                    sql += " VEN_idTarjeta = @idTarjeta";
                }

                sql += " WHERE VEN_idVenta = @idVenta;";

                Conector.Datos.EjecutarSql(sql, parametros);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}