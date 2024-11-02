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
    public class D_Compra
    {
        public int getCorrelativo()
        {
            int idCorrelativo = 0;
            using(SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select count(*) + 1 from COMPRA");
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
        public bool registrar(Compra obj, DataTable detalleCompra, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agrega los parámetros básicos
                    cmd.Parameters.AddWithValue("@IdUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@IdProveedor", obj.oProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("@Documento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@MontoTotal", obj.MontoTotal);

                    // Parámetro de tipo tabla
                    SqlParameter detalleCompraParam = new SqlParameter
                    {
                        ParameterName = "@DetalleCompra", // Nombre del parámetro en el procedimiento almacenado
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "EDetalle_Compra", // Debe coincidir exactamente con el tipo de tabla en SQL Server
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
