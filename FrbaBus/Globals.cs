using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus
{
    public class Globals
    {
        public static Globals oInstance;
        public AccesoADatos.Consultas cons;
        public AccesoADatos.Actualizador act;

        private Globals()
        {
            String strCon = "Provider=SQLOLEDB;Data Source=" +
                 Configuracion.Instance().getServidorBase() +
                 ";Initial Catalog=" + Configuracion.Instance().getBaseDatos() +
                 ";User ID=" + Configuracion.Instance().getUsuario() +
                 ";Password=" + Configuracion.Instance().getClave() + ";";

            cons = new AccesoADatos.Consultas(strCon);
            act = new AccesoADatos.Actualizador(strCon);
        }

        public static Globals Instance()
        {

            if (oInstance == null)
                oInstance = new Globals();

            return oInstance;
        }

    }
}
