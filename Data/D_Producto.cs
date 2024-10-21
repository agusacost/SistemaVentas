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
                    query.AppendLine("INNER JOIN PROVEEDOR p ON p.IdProveedor = u.IdProveedor ");
                    query.AppendLine("INNER JOIN CATEGORIA c ON c.IdCategoria = u.IdCategoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto()
                            {
                                IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                Codigo = reader["Codigo"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["ProductoDescripcion"].ToString(),
                                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(reader["IdCategoria"]), Descripcion = reader["CategoriaDescripcion"].ToString() },
                                Stock = Convert.ToInt32(reader["Stock"]),
                                PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"]),
                                PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                                oProveedor = new Proveedor()
                                {
                                    IdProveedor = Convert.ToInt32(reader["IdProveedor"]),
                                    Documento = reader["Documento"].ToString(),
                                }

                            });
                        }
                    }

                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    lista = new List<Producto>();
                }
                return lista;
            }
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
                        comando.Parameters.AddWithValue("@IdUsuario", IdProducto);

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
