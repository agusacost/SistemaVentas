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
    public class D_Clientes
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCliente,Documento,Nombre,Correo,Telefono,Estado from CLIENTE");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["Nombre"].ToString(),
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
                    lista = new List<Cliente>();
                }
                return lista;
            }
        }

        public bool Registrar(Cliente obj)
        {
            bool resultado = false;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand comando = new SqlCommand("INSERT INTO CLIENTE (Documento, Nombre, Correo, Telefono, Estado) VALUES (@Documento, @Nombre, @Correo, @Telefono, @Estado)", oconexion))
                    {
                        comando.Parameters.AddWithValue("@Documento", obj.Documento);
                        comando.Parameters.AddWithValue("@Nombre", obj.NombreCompleto);
                        comando.Parameters.AddWithValue("@Correo", obj.Correo);
                        comando.Parameters.AddWithValue("@Telefono", obj.Telefono);
                        comando.Parameters.AddWithValue("@Estado", obj.Estado);

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
