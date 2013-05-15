namespace AccesoADatos
{
    public class Conector
    {
        public static Datos Datos;
        public static bool IniciarSesion(string nombreServidor, string baseDatos, string usuario, string password)
        {
            Datos = new SqlServer(nombreServidor, baseDatos, usuario, password);
            return Datos.Autenticar();
        } 
 
        public static void FinalizarSesion()
        {
            Datos.CerrarConexion();
        } 
 
    }
}
