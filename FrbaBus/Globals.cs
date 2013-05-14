using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus
{
    public class Globales
    {
        public static Globals oInstance;
        public AccesoADatos.Consultas cons;
        public AccesoADatos.Actualizador act;
        private String usuario {get; set;};
        private String nombreUsr {get; set;};
        private String rol {get; set;};
        private ArrayList permisos {get; set;};
        
        private Globales()
        {
            String strCon = "Provider=SQLOLEDB;Data Source=" +
                 Configuracion.Instance().getServidorBase() +
                 ";Initial Catalog=" + Configuracion.Instance().getBaseDatos() +
                 ";User ID=" + Configuracion.Instance().getUsuario() +
                 ";Password=" + Configuracion.Instance().getClave() + ";";

            cons = new AccesoADatos.Consultas(strCon);
            act = new AccesoADatos.Actualizador(strCon);
            permisos = new ArrayList();
        }

        public static Globales Instance()
        {

            if (oInstance == null)
                oInstance = new Globals();

            return oInstance;
        }

    }
}
