using System;
using System.Data.SqlClient;
using FrbaBus;
 
namespace AccesoADatos
{
    public class CapaDatos : BaseDatos
    {
        static readonly System.Collections.Hashtable ColComandos = new System.Collections.Hashtable();
  
        public override sealed string CadenaConexion
        {
            get
            {
                if (CadenaConexion.Length == 0)
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

                    CadenaConexion = sCadena.ToString();

                    return sCadena.ToString();
                }
                
                return CadenaConexion;
 
            }
            set
            { 
                CadenaConexion = value; 
            } 
        }
 
 
 
        protected override void CargarParametros(System.Data.IDbCommand com, Object[] args)
        {
            for (int i = 1; i < com.Parameters.Count; i++)
            {
                var p = (System.Data.SqlClient.SqlParameter)com.Parameters[i];
                p.Value = i <= args.Length ? args[i - 1] ?? DBNull.Value  : null;
            } 
        } 
 
        protected override System.Data.IDbCommand Comando(string procedimientoAlmacenado)
        {
            System.Data.SqlClient.SqlCommand com;
            if (ColComandos.Contains(procedimientoAlmacenado))
                com = (System.Data.SqlClient.SqlCommand)ColComandos[procedimientoAlmacenado];
            else
            {
                var con2 = new System.Data.SqlClient.SqlConnection(CadenaConexion);
                con2.Open();
                com = new System.Data.SqlClient.SqlCommand(procedimientoAlmacenado, con2) { CommandType = System.Data.CommandType.StoredProcedure };
                System.Data.SqlClient.SqlCommandBuilder.DeriveParameters(com);
                con2.Close();
                con2.Dispose();
                ColComandos.Add(procedimientoAlmacenado, com);
            }//end else
            com.Connection = (System.Data.SqlClient.SqlConnection)Conexion;
            com.Transaction = (System.Data.SqlClient.SqlTransaction)_Transaccion;
            return com;
        }
 
        protected override System.Data.IDbCommand ComandoSql(string comandoSql)
        {
            var com = new System.Data.SqlClient.SqlCommand(comandoSql, (System.Data.SqlClient.SqlConnection)Conexion, (System.Data.SqlClient.SqlTransaction)_Transaccion);
            return com;
        }
 
 
        protected override System.Data.IDbConnection CrearConexion(string cadenaConexion)
        { return new System.Data.SqlClient.SqlConnection(cadenaConexion); }
 
        protected override System.Data.IDataAdapter CrearDataAdapter(string procedimientoAlmacenado, params Object[] args)
        {
            var da = new System.Data.SqlClient.SqlDataAdapter((System.Data.SqlClient.SqlCommand)Comando(procedimientoAlmacenado));
            if (args.Length != 0)
                CargarParametros(da.SelectCommand, args);
            return da;
        }
 
        protected override System.Data.IDataAdapter CrearDataAdapterSql(string comandoSql)
        {
            var da = new System.Data.SqlClient.SqlDataAdapter((System.Data.SqlClient.SqlCommand)ComandoSql(comandoSql));
            return da;
        } 

        public CapaDatos()
        {
        }
 
        public CapaDatos(string cadenaConexion)
        { CadenaConexion = cadenaConexion; }
    }
}
