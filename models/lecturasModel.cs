﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SistemaDeAlarma.config;

namespace SistemaDeAlarma.models
{
    public class lecturasModel
    {
        public int ID_LECTURA { get; set; }
        public DateTime FechaLectura { get; set; }
        public string espesor_humo { get; set; }
        public string abundancia_humo { get; set; }


        public override string ToString()
        {
            return FechaLectura.ToString("g");
        }

        public static lecturasModel Insertar(lecturasModel lectura)
        {
            using (var connection = ConexionBDD.GetConnection())
            {
                lectura.FechaLectura = DateTime.Now;

                var query = "INSERT INTO Lecturas (espesor_humo, abundancia_humo, fecha_lectura) OUTPUT INSERTED.ID_LECTURA VALUES (@espesor_humo, @abundancia_humo, @fecha_lectura)";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@espesor_humo", lectura.espesor_humo);
                    cmd.Parameters.AddWithValue("@abundancia_humo", lectura.abundancia_humo);
                    cmd.Parameters.AddWithValue("@fecha_lectura", lectura.FechaLectura);

                    lectura.ID_LECTURA = (int)cmd.ExecuteScalar();
                }
            }

            return lectura;
        }

        public static string Actualizar(lecturasModel lectura)
        {
            using (var connection = ConexionBDD.GetConnection())
            {
                var query = "UPDATE Lecturas SET espesor_humo = @espesor_humo, abundancia_humo = @abundancia_humo, fecha_lectura = @fecha_lectura WHERE ID_LECTURA = @ID_LECTURA";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_LECTURA", lectura.ID_LECTURA);
                    cmd.Parameters.AddWithValue("@espesor_humo", lectura.espesor_humo);
                    cmd.Parameters.AddWithValue("@abundancia_humo", lectura.abundancia_humo);
                    cmd.Parameters.AddWithValue("@fecha_lectura", lectura.FechaLectura);

                    var rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "OK" : "Error";
                }
            }
        }

        public static string Eliminar(int idLectura)
        {
            using (var connection = ConexionBDD.GetConnection())
            {
                var query = "DELETE FROM Lecturas WHERE ID_LECTURA = @ID_LECTURA";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_LECTURA", idLectura);

                    var rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "OK" : "Error";
                }
            }
        }

        public static lecturasModel ObtenerPorId(int idLectura)
        {
            lecturasModel lectura = null;
            using (var connection = ConexionBDD.GetConnection())
            {
                var query = "SELECT ID_LECTURA, espesor_humo, abundancia_humo, fecha_lectura FROM Lecturas WHERE ID_LECTURA = @ID_LECTURA";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_LECTURA", idLectura);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lectura = new lecturasModel
                            {
                                ID_LECTURA = (int)reader["ID_LECTURA"],
                                espesor_humo = reader["espesor_humo"].ToString(),
                                abundancia_humo = reader["abundancia_humo"].ToString(),
                                FechaLectura = Convert.ToDateTime(reader["fecha_lectura"])
                            };
                        }
                    }
                }
            }
            return lectura;
        }

        public static List<lecturasModel> ObtenerTodos()
        {
            var lecturas = new List<lecturasModel>();
            using (var connection = ConexionBDD.GetConnection())
            {
                var query = "SELECT ID_LECTURA, espesor_humo, abundancia_humo, fecha_lectura FROM Lecturas";

                using (var cmd = new SqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var lectura = new lecturasModel
                            {
                                ID_LECTURA = (int)reader["ID_LECTURA"],
                                espesor_humo = reader["espesor_humo"].ToString(),
                                abundancia_humo = reader["abundancia_humo"].ToString(),
                                FechaLectura = Convert.ToDateTime(reader["fecha_lectura"])
                            };
                            lecturas.Add(lectura);
                        }
                    }
                }
            }
            return lecturas;
        }
    }
}


