using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Data
{
    public class D_Venta
    {
        public int getCorrelativo()
        {
            int idCorrelativo = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select count(*) + 1 from VENTA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    idCorrelativo = 0;
                }
            }


            return idCorrelativo;
        }

        public bool restarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update PRODUCTO set stock = stock - @cantidad where IdProducto = @IdProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    respuesta = false;
                }
            }


            return respuesta;
        }

        public bool sumarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update PRODUCTO set stock = stock + @cantidad where IdProducto = @IdProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    respuesta = false;
                }
            }


            return respuesta;
        }

        public bool registrar(Venta obj, DataTable detalleCompra, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarVenta", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agrega los parámetros básicos
                    cmd.Parameters.AddWithValue("@IdUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@DocumentoCliente", obj.DocumentoCliente);
                    cmd.Parameters.AddWithValue("@NombreCliente", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("@MontoPago", obj.MontoPago);
                    cmd.Parameters.AddWithValue("@MontoCambio", obj.MontoCambio);
                    cmd.Parameters.AddWithValue("@MontoTotal", obj.MontoTotal);

                    // Parámetro de tipo tabla
                    SqlParameter detalleCompraParam = new SqlParameter
                    {
                        ParameterName = "@DetalleVenta", // Nombre del parámetro en el procedimiento almacenado
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "EDetalle_Venta", // Debe coincidir exactamente con el tipo de tabla en SQL Server
                        Value = detalleCompra
                    };
                    cmd.Parameters.Add(detalleCompraParam);

                    // Parámetros de salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    // Ejecuta el comando
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    // Obtiene los valores de salida
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    mensaje = ex.Message;
                }
            }
            return respuesta;
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta obj = new Venta();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select v.IdVenta, u.NombreCompleto, v.TipoDocumento,v.Documento,");
                    query.AppendLine("v.DocumentoCliente, v.NombreCliente,");
                    query.AppendLine("v.MontoPago,v.MontoCambio,v.MontoTotal,");
                    query.AppendLine("convert(char(10), v.FechaRegistro, 103)[FechaRegistro]");
                    query.AppendLine("from VENTA v");
                    query.AppendLine("inner join USUARIO u on u.IdUsuario = v.IdUsuario");
                    query.AppendLine("where v.Documento = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Venta()
                            {
                                IdVenta = Convert.ToInt32(dr["IdVenta"]),
                                oUsuario = new Usuario() { NombreCompleto = dr["NombreCompleto"].ToString() },
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                NumeroDocumento = dr["Documento"].ToString(),
                                MontoPago = Convert.ToDecimal(dr["MontoPago"]),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                                MontoCambio = Convert.ToDecimal(dr["MontoCambio"]),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    obj = new Venta();
                }
            }

            return obj;
        }

        public List<Detalle_Venta> ObtenerDetalleVenta(int idVenta)
        {
            List<Detalle_Venta> oLista = new List<Detalle_Venta>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Nombre, dv.PrecioVenta, dv.Cantidad, dv.Subtotal from DETALLE_VENTA dv");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = dv.IdProducto");
                    query.AppendLine("where dv.IdVenta = @IdVenta"); // Ensure @IdVenta is in the correct case

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta); // Use the correct parameter case
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Venta()
                            {
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                SubTotal = Convert.ToDecimal(dr["Subtotal"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                oLista = new List<Detalle_Venta>();
            }
            return oLista;
        }

        public List<Venta> ListaVentas()
        {
            List<Venta> listaV = new List<Venta>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select TipoDocumento, Documento, DocumentoCliente, NombreCliente ,MontoPago, MontoCambio,");
                    query.AppendLine("MontoTotal, CAST(FechaRegistro as DATE) as FechaRegistro");
                    query.AppendLine("from VENTA");
                    oconexion.Open();
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaV.Add(new Venta()
                            {
                                TipoDocumento = reader["TipoDocumento"].ToString(),
                                NumeroDocumento = reader["Documento"].ToString(),
                                DocumentoCliente = reader["DocumentoCliente"].ToString(),
                                NombreCliente = reader["NombreCliente"].ToString(),
                                MontoPago = Convert.ToDecimal(reader["MontoPago"].ToString()),
                                MontoCambio = Convert.ToDecimal(reader["MontoPago"].ToString()),
                                MontoTotal = Convert.ToDecimal(reader["MontoTotal"].ToString()),
                                FechaRegistro = reader["FechaRegistro"].ToString(),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                listaV = new List<Venta>();
                Console.WriteLine(ex.Message);
            }

            return listaV;
        }
        public List<BackupV> ListarBackup()
        {
            List<BackupV> listado = new List<BackupV>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT CONVERT(char(10), v.FechaRegistro, 103) AS [FechaRegistro], v.TipoDocumento,v.Documento, v.MontoTotal,u.NombreCompleto AS [UsuarioRegistro]," +
                        "v.DocumentoCliente,v.NombreCliente, p.Codigo AS [CodigoProducto],p.Nombre AS [NombreProducto],ca.Descripcion AS [Categoria],dv.PrecioVenta,dv.Cantidad,dv.SubTotal FROM Venta v");
                    query.AppendLine("INNER JOIN Usuario u ON u.IdUsuario = v.IdUsuario INNER JOIN Detalle_Venta dv ON dv.IdVenta = v.IdVenta INNER JOIN Producto p ON p.IdProducto = dv.IdProducto INNER JOIN Categoria ca ON ca.IdCategoria = p.IdCategoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listado.Add(new BackupV()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                Documento = dr["Documento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                listado = new List<BackupV>();
            }

            return listado;

        }

    }
}
