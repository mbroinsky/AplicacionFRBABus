using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using AccesoADatos;
using System.Windows.Forms;

namespace FrbaBus.AccesoADatos.Orm
{
    class Cliente
    {
        public static DataTable obtenerPuntosCliente(int dni)
        {
            try
            {
                DataTable dt = new DataTable();
                Hashtable parametros = new Hashtable();

                parametros.Add("@dni", dni);
                parametros.Add("@fecha", Configuracion.Instance().FechaSistema);

                String sql = "SELECT PTS_puntos as Puntos, 'Ingreso' as 'Descripcion' " +
                             "FROM	NOT_NULL.Puntos, NOT_NULL.Cliente " +
                             "WHERE	CLI_dni = @dni " +
                             "AND PTS_idCliente = CLI_idCliente " +
                             "AND PTS_fecVencimiento > @fecha " +
                             "UNION " +
                             "SELECT PRO_puntos as Puntos, 'Canjes' as 'Descripcion' " +
                             "FROM NOT_NULL.Cliente, NOT_NULL.Canje, NOT_NULL.Producto " +
                             "WHERE CLI_dni = @dni " +
                             "AND CNJ_idCliente = CLI_idCliente " +
                             "AND PRO_idProd = CNJ_idProducto";

                dt = Conector.Datos.EjecutarComandoADataTable(sql, parametros);

                return dt;

            }
            catch
            {
                return null;
            }
        }

        internal static object productosDisponiblesParaCliente(int dni)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.productosDisponibleCliente", dni);

                return dt;
            }
            catch
            {
                MessageBox.Show("Falló al intentar mostrar el listado");
                return null;
            }
        }
    }
}