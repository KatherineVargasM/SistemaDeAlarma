using SistemaDeAlarma.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlarma.models
{
    public class usuariosModel
    {
        public int IdUsuario { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public usuariosModel() { }

        public static usuariosModel Insertar(usuariosModel usuario)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "INSERT INTO usuarios (apellido_usuario, nombre_usuario, rol_usuario, telefono_usuario, email_usuario, fecha_nacimiento) " +
                                    "OUTPUT INSERTED.ID_USUARIO, INSERTED.apellido_usuario, INSERTED.nombre_usuario, INSERTED.rol_usuario, " +
                                    "INSERTED.telefono_usuario, INSERTED.email_usuario, INSERTED.fecha_nacimiento " +
                                    "VALUES (@Apellido, @Nombre, @Rol, @Telefono, @Email, @FechaNacimiento)";


                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        comando.Parameters.AddWithValue("@Rol", usuario.Rol);
                        comando.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        comando.Parameters.AddWithValue("@Email", usuario.Email);
                        comando.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new usuariosModel
                                {
                                    IdUsuario = Convert.ToInt32(lector["ID_USUARIO"]),
                                    Apellido = lector["apellido_usuario"].ToString(),
                                    Nombre = lector["nombre_usuario"].ToString(),
                                    Rol = lector["rol_usuario"].ToString(),
                                    Telefono = lector["telefono_usuario"].ToString(),
                                    Email = lector["email_usuario"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(lector["fecha_nacimiento"])
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al insertar el usuario.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al insertar el usuario.");
            }
            return null;
        }

        public static string Actualizar(usuariosModel usuario)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "UPDATE usuarios SET apellido_usuario = @Apellido, nombre_usuario = @Nombre, rol_usuario = @Rol, " +
                                   "telefono_usuario = @Telefono, email_usuario = @Email, fecha_nacimiento = @FechaNacimiento " +
                                   "WHERE ID_USUARIO = @IdUsuario";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                        comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        comando.Parameters.AddWithValue("@Rol", usuario.Rol);
                        comando.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        comando.Parameters.AddWithValue("@Email", usuario.Email);
                        comando.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al actualizar el usuario.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al actualizar el usuario.");
                return "Error";
            }
        }

        public string NombreCompleto
        {
            get
            {
                return $"{Apellido} {Nombre}";
            }
        }

        public static usuariosModel ObtenerPorId(int idUsuario)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM usuarios WHERE ID_USUARIO = @IdUsuario";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new usuariosModel
                                {
                                    IdUsuario = Convert.ToInt32(lector["ID_USUARIO"]),
                                    Apellido = lector["apellido_usuario"].ToString(),
                                    Nombre = lector["nombre_usuario"].ToString(),
                                    Rol = lector["rol_usuario"].ToString(),
                                    Telefono = lector["telefono_usuario"].ToString(),
                                    Email = lector["email_usuario"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(lector["fecha_nacimiento"])
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al obtener el usuario.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al obtener el usuario.");
            }
            return null;
        }

        public static List<usuariosModel> ObtenerTodos()
        {
            var usuarios = new List<usuariosModel>();

            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM usuarios";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                usuarios.Add(new usuariosModel
                                {
                                    IdUsuario = Convert.ToInt32(lector["ID_USUARIO"]),
                                    Apellido = lector["apellido_usuario"].ToString(),
                                    Nombre = lector["nombre_usuario"].ToString(),
                                    Rol = lector["rol_usuario"].ToString(),
                                    Telefono = lector["telefono_usuario"].ToString(),
                                    Email = lector["email_usuario"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(lector["fecha_nacimiento"])
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al obtener la lista de usuarios.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al obtener la lista de usuarios.");
            }

            return usuarios;
        }
    }
}
