using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public class Consultas : BaseDatos
    {
    	public Consultas(string connection) : base()
	    {
		    //Inicializo objetos
		    baseDatos = new OleDbConnection(connection);

		    cmd = new OleDbCommand();

		    cmd.Connection = baseDatos;

		    cmd.Transaction = transaccion;
	    }

        public DataSet getUsuario(String usuario)
        {
            return getDataSet("select * from NOT_NULL.usuario where USR_nick = '" + usuario + "';");
        }
    }   
}