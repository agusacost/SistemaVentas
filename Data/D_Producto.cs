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
    public class D_Producto
    {
        //TODO TERMINAR
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.IdProducto, u.Codigo, u.Nombre, u.Descripcion AS ProductoDescripcion, ");
                    query.AppendLine("u.IdCategoria, u.Stock, u.PrecioCompra, u.PrecioVenta, u.Estado, u.IdProveedor, ");
                    query.AppendLine("p.Documento, c.Descripcion AS CategoriaDescripcion ");
                    query.AppendLine("FROM PRODUCTO u ");
                    query.AppendLine("LEFT JOIN PROVEEDOR p ON p.IdProveedor = u.IdProveedor ");
                    query.AppendLine("LEFT JOIN CATEGORIA c ON c.IdCategoria = u.IdCategoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto()
                            {
                                IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                Codigo = reader["Codigo"]?.ToString(),
                                Nombre = reader["Nombre"]?.ToString(),
                                Descripcion = reader["ProductoDescripcion"]?.ToString(),
                                oCategoria = reader["IdCategoria"] != DBNull.Value ? new Categoria()
                                {
                                    IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                                    Descripcion = reader["CategoriaDescripcion"]?.ToString()
                                } : null,
                                Stock = reader["Stock"] != DBNull.Value ? Convert.ToInt32(reader["Stock"]) : (int?)null,
                                PrecioCompra = reader["PrecioCompra"] != DBNull.Value ? Convert.ToDecimal(reader["PrecioCompra"]) : (decimal?)null,
                                PrecioVenta = reader["PrecioVenta"] != DBNull.Value ? Convert.ToDecimal(reader["PrecioVenta"]) : (decimal?)null,
                                Estado = reader["Estado"] != DBNull.Value && Convert.ToBoolean(reader["Estado"]),
                                oProveedor = reader["IdProveedor"] != DBNull.Value ? new Proveedor()
                                {
                                    IdProveedor = Convert.ToInt32(reader["IdProveedor"]),
                                    Documento = reader["Documento"]?.ToString()
                                } : null
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al listar productos: {ex.Message}");
                }
                return lista;
            }
        }


        public bool Registrar(Producto obj)
        {
            bool resultado = false;

            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Estado)");
                query.AppendLine("VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Estado);");
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand comando = new SqlCommand(query.ToString(), oconexion))
                    {
                        comando.Parameters.AddWithValue("@Codigo", obj.Codigo);
                        comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                        comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                        comando.Parameters.AddWithValue("@IdCategoria", obj.oCategoria.IdCategoria);
                        comando.Parameters.AddWithValue("@Estado", obj.Estado);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                resultado = false;
            }

            return resultado;

        }
        public bool Editar(Producto obj)
        {
            bool resultado = false;

            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("UPDATE Producto SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion,IdCategoria = @IdCategoria,");
                query.AppendLine("IdProveedor = @IdProveedor, Estado = @Estado");
                query.AppendLine("Where IdProducto = @IdProducto");
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand comando = new SqlCommand(query.ToString(), oconexion))
                    {
                        comando.Parameters.AddWithValue("@IdProducto", obj.IdProducto);
                        comando.Parameters.AddWithValue("@Codigo", obj.Codigo);
                        comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                        comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                        comando.Parameters.AddWithValue("@IdCategoria", obj.oCategoria.IdCategoria);
                        comando.Parameters.AddWithValue("@IdProveedor", obj.oProveedor.IdProveedor);
                        comando.Parameters.AddWithValue("@Estado", obj.Estado);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                resultado = false;
            }

            return resultado;

        }
        public bool Baja(int IdProducto, bool nuevoEstado)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand comando = new SqlCommand("UPDATE PRODUCTO SET Estado = @Estado WHERE IdProducto = @IdProducto", oconexion))
                    {
                        comando.Parameters.AddWithValue("@Estado", nuevoEstado);
                        comando.Parameters.AddWithValue("@IdProducto", IdProducto);

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
