using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public class BaseDatos
    {
        protected OleDbConnection baseDatos;
        protected OleDbCommand cmd;
        protected OleDbTransaction transaccion;

        public BaseDatos()
        {
            baseDatos = null;
            cmd = null;
        }

        protected override void Finalize()
        {
            baseDatos.Close();
        }

        public string formatearHora(System.DateTime datHora)
        {
            return string.Format("{0:HH:mm:ss}", datHora);
        }

        public string formatearFecHora(System.DateTime datFec, System.DateTime datHora)
        {
            return string.Format("{0:yyyy-mm-dd} {1:HH:mm:ss}", datFec, datHora);
        }

        public string formatearFecha(System.DateTime datFecha)
        {
            return string.Format("{0:yyyy-MM-dd}", datFecha);
        }

        public string datetimeToDate(ref string strCampo)
        {
            return "DATE_FORMAT(" + strCampo + ", '%Y-%m-%d')";
        }

        public string to24Horas(ref string strCampo)
        {
            return "TIME_FORMAT(" + strCampo + ", '%H:%i:%s')";
        }

        public DataSet getDataSet(string sql)
        {
            DataSet dt = new DataSet();

            cmd.CommandText = sql;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

#region "Manejo Base"
        public void begin()
        {
            baseDatos.Open();
            transaccion = baseDatos.BeginTransaction();
        }

        public void commit()
        {
            transaccion.Commit();
            cmd.Parameters.Clear();
            baseDatos.Close();
        }

        public void rollback()
        {
            transaccion.Rollback();
            cmd.Parameters.Clear();
            baseDatos.Close();
        }
#endregion
    }
}
