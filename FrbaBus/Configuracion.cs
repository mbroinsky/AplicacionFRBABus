using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace FrbaBus
{
    public class Configuracion
    {
        private static Configuracion oInstance;
        private String ServidorBase;
        private String BaseDatos;
        private String Usuario;
        private String Clave;
        private DateTime FechaSistema;

        protected Configuracion()
        {
            XmlDocument xDoc = new XmlDocument();

            xDoc.Load("Configuracion.xml"); 

            XmlNodeList Config = xDoc.GetElementsByTagName("Configuracion");

            XmlNodeList opc = Config[0].ChildNodes;

            foreach (XmlNode nodo in opc)
            {
                if (nodo.Name.CompareTo("ServidorDatos") == 0)
                    ServidorBase = nodo.InnerText;
                else if (nodo.Name.CompareTo("BaseDatos") == 0)
                    BaseDatos = nodo.InnerText;
                else if (nodo.Name.CompareTo("Usuario") == 0)
                    Usuario = nodo.InnerText;
                else if (nodo.Name.CompareTo("Clave") == 0)
                    Clave = nodo.InnerText;
                else if (nodo.Name.CompareTo("FechaSistema") == 0)
                {
                    try
                    {
                        FechaSistema = DateTime.Parse(nodo.InnerText.ToString());
                    }
                    catch
                    {
                        FechaSistema = DateTime.Now;
                    }
                }
            }
        }

        public static Configuracion Instance()
        {

            if (oInstance == null)
                oInstance = new Configuracion();

            return oInstance;
        }

        public string getServidorBase() 
        {
            return ServidorBase;
        }

        public string getUsuario()
        {
            return Usuario;
        }

        public string getClave()
        {
            return Clave;
        }

        public string getBaseDatos()
        {
            return BaseDatos;
        }
    }
}
