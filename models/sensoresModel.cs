using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaDeAlarma.config;

namespace SistemaDeAlarma.models
{
    public class sensoresModel
    {
        public int IdSensor { get; set; }
        public int IdUbicacion { get; set; }
        public string TipoSensor { get; set; }
        public DateTime FechaInstalacionSensor { get; set; }
        public string EstadoSensor { get; set; }

        public sensoresModel() { }

        public static sensoresModel Insertar(sensoresModel sensor)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "INSERT INTO sensores (ID_UBICACION, tipo_sensor, fecha_instalacion_sensor, estado_sensor) " +
                                   "OUTPUT INSERTED.ID_SENSOR, INSERTED.ID_UBICACION, INSERTED.tipo_sensor, INSERTED.fecha_instalacion_sensor, INSERTED.estado_sensor " +
                                   "VALUES (@IdUbicacion, @TipoSensor, @FechaInstalacionSensor, @EstadoSensor)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdUbicacion", sensor.IdUbicacion);
                        comando.Parameters.AddWithValue("@TipoSensor", sensor.TipoSensor);
                        comando.Parameters.AddWithValue("@FechaInstalacionSensor", sensor.FechaInstalacionSensor);
                        comando.Parameters.AddWithValue("@EstadoSensor", sensor.EstadoSensor);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new sensoresModel
                                {
                                    IdSensor = Convert.ToInt32(lector["ID_SENSOR"]),
                                    IdUbicacion = Convert.ToInt32(lector["ID_UBICACION"]),
                                    TipoSensor = lector["tipo_sensor"].ToString(),
                                    FechaInstalacionSensor = Convert.ToDateTime(lector["fecha_instalacion_sensor"]),
                                    EstadoSensor = lector["estado_sensor"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al insertar el sensor.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al insertar el sensor.");
            }
            return null;
        }

        public static string Actualizar(sensoresModel sensor)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "UPDATE sensores SET ID_UBICACION = @IdUbicacion, tipo_sensor = @TipoSensor, fecha_instalacion_sensor = @FechaInstalacionSensor, " +
                                   "estado_sensor = @EstadoSensor WHERE ID_SENSOR = @IdSensor";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdSensor", sensor.IdSensor);
                        comando.Parameters.AddWithValue("@IdUbicacion", sensor.IdUbicacion);
                        comando.Parameters.AddWithValue("@TipoSensor", sensor.TipoSensor);
                        comando.Parameters.AddWithValue("@FechaInstalacionSensor", sensor.FechaInstalacionSensor);
                        comando.Parameters.AddWithValue("@EstadoSensor", sensor.EstadoSensor);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al actualizar el sensor.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al actualizar el sensor.");
                return "Error";
            }
        }

        public static string Eliminar(int idSensor)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "DELETE FROM sensores WHERE ID_SENSOR = @IdSensor";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdSensor", idSensor);
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
                ControlErrores.ManejarErrorSql(ex, "Error al eliminar el sensor.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al eliminar el sensor.");
                return "Error";
            }
        }

        public static sensoresModel ObtenerPorId(int idSensor)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM sensores WHERE ID_SENSOR = @IdSensor";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdSensor", idSensor);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new sensoresModel
                                {
                                    IdSensor = Convert.ToInt32(lector["ID_SENSOR"]),
                                    IdUbicacion = Convert.ToInt32(lector["ID_UBICACION"]),
                                    TipoSensor = lector["tipo_sensor"].ToString(),
                                    FechaInstalacionSensor = Convert.ToDateTime(lector["fecha_instalacion_sensor"]),
                                    EstadoSensor = lector["estado_sensor"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al obtener el sensor.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al obtener el sensor.");
            }
            return null;
        }

        public static List<sensoresModel> ObtenerTodos()
        {
            var sensores = new List<sensoresModel>();

            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM sensores";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                sensores.Add(new sensoresModel
                                {
                                    IdSensor = Convert.ToInt32(lector["ID_SENSOR"]),
                                    IdUbicacion = Convert.ToInt32(lector["ID_UBICACION"]),
                                    TipoSensor = lector["tipo_sensor"].ToString(),
                                    FechaInstalacionSensor = Convert.ToDateTime(lector["fecha_instalacion_sensor"]),
                                    EstadoSensor = lector["estado_sensor"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al obtener la lista de sensores.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al obtener la lista de sensores.");
            }

            return sensores;
        }
    }
}
