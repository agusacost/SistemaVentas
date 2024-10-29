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
    public class D_Categoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select IdCategoria,Descripcion,Estado,FechaCreacion from CATEGORIA");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Descripcion = dr["Descripcion"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    lista = new List<Categoria>();
                }
                return lista;
            }
        }

        public bool addCategoria(Categoria obj)
        {
            bool resultado = false;
            string query = "INSERT INTO CATEGORIA (Descripcion, Estado ) VALUES (@Descripcion, @Estado)";
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using(SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                        cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                        int rowsaffected = cmd.ExecuteNonQuery();
                        resultado = rowsaffected > 0;
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

        public bool editCategoria(Categoria obj)
        {
            bool resultado = false;

            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("UPDATE CATEGORIA SET Descripcion = @Descripcion,");
                query.AppendLine("Estado = @Estado");
                query.AppendLine("Where IdCategoria = @IdCategoria");
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand comando = new SqlCommand(query.ToString(), oconexion))
                    {
                        comando.Parameters.AddWithValue("@IdCategoria", obj.IdCategoria);
                        comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
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

        public bool bajaCategoria(int IdCategoria, bool nuevoEstado)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand comando = new SqlCommand("UPDATE CATEGORIA SET Estado = @Estado WHERE IdCategoria = @IdCategoria", oconexion))
                    {
                        comando.Parameters.AddWithValue("@Estado", nuevoEstado);
                        comando.Parameters.AddWithValue("@IdCategoria", IdCategoria);

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
