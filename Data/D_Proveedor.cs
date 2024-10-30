using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class D_Proveedor
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdProveedor,Documento,RazonSocial,Correo,Telefono,Estado from PROVEEDOR");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                IdProveedor = Convert.ToInt32(dr["IdProveedor"]),
                                Documento = dr["Documento"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    lista = new List<Proveedor>();
                }
                return lista;
            }
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            int resultado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                using (SqlCommand comando = new SqlCommand("sp_RegistrarProveedor", oconexion))
                {
                    // Agregar parámetros de entrada
                    comando.Parameters.AddWithValue("@Documento", obj.Documento);
                    comando.Parameters.AddWithValue("@RazonSocial", obj.RazonSocial);
                    comando.Parameters.AddWithValue("@Correo", obj.Correo);
                    comando.Parameters.AddWithValue("@Telefono", obj.Telefono);
                    comando.Parameters.AddWithValue("@Estado", obj.Estado);

                    // Parámetros de salida
                    comando.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    comando.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    comando.ExecuteNonQuery();

                    // Obtener valores de los parámetros de salida
                    resultado = Convert.ToInt32(comando.Parameters["Resultado"].Value);
                    Mensaje = comando.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Mensaje = "Error al registrar el proveedor: " + ex.Message;
                resultado = 0;
            }

            return resultado;
        }


        public bool Editar(Proveedor obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("sp_EditarProveedor", oconexion);
                    comando.Parameters.AddWithValue("IdProveedor", obj.IdProveedor);
                    comando.Parameters.AddWithValue("Documento", obj.Documento);
                    comando.Parameters.AddWithValue("RazonSocial", obj.RazonSocial);
                    comando.Parameters.AddWithValue("Correo", obj.Correo);
                    comando.Parameters.AddWithValue("Telefono", obj.Telefono);
                    comando.Parameters.AddWithValue("Estado", obj.Estado);
                    comando.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comando.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    comando.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(comando.Parameters["Resultado"].Value);
                    Mensaje = comando.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                respuesta = false;
            }

            return respuesta;

        }

        public bool Baja(int IdProveedor, bool nuevoEstado)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand comando = new SqlCommand("UPDATE PROVEEDOR SET Estado = @Estado WHERE IdProveedor = @IdProveedor", oconexion))
                    {
                        comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                        comando.Parameters.AddWithValue("@Estado", nuevoEstado);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resultado = false;
            }
            return resultado;
        }
    }
}
