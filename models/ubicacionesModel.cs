using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaDeAlarma.config;

namespace SistemaDeAlarma.models
{
    public class ubicacionesModel
    {
        public int IdUbicacion { get; set; }
        public string LugarUbicacion { get; set; }
        public string DescripcionUbicacion { get; set; }

        public ubicacionesModel() { }

        public static ubicacionesModel Insertar(ubicacionesModel ubicacion)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "INSERT INTO ubicaciones (lugar_ubicacion, descripcion_ubicacion) " +
                                   "OUTPUT INSERTED.ID_UBICACION, INSERTED.lugar_ubicacion, INSERTED.descripcion_ubicacion " +
                                   "VALUES (@LugarUbicacion, @DescripcionUbicacion)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@LugarUbicacion", ubicacion.LugarUbicacion);
                        comando.Parameters.AddWithValue("@DescripcionUbicacion", ubicacion.DescripcionUbicacion);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new ubicacionesModel
                                {
                                    IdUbicacion = Convert.ToInt32(lector["ID_UBICACION"]),
                                    LugarUbicacion = lector["lugar_ubicacion"].ToString(),
                                    DescripcionUbicacion = lector["descripcion_ubicacion"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al insertar la ubicación.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al insertar la ubicación.");
            }
            return null;
        }

        public static string Actualizar(ubicacionesModel ubicacion)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "UPDATE ubicaciones SET lugar_ubicacion = @LugarUbicacion, descripcion_ubicacion = @DescripcionUbicacion " +
                                   "WHERE ID_UBICACION = @IdUbicacion";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdUbicacion", ubicacion.IdUbicacion);
                        comando.Parameters.AddWithValue("@LugarUbicacion", ubicacion.LugarUbicacion);
                        comando.Parameters.AddWithValue("@DescripcionUbicacion", ubicacion.DescripcionUbicacion);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al actualizar la ubicación.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al actualizar la ubicación.");
                return "Error";
            }
        }

        public static string Eliminar(int idUbicacion)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "DELETE FROM ubicaciones WHERE ID_UBICACION = @IdUbicacion";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdUbicacion", idUbicacion);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                return "Error de restricción de clave foránea";
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al eliminar la ubicación.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al eliminar la ubicación.");
                return "Error";
            }
        }

        public static ubicacionesModel ObtenerPorId(int idUbicacion)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM ubicaciones WHERE ID_UBICACION = @IdUbicacion";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdUbicacion", idUbicacion);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new ubicacionesModel
                                {
                                    IdUbicacion = Convert.ToInt32(lector["ID_UBICACION"]),
                                    LugarUbicacion = lector["lugar_ubicacion"].ToString(),
                                    DescripcionUbicacion = lector["descripcion_ubicacion"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al obtener la ubicación.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al obtener la ubicación.");
            }
            return null;
        }

        public static List<ubicacionesModel> ObtenerTodos()
        {
            var ubicaciones = new List<ubicacionesModel>();

            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM ubicaciones";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                ubicaciones.Add(new ubicacionesModel
                                {
                                    IdUbicacion = Convert.ToInt32(lector["ID_UBICACION"]),
                                    LugarUbicacion = lector["lugar_ubicacion"].ToString(),
                                    DescripcionUbicacion = lector["descripcion_ubicacion"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al obtener la lista de ubicaciones.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al obtener la lista de ubicaciones.");
            }

            return ubicaciones;
        }
    }
}
