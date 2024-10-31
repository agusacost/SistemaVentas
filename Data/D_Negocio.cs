using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class D_Negocio
    {
        public Negocio GetData()
        {
            Negocio obj = new Negocio();

            try
            {
                using(SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "select IdNegocio, Nombre, CUIT,Direccion,Provincia,Localidad from negocio where IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            obj = new Negocio()
                            {
                                IdNegocio = int.Parse(reader["IdNegocio"].ToString()),
                                CUIT = reader["CUIT"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                Provincia = reader["Provincia"].ToString(),
                                Localidad = reader["Localidad"].ToString(),
                            };
                        }
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = new Negocio();
            }

            return obj;
        }

        public bool Guardar(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            bool respuesta = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE NEGOCIO SET Nombre = @nombre,");
                    query.AppendLine("CUIT = @cuit,");
                    query.AppendLine("Direccion = @direccion,");
                    query.AppendLine("Provincia = @provincia,");
                    query.AppendLine("Localidad = @localidad");
                    query.AppendLine("WHERE IdNegocio = 1");

                    using (SqlCommand cmd = new SqlCommand(query.ToString(), conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                        cmd.Parameters.AddWithValue("@cuit", obj.CUIT);
                        cmd.Parameters.AddWithValue("@direccion", obj.Direccion);
                        cmd.Parameters.AddWithValue("@provincia", obj.Provincia);
                        cmd.Parameters.AddWithValue("@localidad", obj.Localidad);
                        cmd.CommandType = CommandType.Text;

                        // Ejecutar y verificar si se afectaron filas
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            respuesta = true;
                        }
                        else
                        {
                            Mensaje = "No se pudieron guardar los datos.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = "Error al guardar los datos: " + ex.Message;
            }

            return respuesta;
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];

            try
            {
                using(SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "select Logo from NEGOCIO where IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LogoBytes = (byte[])reader["Logo"];
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obtenido= false ;
                LogoBytes = new byte[0];
            }
            return LogoBytes;   
        }

        public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;
            try
            {
                using(SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update NEGOCIO set Logo = @imagen");
                    query.AppendLine("where IdNegocio = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@imagen", image);
                    cmd.CommandType = CommandType.Text;

                    if(cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }
                }
            }
            catch(Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }
    }
}
