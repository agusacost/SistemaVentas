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
    }
}
