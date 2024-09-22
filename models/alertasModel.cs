using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaDeAlarma.config;

namespace SistemaDeAlarma.models
{
    public class alertasModel
    {
        public int IdAlerta { get; set; }
        public int IdUsuario { get; set; }
        public int IdSensor { get; set; }
        public int IdLectura { get; set; }
        public DateTime FechaAlerta { get; set; }
        public string TipoAlerta { get; set; }
        public string NivelAlarmaAlerta { get; set; }
        public string DescripcionAlerta { get; set; }

        public alertasModel() { }

        public static alertasModel Insertar(alertasModel alerta)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "INSERT INTO alertas (ID_USUARIO, ID_SENSOR, ID_LECTURA, fecha_hora_alerta, tipo_alerta, nivel_alarma_alerta, descripcion_alerta) " +
                                    "OUTPUT INSERTED.ID_ALERTA, INSERTED.ID_USUARIO, INSERTED.ID_SENSOR, INSERTED.ID_LECTURA, INSERTED.fecha_hora_alerta, " +
                                     "INSERTED.tipo_alerta, INSERTED.nivel_alarma_alerta, INSERTED.descripcion_alerta " +
                                     "VALUES (@IdUsuario, @IdSensor, @IdLectura, @FechaAlerta, @TipoAlerta, @NivelAlarmaAlerta, @DescripcionAlerta)";


                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdUsuario", alerta.IdUsuario);
                        comando.Parameters.AddWithValue("@IdSensor", alerta.IdSensor);
                        comando.Parameters.AddWithValue("@IdLectura", alerta.IdLectura);
                        comando.Parameters.AddWithValue("@FechaAlerta", alerta.FechaAlerta);
                        comando.Parameters.AddWithValue("@TipoAlerta", alerta.TipoAlerta);
                        comando.Parameters.AddWithValue("@NivelAlarmaAlerta", alerta.NivelAlarmaAlerta);
                        comando.Parameters.AddWithValue("@DescripcionAlerta", alerta.DescripcionAlerta);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new alertasModel
                                {
                                    IdAlerta = Convert.ToInt32(lector["ID_ALERTA"]),
                                    IdUsuario = Convert.ToInt32(lector["ID_USUARIO"]),
                                    IdSensor = Convert.ToInt32(lector["ID_SENSOR"]),
                                    FechaAlerta = Convert.ToDateTime(lector["fecha_alerta"]),
                                    TipoAlerta = lector["tipo_alerta"].ToString(),
                                    NivelAlarmaAlerta = lector["nivel_alarma_alerta"].ToString(),
                                    DescripcionAlerta = lector["descripcion_alerta"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al insertar la alerta.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al insertar la alerta.");
            }
            return null;
        }

        public static string Actualizar(alertasModel alerta)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "UPDATE alertas SET ID_USUARIO = @IdUsuario, ID_SENSOR = @IdSensor, ID_LECTURA = @IdLectura, " +
                                    "fecha_hora_alerta = @FechaAlerta, tipo_alerta = @TipoAlerta, nivel_alarma_alerta = @NivelAlarmaAlerta, " +
                                    "descripcion_alerta = @DescripcionAlerta WHERE ID_ALERTA = @IdAlerta";


                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdAlerta", alerta.IdAlerta);
                        comando.Parameters.AddWithValue("@IdUsuario", alerta.IdUsuario);
                        comando.Parameters.AddWithValue("@IdSensor", alerta.IdSensor);
                        comando.Parameters.AddWithValue("@IdLectura", alerta.IdLectura);
                        comando.Parameters.AddWithValue("@IdLectura", alerta.IdLectura);
                        comando.Parameters.AddWithValue("@FechaAlerta", alerta.FechaAlerta);
                        comando.Parameters.AddWithValue("@TipoAlerta", alerta.TipoAlerta);
                        comando.Parameters.AddWithValue("@NivelAlarmaAlerta", alerta.NivelAlarmaAlerta);
                        comando.Parameters.AddWithValue("@DescripcionAlerta", alerta.DescripcionAlerta);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al actualizar la alerta.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al actualizar la alerta.");
                return "Error";
            }
        }

        public static string Eliminar(int idAlerta)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "DELETE FROM alertas WHERE ID_ALERTA = @IdAlerta";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdAlerta", idAlerta);
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
                ControlErrores.ManejarErrorSql(ex, "Error al eliminar la alerta.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al eliminar la alerta.");
                return "Error";
            }
        }

        public static alertasModel ObtenerPorId(int idAlerta)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM alertas WHERE ID_ALERTA = @IdAlerta";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdAlerta", idAlerta);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new alertasModel
                                {
                                    IdAlerta = Convert.ToInt32(lector["ID_ALERTA"]),
                                    IdUsuario = Convert.ToInt32(lector["ID_USUARIO"]),
                                    IdSensor = Convert.ToInt32(lector["ID_SENSOR"]),
                                    IdLectura = Convert.ToInt32(lector["ID_LECTURA"]),
                                    FechaAlerta = Convert.ToDateTime(lector["fecha_hora_alerta"]),
                                    TipoAlerta = lector["tipo_alerta"].ToString(),
                                    NivelAlarmaAlerta = lector["nivel_alarma_alerta"].ToString(),
                                    DescripcionAlerta = lector["descripcion_alerta"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al obtener la alerta.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al obtener la alerta.");
            }
            return null;
        }

        public static List<alertasModel> ObtenerTodos()
        {
            var alertas = new List<alertasModel>();

            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT ID_ALERTA, ID_USUARIO, ID_SENSOR, ID_LECTURA, fecha_hora_alerta, tipo_alerta, nivel_alarma_alerta, descripcion_alerta FROM alertas";


                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                alertas.Add(new alertasModel
                                {
                                    IdAlerta = Convert.ToInt32(lector["ID_ALERTA"]),
                                    IdUsuario = Convert.ToInt32(lector["ID_USUARIO"]),
                                    IdSensor = Convert.ToInt32(lector["ID_SENSOR"]),
                                    IdLectura = Convert.ToInt32(lector["ID_LECTURA"]),
                                    FechaAlerta = Convert.ToDateTime(lector["fecha_hora_alerta"]),
                                    TipoAlerta = lector["tipo_alerta"].ToString(),
                                    NivelAlarmaAlerta = lector["nivel_alarma_alerta"].ToString(),
                                    DescripcionAlerta = lector["descripcion_alerta"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al obtener la lista de alertas.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al obtener la lista de alertas.");
            }

            return alertas;
        }
    }
}