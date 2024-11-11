using System;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Collections;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System.Collections.Generic;

namespace Data
{
    public class D_Reporte
    {
        public double totalCompras(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            double totalcompra = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT SUM(Montototal) AS TotalMonto FROM DETALLE_COMPRA WHERE FechaRegistro BETWEEN @FechaDesde AND @FechaHasta");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@FechaDesde", dtFechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", dtFechaHasta);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            totalcompra = Convert.ToDouble(dr["TotalMonto"]);

                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    totalcompra = 0;
                }
                return totalcompra;
            }
        }

        public double totalVentas(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            double totalventa = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT SUM(Subtotal) AS TotalMonto FROM DETALLE_VENTA  WHERE FechaRegistro BETWEEN @FechaDesde AND @FechaHasta");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@FechaDesde", dtFechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", dtFechaHasta);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            totalventa = Convert.ToDouble(dr["TotalMonto"]);

                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    totalventa = 0;
                }
                return totalventa;
            }
        }
        //totales working
        public List<DateTime> FechasV(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            List<DateTime> FechasVentas = new List<DateTime>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT CAST(FechaRegistro AS DATE) AS Fecha");
                    query.AppendLine("FROM DETALLE_VENTA");
                    query.AppendLine("WHERE FechaRegistro BETWEEN @FechaDesde AND @FechaHasta");
                    query.AppendLine("GROUP BY CAST(FechaRegistro AS DATE)");
                    query.AppendLine("ORDER BY Fecha");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@FechaDesde", dtFechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", dtFechaHasta);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Leer la fecha y agregarla a la lista
                            if (dr["Fecha"] != DBNull.Value)
                            {
                                FechasVentas.Add(Convert.ToDateTime(dr["Fecha"]));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    // Manejo de errores silencioso
                    FechasVentas = new List<DateTime>();
                }
            }
            return FechasVentas;
        }


        public List<double> MontosV(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            List<double> MontosVentas = new List<double>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT CAST(FechaRegistro AS DATE) AS Fecha, SUM(Subtotal) AS TotalMonto");
                    query.AppendLine("FROM DETALLE_VENTA");
                    query.AppendLine("WHERE FechaRegistro BETWEEN @FechaDesde AND @FechaHasta");
                    query.AppendLine("GROUP BY CAST(FechaRegistro AS DATE)");
                    query.AppendLine("ORDER BY Fecha");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@FechaDesde", dtFechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", dtFechaHasta);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Leer el monto y agregarlo a la lista
                            if (dr["TotalMonto"] != DBNull.Value)
                            {
                                MontosVentas.Add(Convert.ToDouble(dr["TotalMonto"]));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    // Manejo de errores silencioso
                    MontosVentas = new List<double>();
                }
            }
            return MontosVentas;
        }

        //VENTAS WORKING

        public List<DateTime> FechasC(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            List<DateTime> FechasCompras = new List<DateTime>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT FechaRegistro, SUM(Montototal) AS TotalMonto FROM DETALLE_COMPRA WHERE FechaRegistro BETWEEN @FechaDesde AND @FechaHasta GROUP BY FechaRegistro ORDER BY FechaRegistro");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@FechaDesde", dtFechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", dtFechaHasta);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Agregar la fecha a la lista
                            FechasCompras.Add(Convert.ToDateTime(dr["FechaRegistro"]));
                        }
                    }
                }
                catch (Exception ex)
                {
                    FechasCompras = new List<DateTime>();
                    Console.WriteLine(ex.ToString());
                    // Puedes decidir si mantener la lista vacía o lanzarla para manejarla fuera del método.
                }
            }
            return FechasCompras;
        }

        public List<decimal> MontosC(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            List<decimal> MontosCompra = new List<decimal>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT FechaRegistro, SUM(Montototal) AS TotalMonto FROM DETALLE_COMPRA WHERE FechaRegistro BETWEEN @FechaDesde AND @FechaHasta GROUP BY FechaRegistro ORDER BY FechaRegistro");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@FechaDesde", dtFechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", dtFechaHasta);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Agregar el monto a la lista
                            MontosCompra.Add(Convert.ToDecimal(dr["TotalMonto"]));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MontosCompra = new List<decimal>();
                    Console.WriteLine(ex.ToString());
                    // Puedes decidir si mantener la lista vacía o lanzarla para manejarla fuera del método.
                }
            }
            return MontosCompra;
        }

        public List<string> Productos(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            List<string> productos = new List<string>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Construimos la consulta SQL
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT TOP 5 p.nombre, SUM(dv.SubTotal) as TotalMonto");
                    query.AppendLine("FROM DETALLE_VENTA dv");
                    query.AppendLine("JOIN Producto p ON dv.IdProducto = p.IdProducto");
                    query.AppendLine("WHERE dv.FechaRegistro BETWEEN @FechaDesde AND @FechaHasta");
                    query.AppendLine("GROUP BY p.nombre");
                    query.AppendLine("ORDER BY TotalMonto DESC");

                    // Ejecutamos la consulta
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@FechaDesde", dtFechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", dtFechaHasta);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Extraemos los nombres de los productos
                        while (dr.Read())
                        {
                            productos.Add(Convert.ToString(dr[0]));
                        }
                    }
                }
                catch (Exception)
                {
                    // Retornamos una lista vacía en caso de error
                    productos = new List<string>();
                }
            }
            return productos;
        }

        public List<double> MontosP(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            List<double> montos = new List<double>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Construimos la consulta SQL
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT TOP 5 SUM(dv.SubTotal) as TotalMonto");
                    query.AppendLine("FROM DETALLE_VENTA dv");
                    query.AppendLine("JOIN Producto p ON dv.IdProducto = p.IdProducto");
                    query.AppendLine("WHERE dv.FechaRegistro BETWEEN @FechaDesde AND @FechaHasta");
                    query.AppendLine("GROUP BY p.nombre");
                    query.AppendLine("ORDER BY TotalMonto DESC");

                    // Ejecutamos la consulta
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@FechaDesde", dtFechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", dtFechaHasta);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Extraemos los montos
                        while (dr.Read())
                        {
                            montos.Add(Convert.ToDouble(dr[0]));
                        }
                    }
                }
                catch (Exception)
                {
                    // Retornamos una lista vacía en caso de error
                    montos = new List<double>();
                }
            }
            return montos;
        }



    }
}
