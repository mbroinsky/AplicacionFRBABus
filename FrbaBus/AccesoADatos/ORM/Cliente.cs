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
    public class Cliente
    {
        public Int32 Id { get; set; }
        public Int32 Dni {get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Mail { get; set; }
        public DateTime FecNac { get; set; }
        public Char Sexo { get; set; }
        public bool Discapacitado { get; set; }

        public Cliente(Int32 dni)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@dni", dni);

                DataTable dt = Conector.Datos.EjecutarComandoADataTable("select * from NOT_NULL.Cliente " +
                        " where CLI_dni = @dni;", parametros);

                if (dt.Rows.Count == 1)
                {
                    Id = Convert.ToInt16(dt.Rows[0]["CLI_idCliente"]);
                    Dni = dni;
                    Nombre = dt.Rows[0]["CLI_nombre"].ToString();
                    Apellido = dt.Rows[0]["CLI_apellido"].ToString();
                    Direccion = dt.Rows[0]["CLI_direccion"].ToString();
                    Telefono = dt.Rows[0]["CLI_telefono"].ToString();
                    Mail = Convert.ToString(dt.Rows[0]["CLI_mail"] ?? "");
                    FecNac = Convert.ToDateTime(dt.Rows[0]["CLI_fecNacimiento"]);

                    if (dt.Rows[0]["CLI_sexo"] == DBNull.Value)
                        Sexo = ' ';
                    else
                        Sexo = Convert.ToChar(dt.Rows[0]["CLI_sexo"]);

                    Discapacitado = Convert.ToBoolean(dt.Rows[0]["CLI_discapacitado"]);
                }
                else
                {
                    Id = -1;
                }
            }
            catch
            {
                Id = -1;
            }
        }

        public static DataTable obtenerPuntosCliente(int dni)
        {
            try
            {
                DataTable dt = new DataTable();
                Hashtable parametros = new Hashtable();

                parametros.Add("@dni", dni);
                parametros.Add("@fecha", Configuracion.Instance().FechaSistema);

                String sql = "SELECT PTS_puntos as Puntos, 'Ingreso' as 'Descripcion' " +
                             "FROM	NOT_NULL.Puntos, NOT_NULL.Cliente " +
                             "WHERE	CLI_dni = @dni " +
                             "AND PTS_idCliente = CLI_idCliente " +
                             "AND PTS_fecVencimiento > @fecha ";

                dt = Conector.Datos.EjecutarComandoADataTable(sql, parametros);
                         
                sql = "SELECT PRO_puntos as Puntos, 'Canjes' as 'Descripcion' " +
                             "FROM NOT_NULL.Cliente, NOT_NULL.Canje, NOT_NULL.Producto " +
                             "WHERE CLI_dni = @dni " +
                             "AND CNJ_idCliente = CLI_idCliente " +
                             "AND CNJ_idProducto = PRO_idProd";

                dt.Merge(Conector.Datos.EjecutarComandoADataTable(sql, parametros));

                return dt;

            }
            catch
            {
                return null;
            }
        }

        public static object productosDisponiblesParaCliente(int dni)
        {
            try
            {
                DataTable dt = Conector.Datos.EjecutarProcedureADataTable("NOT_NULL.ProductosDisponibleCliente", dni);

                return dt;
            }
            catch
            {
                MessageBox.Show("Falló al intentar mostrar el listado");
                return null;
            }
        }



        public static Int32 totalDePuntos(int dni)
        {
            try
            {
                string sql = "SELECT NOT_NULL.puntosTotalesCliente("+dni+")";
                DataTable dt = Conector.Datos.EjecutarComandoADataTable(sql);

                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch
            {
                return 0;
            }
        }

        internal static bool canjearProducto(int dni, int idProducto, int cantidad)
        {
            try
            {
                Conector.Datos.EjecutarProcedure("NOT_NULL.canjearProducto", dni, idProducto, cantidad, Configuracion.Instance().FechaSistema);

                return true;
            }
            catch
            {
                return false;
            }
        }

        internal bool Insertar()
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@mail", Mail);
                parametros.Add("@telefono", Telefono);
                parametros.Add("@sexo", Sexo);
                parametros.Add("@discapacitado", Discapacitado);
                parametros.Add("@nombre", Nombre);
                parametros.Add("@apellido", Apellido);
                parametros.Add("@dni", Dni);
                parametros.Add("@fecNac", FecNac);
                parametros.Add("@direccion", Direccion);

                Conector.Datos.EjecutarComando("INSERT INTO NOT_NULL.Cliente VALUES (" +
                    "@nombre, @apellido, @dni, @direccion, @telefono, @mail, @fecNac, @sexo, @discapacitado);",
                    parametros);

                Id = Conector.Datos.TraerUltimoId();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Modificar()
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@mail", Mail);
                parametros.Add("@telefono", Telefono);
                parametros.Add("@sexo", Sexo);
                parametros.Add("@discapacitado", Discapacitado);
                parametros.Add("@nombre", Nombre);
                parametros.Add("@apellido", Apellido);
                parametros.Add("@dni", Dni);
                parametros.Add("@fecNac", FecNac);
                parametros.Add("@direccion", Direccion);
                parametros.Add("@id", Id);

                Conector.Datos.EjecutarComando("UPDATE NOT_NULL.Cliente SET " +
                    "CLI_nombre = @nombre, CLI_apellido = @apellido, CLI_dni = @dni, " +
                    "CLI_direccion = @direccion, CLI_telefono = @telefono, CLI_mail = @mail, "+
                    "CLI_fecNacimiento = @fecNac, CLI_sexo = @sexo, CLI_discapacitado = @discapacitado " +
                    "WHERE CLI_idCliente = @id;",
                    parametros);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool TieneViajeEnFecha(Int32 idViaje)
        {
            try
            {
                int cant;
                
                Hashtable parametros = new Hashtable();

                parametros.Add("@idViaje", idViaje);
                parametros.Add("@idCliente", Id);

                cant = Convert.ToInt32(Conector.Datos.TraerEscalarDeComando("select count(*) from NOT_NULL.Pasaje " +
                        "where PAS_idCliente = @idCliente and  PAS_idViaje in (SELECT b.VIA_numViaje " +
                        " FROM NOT_NULL.Viaje as a, NOT_NULL.Viaje as b WHERE " +
                        " ABS(DATEDIFF(hour, b.VIA_fecSalida, a.VIA_fecSalida)) < 24 and a.VIA_numViaje = @idViaje and PAS_Cancelado = '0');", parametros));
                
                return (cant > 0);
            }
            catch
            {
                //Si falla la consulta se asume que tiene pasajes comprados
                return true;
            }
        }

        public bool EsJubilado()
        {
            int edad = Configuracion.Instance().FechaSistema.Year - FecNac.Year;

            DateTime cumpleañosActual = FecNac.AddYears(edad);
 
            if (Configuracion.Instance().FechaSistema.CompareTo(cumpleañosActual) > 0)
                edad--; 
            
            if (Sexo == 'M' && edad >= 65)
                return true;
            else if (Sexo == 'F' && edad >= 60)
                return true;
            else
                return false;
        }
    }
}
