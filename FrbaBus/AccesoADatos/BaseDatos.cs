using System;
using System.Data;

namespace AccesoADatos
{
    public abstract class BaseDatos
    {
        //Atributos Heredables
        protected IDbConnection _Conexion;
        protected IDbTransaction _Transaccion;
        protected bool _EnTransaccion;
        protected string _CadenaConexion = "";

        public abstract string CadenaConexion { get; set; }

        //Metodos abstractos que se deben definir en quien herede
        protected abstract IDbConnection CrearConexion(string cadena);
        protected abstract IDbCommand Comando(string procedimientoAlmacenado);
        protected abstract IDbCommand ComandoSql(string comandoSql);
        protected abstract IDataAdapter CrearDataAdapter(string procedimientoAlmacenado, params Object[] args);
        protected abstract IDataAdapter CrearDataAdapterSql(string comandoSql);
        protected abstract void CargarParametros(IDbCommand comando, Object[] args);


        protected IDbConnection Conexion
        {
            get
            {
                if (_Conexion == null)
                    _Conexion = CrearConexion(CadenaConexion);

                if (_Conexion.State != ConnectionState.Open)
                    _Conexion.Open();

                return _Conexion;
            }
        }

        public DataSet EjecutarProcedure(string storeProcedure)
        {
            var datos = new DataSet();

            CrearDataAdapter(storeProcedure).Fill(datos);

            return datos;
        }

        public DataSet EjecutarProcedure(string storeProcedure, params Object[] args)
        {
            var datos = new DataSet();

            CrearDataAdapter(storeProcedure, args).Fill(datos);

            return datos;
        }

        public DataSet EjecutarComando(string sql)
        {
            var datos = new DataSet();

            CrearDataAdapterSql(sql).Fill(datos);

            return datos;
        }

        public DataTable EjecutarProcedureADataTable(string storeProcedure)
        {
            return EjecutarProcedure(storeProcedure).Tables[0].Copy();
        }

        public DataTable EjecutarProcedureADataTable(string storeProcedure, params Object[] args)
        {
            return EjecutarProcedure(storeProcedure, args).Tables[0].Copy();
        }

        public DataTable EjecutarComandoADataTable(string sql)
        {
            return EjecutarComando(sql).Tables[0].Copy();
        }

        //public IDataReader TraerDataReader(string procedimientoAlmacenado)
        //{
        //    var com = Comando(procedimientoAlmacenado);
        //    return com.ExecuteReader();
        //} 


        //// Obtiene un DataReader a partir de un Procedimiento Almacenado y sus parÃ¡metros. 
        //public IDataReader TraerDataReader(string procedimientoAlmacenado, params object[] args)
        //{
        //    var com = Comando(procedimientoAlmacenado);
        //    CargarParametros(com, args);
        //    return com.ExecuteReader();
        //} // end TraerDataReader

        //// Obtiene un DataReader a partir de un Procedimiento Almacenado. 
        //public IDataReader TraerDataReaderSql(string comandoSql)
        //{
        //    var com = ComandoSql(comandoSql);
        //    return com.ExecuteReader();
        //} // end TraerDataReaderSql 

        //public object TraerValorOutput(string procedimientoAlmacenado)
        // {
        //     // asignar el string sql al command
        //     var com = Comando(procedimientoAlmacenado);
        //     // ejecutar el command
        //     com.ExecuteNonQuery();
        //     // declarar variable de retorno
        //     Object resp = null;

        //     // recorrer los parametros del SP
        //     foreach (IDbDataParameter par in com.Parameters)
        //         // si tiene parametros de tipo IO/Output retornar ese valor
        //         if (par.Direction == ParameterDirection.InputOutput || par.Direction == ParameterDirection.Output)
        //             resp = par.Value;
        //     return resp;
        // } // end TraerValor


        // // Obtiene un Valor a partir de un Procedimiento Almacenado, y sus parÃ¡metros. 
        // public object TraerValorOutput(string procedimientoAlmacenado, params Object[] args)
        // {
        //     // asignar el string sql al command
        //     var com = Comando(procedimientoAlmacenado);
        //     // cargar los parametros del SP
        //     CargarParametros(com, args);
        //     // ejecutar el command
        //     com.ExecuteNonQuery();
        //     // declarar variable de retorno
        //     Object resp = null;

        //     // recorrer los parametros del SP
        //     foreach (IDbDataParameter par in com.Parameters)
        //         // si tiene parametros de tipo IO/Output retornar ese valor
        //         if (par.Direction == ParameterDirection.InputOutput || par.Direction == ParameterDirection.Output)
        //             resp = par.Value;
        //     return resp;
        // } // end TraerValor

        // // Obtiene un Valor Escalar a partir de un Procedimiento Almacenado. 
        // public object TraerValorOutputSql(string comadoSql)
        // {
        //     // asignar el string sql al command
        //     var com = ComandoSql(comadoSql);
        //     // ejecutar el command
        //     com.ExecuteNonQuery();
        //     // declarar variable de retorno
        //     Object resp = null;

        //     // recorrer los parametros del Query (uso tipico envio de varias sentencias sql en el mismo command)
        //     foreach (IDbDataParameter par in com.Parameters)
        //         // si tiene parametros de tipo IO/Output retornar ese valor
        //         if (par.Direction == ParameterDirection.InputOutput || par.Direction == ParameterDirection.Output)
        //             resp = par.Value;
        //     return resp;
        // } // end TraerValor


        //// Obtiene un Valor de una funcion Escalar a partir de un Procedimiento Almacenado. 
        //public object TraerValorEscalar(string procedimientoAlmacenado)
        //{
        //    var com = Comando(procedimientoAlmacenado);
        //    return com.ExecuteScalar();
        //} // end TraerValorEscalar

        ///// Obtiene un Valor de una funcion Escalar a partir de un Procedimiento Almacenado, con Params de Entrada
        //public Object TraerValorEscalar(string procedimientoAlmacenado, params object[] args)
        //{
        //    var com = Comando(procedimientoAlmacenado);
        //    CargarParametros(com, args);
        //    return com.ExecuteScalar();
        //} // end TraerValorEscalar

        public object TraerEscalarDeComando(string sql)
        {
            var com = ComandoSql(sql);
            return com.ExecuteScalar();
        }

        public int TraerUltimoId()
        {
            try
            {
                return Convert.ToInt32(TraerEscalarDeComando("SELECT @@identity AS id;"));
            }
            catch
            {
                throw new Exception("No se puede obtener la última fila insertada");
            }
        }
        
        public bool AbrirConexion()
        {


            _Conexion = CrearConexion(CadenaConexion);

            _Conexion.Open();

            return true;
        }

        public void CerrarConexion()
        {
            if (Conexion.State != ConnectionState.Closed)
                _Conexion.Close();
        }

        public int Ejecutar(string storeProcedure)
        {
            return Comando(storeProcedure).ExecuteNonQuery();
        }

        public int EjecutarSql(string sql)
        {
            return ComandoSql(sql).ExecuteNonQuery();
        }

        public int Ejecutar(string storeProcedure, params  Object[] args)
        {
            var com = Comando(storeProcedure);

            CargarParametros(com, args);

            var resp = com.ExecuteNonQuery();

            for (var i = 0; i < com.Parameters.Count; i++)
            {
                var par = (IDbDataParameter)com.Parameters[i];
                if (par.Direction == ParameterDirection.InputOutput || par.Direction == ParameterDirection.Output)
                    args.SetValue(par.Value, i - 1);
            }

            return resp;
        }

        public void IniciarTransaccion()
        {
            try
            {
                _Transaccion = Conexion.BeginTransaction();
                _EnTransaccion = true;
            }
            catch
            {
                _EnTransaccion = false;
            }
        }

        public void TerminarTransaccion()
        {
            try
            {
                _Transaccion.Commit();
            }
            finally
            {
                _Transaccion = null;
                _EnTransaccion = false;
            }
        }

        public void AbortarTransaccion()
        {
            try
            {
                _Transaccion.Rollback();
            }
            finally
            {
                _Transaccion = null;
                _EnTransaccion = false;
            }
        }
    }
}

