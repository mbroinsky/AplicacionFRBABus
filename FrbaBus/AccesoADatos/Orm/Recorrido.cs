﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AccesoADatos;
using System.Windows.Forms;
using System.Collections;

namespace AccesoADatos.Orm
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

        public Recorrido(int idRec)
        {
            try
            {
                Hashtable param = new Hashtable();

                param.Add("@idRecorrido", idRec);

                String sql = "select REC_codigo, REC_idTipoServicio, REC_idCiudadOrigen, REC_idCiudadDestino," +
                    "REC_precioBase, REC_precioKilo, REC_habilitado FROM NOT_NULL.Recorrido WHERE " +
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
                        Habilitado = Convert.ToBoolean(dt.Rows[0]["REC_Habilitado"]);
                        Id = idRec;
                    }
                }
            }
            catch
            { 
                return;
            }
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

        public static DataTable Listar(string codigo, int? idRecorrido, int? idTipServ, 
                                int? idOrigen, int? idDestino)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.ListarRecorridos",
                                        idRecorrido, codigo, idTipServ, idOrigen, idDestino);

                return dt;
            }
            catch
            {
                return null;
            }
        }

    }
}
