using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaDeAlarma.config;


namespace SistemaDeAlarma.models
{
    public class eventosModel
    {
        public int IdEvento { get; set; }
        public int IdUsuario { get; set; }
        public int IdSensor { get; set; }
        public DateTime FechaEvento { get; set; }
        public string TipoEvento { get; set; }
        public string NivelAlarmaEvento { get; set; }
        public string DescripcionEvento { get; set; }

        public eventosModel() { }

        public static eventosModel Insertar(eventosModel evento)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "INSERT INTO eventos (ID_USUARIO, ID_SENSOR, fecha_evento, tipo_evento, nivel_alarma_evento, descripcion_evento) " +
                                   "OUTPUT INSERTED.ID_EVENTO, INSERTED.ID_USUARIO, INSERTED.ID_SENSOR, INSERTED.fecha_evento, " +
                                   "INSERTED.tipo_evento, INSERTED.nivel_alarma_evento, INSERTED.descripcion_evento " +
                                   "VALUES (@IdUsuario, @IdSensor, @FechaEvento, @TipoEvento, @NivelAlarmaEvento, @DescripcionEvento)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdUsuario", evento.IdUsuario);
                        comando.Parameters.AddWithValue("@IdSensor", evento.IdSensor);
                        comando.Parameters.AddWithValue("@FechaEvento", evento.FechaEvento);
                        comando.Parameters.AddWithValue("@TipoEvento", evento.TipoEvento);
                        comando.Parameters.AddWithValue("@NivelAlarmaEvento", evento.NivelAlarmaEvento);
                        comando.Parameters.AddWithValue("@DescripcionEvento", evento.DescripcionEvento);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new eventosModel
                                {
                                    IdEvento = Convert.ToInt32(lector["ID_EVENTO"]),
                                    IdUsuario = Convert.ToInt32(lector["ID_USUARIO"]),
                                    IdSensor = Convert.ToInt32(lector["ID_SENSOR"]),
                                    FechaEvento = Convert.ToDateTime(lector["fecha_evento"]),
                                    TipoEvento = lector["tipo_evento"].ToString(),
                                    NivelAlarmaEvento = lector["nivel_alarma_evento"].ToString(),
                                    DescripcionEvento = lector["descripcion_evento"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al insertar el evento.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al insertar el evento.");
            }
            return null;
        }

        public static string Actualizar(eventosModel evento)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "UPDATE eventos SET ID_USUARIO = @IdUsuario, ID_SENSOR = @IdSensor, " +
                                   "fecha_evento = @FechaEvento, tipo_evento = @TipoEvento, nivel_alarma_evento = @NivelAlarmaEvento, " +
                                   "descripcion_evento = @DescripcionEvento WHERE ID_EVENTO = @IdEvento";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEvento", evento.IdEvento);
                        comando.Parameters.AddWithValue("@IdUsuario", evento.IdUsuario);
                        comando.Parameters.AddWithValue("@IdSensor", evento.IdSensor);
                        comando.Parameters.AddWithValue("@FechaEvento", evento.FechaEvento);
                        comando.Parameters.AddWithValue("@TipoEvento", evento.TipoEvento);
                        comando.Parameters.AddWithValue("@NivelAlarmaEvento", evento.NivelAlarmaEvento);
                        comando.Parameters.AddWithValue("@DescripcionEvento", evento.DescripcionEvento);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al actualizar el evento.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al actualizar el evento.");
                return "Error";
            }
        }

        public static string Eliminar(int idEvento)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "DELETE FROM eventos WHERE ID_EVENTO = @IdEvento";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEvento", idEvento);
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
                ControlErrores.ManejarErrorSql(ex, "Error al eliminar el evento.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al eliminar el evento.");
                return "Error";
            }
        }

        public static eventosModel ObtenerPorId(int idEvento)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM eventos WHERE ID_EVENTO = @IdEvento";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEvento", idEvento);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new eventosModel
                                {
                                    IdEvento = Convert.ToInt32(lector["ID_EVENTO"]),
                                    IdUsuario = Convert.ToInt32(lector["ID_USUARIO"]),
                                    IdSensor = Convert.ToInt32(lector["ID_SENSOR"]),
                                    FechaEvento = Convert.ToDateTime(lector["fecha_evento"]),
                                    TipoEvento = lector["tipo_evento"].ToString(),
                                    NivelAlarmaEvento = lector["nivel_alarma_evento"].ToString(),
                                    DescripcionEvento = lector["descripcion_evento"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al obtener el evento.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al obtener el evento.");
            }
            return null;
        }

        public static List<eventosModel> ObtenerTodos()
        {
            var eventos = new List<eventosModel>();

            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM eventos";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                eventos.Add(new eventosModel
                                {
                                    IdEvento = Convert.ToInt32(lector["ID_EVENTO"]),
                                    IdUsuario = Convert.ToInt32(lector["ID_USUARIO"]),
                                    IdSensor = Convert.ToInt32(lector["ID_SENSOR"]),
                                    FechaEvento = Convert.ToDateTime(lector["fecha_evento"]),
                                    TipoEvento = lector["tipo_evento"].ToString(),
                                    NivelAlarmaEvento = lector["nivel_alarma_evento"].ToString(),
                                    DescripcionEvento = lector["descripcion_evento"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ControlErrores.ManejarErrorSql(ex, "Error al obtener la lista de eventos.");
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex, "Error al obtener la lista de eventos.");
            }

            return eventos;
        }
    }
}
