using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.AccesoADatos.Orm;

namespace FrbaBus
{
    public class Globales
    {
        public static Globales oInstance;
        public Usuario usr;
        
        private Globales()
        {
            //String strCon = "Provider=SQLOLEDB;Data Source=" +
            //     Configuracion.Instance().getServidorBase() +
            //     ";Initial Catalog=" + Configuracion.Instance().getBaseDatos() +
            //     ";User ID=" + Configuracion.Instance().getUsuario() +
            //     ";Password=" + Configuracion.Instance().getClave() + ";";
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
