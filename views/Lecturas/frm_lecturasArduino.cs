using SistemaDeAlarma.config;
using System;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Windows.Forms;

namespace SistemaDeAlarma
{
    public partial class frm_lecturasArduino : Form
    {
        private SerialPort puertoSerial;

        public frm_lecturasArduino()
        {
            InitializeComponent();
            //InicializarPuertoSerial();
        }

        private void InicializarPuertoSerial()
        {
            try
            {
                puertoSerial = new SerialPort("COM3", 9600);
                puertoSerial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                puertoSerial.Open();

                lbl_EstadoSerial.Text = "Conectado";
                lbl_EstadoSerial.ForeColor = System.Drawing.Color.Green;

                AppendTextToTextBox("Conexión serial abierta. Esperando datos...\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el puerto serial: {ex.Message}", "Error", MessageBoxButtons.OK);
                lbl_EstadoSerial.Text = "Desconectado";
                lbl_EstadoSerial.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string lecturaSensor = puertoSerial.ReadLine().Trim();
                this.Invoke(new Action(() =>
                {
                    AppendTextToTextBox($"Dato recibido: {lecturaSensor}\r\n");
                }));

                if (int.TryParse(lecturaSensor, out int valor))
                {
                    InsertarLecturaEnSQL(valor);
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        AppendTextToTextBox("Lectura inválida. No se insertará en la base de datos.\r\n");
                    }));
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    AppendTextToTextBox($"Error al procesar los datos recibidos: {ex.Message}\r\n");
                }));
            }
        }

        private void InsertarLecturaEnSQL(int lectura)
        {
            try
            {
                using (SqlConnection conexion = ConexionBDD.GetConnection())
                {
                    double porcentaje = (lectura / 500.0) * 100;
                    string espesorHumo = $"{porcentaje:0.##}%";

                    string query = "INSERT INTO lecturas (espesor_humo, abundancia_humo) VALUES (@espesor, @abundancia)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@espesor", espesorHumo);
                        comando.Parameters.AddWithValue("@abundancia", (lectura > 200) ? "Alta" : "Baja");
                        comando.ExecuteNonQuery();
                    }

                    this.Invoke(new Action(() =>
                    {
                        AppendTextToTextBox("Dato insertado en SQL Server.\r\n");
                    }));
                }
            }
            catch (SqlException ex)
            {
                this.Invoke(new Action(() =>
                {
                    AppendTextToTextBox($"Error al insertar en la base de datos: {ex.Message}\r\n");
                }));
            }
        }


        private void AppendTextToTextBox(string text)
        {
            txtLogs.AppendText(text);
        }

        private void frm_lecturasArduino_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (puertoSerial != null && puertoSerial.IsOpen)
            {
                puertoSerial.Close();
                AppendTextToTextBox("Puerto serial cerrado.\r\n");
                lbl_EstadoSerial.Text = "Desconectado";
                lbl_EstadoSerial.ForeColor = System.Drawing.Color.Red;
            }
            this.Close();
        }
    }
}


