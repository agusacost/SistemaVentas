using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Reflection;
using System.Collections;

namespace Data
{
    public class D_User
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.IdUsuario,u.Documento,u.NombreCompleto,u.Correo,u.Clave,u.Estado, r.IdRol, r.Descripcion, u.Nacionalidad, u.Ciudad, u.Direccion, u.Telefono from USUARIO u");
                    query.AppendLine("inner join rol r on r.IdRol = u.IdRol");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                oRol = new Rol() { idRol = Convert.ToInt32(dr["IdRol"]), Descripcion = dr["Descripcion"].ToString() },
                                Nacionalidad = dr["Nacionalidad"].ToString(),
                                Ciudad = dr["Ciudad"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Telefono = dr["Telefono"].ToString()
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }

            }
            return lista;
        }

        public bool Registrar(Usuario obj)
        {
            bool resultado = false;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand comando = new SqlCommand("INSERT INTO USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado, Nacionalidad,Ciudad,Direccion,Telefono ) VALUES (@Documento, @NombreCompleto, @Correo, @Clave, @IdRol, @Estado, @Nacionalidad, @Ciudad, @Direccion, @Telefono)", oconexion))
                    {
                        comando.Parameters.AddWithValue("@Documento", obj.Documento);
                        comando.Parameters.AddWithValue("@NombreCompleto", obj.NombreCompleto);
                        comando.Parameters.AddWithValue("@Correo", obj.Correo);
                        comando.Parameters.AddWithValue("@Clave", obj.Clave);
                        comando.Parameters.AddWithValue("@IdRol", obj.oRol.idRol);
                        comando.Parameters.AddWithValue("@Estado", obj.Estado);
                        comando.Parameters.AddWithValue("@Nacionalidad", obj.Nacionalidad);
                        comando.Parameters.AddWithValue("@Ciudad", obj.Ciudad);
                        comando.Parameters.AddWithValue("@Direccion", obj.Direccion);
                        comando.Parameters.AddWithValue("@Telefono", obj.Telefono);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }


                }
            }
            catch (Exception ex)
            {
                resultado = false;
            }

            return resultado;

        }

        public bool Baja(int IdUsuario, bool nuevoEstado)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand comando = new SqlCommand("UPDATE USUARIO SET Estado = @Estado WHERE IdUsuario = @IdUsuario", oconexion))
                    {
                        comando.Parameters.AddWithValue("@Estado", nuevoEstado);
                        comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = false;
            }
            return resultado;
        }
    }
}
