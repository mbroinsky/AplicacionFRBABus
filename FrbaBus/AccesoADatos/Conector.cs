namespace AccesoADatos
{
    public class Conector
    {
        public static CapaDatos Datos;
        
        public static bool IniciarSesion()
        {
            Datos = new CapaDatos();
            return Datos.AbrirConexion();
        } 
 
        public static void FinalizarSesion()
        {
            Datos.CerrarConexion();
        } 
     }
}
