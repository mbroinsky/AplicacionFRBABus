using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public class Actualizador : BaseDatos
    {
        public Actualizador(string connection) : base()
	    {

		    //Inicializo objetos
		    baseDatos = new OleDbConnection(connection);

            cmd = new OleDbCommand();

		    cmd.Connection = baseDatos;

		    cmd.Transaction = transaccion;
	    }
    }
}