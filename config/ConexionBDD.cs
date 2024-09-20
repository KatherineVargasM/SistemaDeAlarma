using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

namespace SistemaDeAlarma.config
{
    internal class ConexionBDD
    {
        private static readonly string connectionString;

        static ConexionBDD()
        {
            connectionString = "Server=.;database=SistemaAlarmaHumo;uid=sa;pwd=corpad17k";
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                throw;
            }
        }
    }
}
