using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus
{
    public class Globales
    {
        public static Globales oInstance;
        public AccesoADatos.Consultas cons;
        public AccesoADatos.Actualizador act;
        public Usuario usr;
        
        private Globales()
        {
            String strCon = "Provider=SQLOLEDB;Data Source=" +
                 Configuracion.Instance().getServidorBase() +
                 ";Initial Catalog=" + Configuracion.Instance().getBaseDatos() +
                 ";User ID=" + Configuracion.Instance().getUsuario() +
                 ";Password=" + Configuracion.Instance().getClave() + ";";

            cons = new AccesoADatos.Consultas(strCon);
            act = new AccesoADatos.Actualizador(strCon);
            usr = new Usuario();
        }

        public static Globales Instance()
        {

            if (oInstance == null)
                oInstance = new Globales();

            return oInstance;
        }

    }
}
