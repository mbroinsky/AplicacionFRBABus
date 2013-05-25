using System;
using System.Data.SqlClient;
using FrbaBus;

namespace AccesoADatos
{
    public class CapaDatos : BaseDatos
    {
        static readonly System.Collections.Hashtable ColComandos = new System.Collections.Hashtable();

        public override string CadenaConexion
        {
            get
            {
                if (_CadenaConexion.Length == 0)
                {
                    var sCadena = new System.Text.StringBuilder("");
                    sCadena.Append("data source=<SERVIDOR>;");
                    sCadena.Append("initial catalog=<BASE>;");
                    sCadena.Append("user id=<USER>;");
                    sCadena.Append("password=<PASSWORD>;");
                    sCadena.Replace("<SERVIDOR>", Configuracion.Instance().getServidorBase());
                    sCadena.Replace("<BASE>", Configuracion.Instance().getBaseDatos());
                    sCadena.Replace("<USER>", Configuracion.Instance().getUsuario());
                    sCadena.Replace("<PASSWORD>", Configuracion.Instance().getClave());

                    return sCadena.ToString();
                }

                return _CadenaConexion = CadenaConexion;

            }
            set
            {
                _CadenaConexion = value;
            }
        }

        protected override void CargarParametros(System.Data.IDbCommand com, Object[] args)
        {
            for (int i = 1; i < com.Parameters.Count; i++)
            {
                var p = (SqlParameter)com.Parameters[i];

                p.Value = i <= args.Length ? args[i - 1] ?? DBNull.Value : null;
            }
        }

        protected override System.Data.IDbCommand Comando(string procedimientoAlmacenado)
        {
            SqlCommand com;

            if (ColComandos.Contains(procedimientoAlmacenado))
                com = (SqlCommand)ColComandos[procedimientoAlmacenado];
            else
            {
                var con2 = new SqlConnection(CadenaConexion);

                con2.Open();

                com = new SqlCommand(procedimientoAlmacenado, con2) { CommandType = System.Data.CommandType.StoredProcedure };

                SqlCommandBuilder.DeriveParameters(com);

                con2.Close();
                con2.Dispose();

                ColComandos.Add(procedimientoAlmacenado, com);
            }

            com.Connection = (SqlConnection)Conexion;
            com.Transaction = (SqlTransaction)_Transaccion;

            return com;
        }

        protected override System.Data.IDbCommand ComandoSql(string comandoSql)
        {
            var com = new SqlCommand(comandoSql, (SqlConnection)Conexion, (SqlTransaction)_Transaccion);
            return com;
        }


        protected override System.Data.IDbConnection CrearConexion(string cadenaConexion)
        {
            return new SqlConnection(cadenaConexion);
        }

        protected override System.Data.IDataAdapter CrearDataAdapter(string procedimientoAlmacenado, params Object[] args)
        {
            var da = new SqlDataAdapter((SqlCommand)Comando(procedimientoAlmacenado));

            if (args.Length != 0)
                CargarParametros(da.SelectCommand, args);

            return da;
        }

        protected override System.Data.IDataAdapter CrearDataAdapterSql(string comandoSql)
        {
            var da = new SqlDataAdapter((SqlCommand)ComandoSql(comandoSql));
            return da;
        }

        public CapaDatos()
        {
        }

        public CapaDatos(string cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }
    }
}

