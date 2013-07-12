using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using FrbaBus.AccesoADatos;
using System.Windows.Forms;

namespace FrbaBus.AccesoADatos.Orm
{
    public class Tarjeta
    {
        public Int32 Id {get; set;}
        private String Numero;
        private String FecVencimiento;
        private Int32 TipoTarjeta;
        private Int16 Codigo;

        public Tarjeta()
        {
            Id = 0;
        }
        
        public Tarjeta(String numero, String fecVenc, Int32 tipo, Int16 codSeg)
        {
            Numero = numero;
            FecVencimiento = fecVenc;
            TipoTarjeta = tipo;
            Codigo = codSeg;
            Id = -1;
        }

        public bool Insertar()
        {
            try
            {
                if (Id != -1)
                    return false;

                Hashtable parametros = new Hashtable();

                parametros.Add("@numero", Numero);
                parametros.Add("@fecVenc", FecVencimiento);
                parametros.Add("@tipo", TipoTarjeta);
                parametros.Add("@codSeg", Codigo);
                
                Conector.Datos.EjecutarSql("insert into NOT_NULL.tarjeta VALUES (@numero, @fecVenc, " +
                    "@tipo, @codSeg);", parametros);

                Id = Conector.Datos.TraerUltimoId();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void LlenarComboTipos(ComboBox tipos)
        {
            try
            {
                tipos.DataSource = Conector.Datos.EjecutarComandoADataTable("select TIPT_idTipoTarjeta as id, " +
                    " TIPT_descripcion as descripcion from NOT_NULL.TipoTarjeta order by TIPT_descripcion;"); ;

                tipos.DisplayMember = "descripcion";
                tipos.ValueMember = "id";

                return;
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al cargar los tipos de tarjeta");
                return;
            }
        }

    }

}