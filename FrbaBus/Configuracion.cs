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
        public String ServidorBase { get; set; }
        public String BaseDatos { get; set; }
        public String Usuario { get; set; }
        public String Clave { get; set; }
        public DateTime FechaSistema { get; set; }

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
                    if Validador.esFechaValida(nodo.InnerText.ToString())
                    {
                        try
                        {
                            FechaSistema = DateTime.Parse(nodo.InnerText.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("Falló la carga de la fecha del archivo de configuración, se toma la fecha del sistema")
                            FechaSistema = DateTime.Now;
                        }
                    }
                    else
                        FechaSistema = DateTime.Now;
                }
            }
        }

        public static Configuracion Instance()
        {

            if (oInstance == null)
                oInstance = new Configuracion();

            return oInstance;
        }       
    }
}
