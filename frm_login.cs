using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using SistemaDeAlarma.views.Dashboard;
using SistemaDeAlarma.config;
using SistemaDeAlarma.views.Login;
using SistemaDeAlarma.views.Lecturas;

namespace SistemaDeAlarma
{
    public partial class frm_login : Form
    {

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuario.Text.Trim();
            string contrasena = txt_Contrasenia.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Información requerida", MessageBoxButtons.OK);
                BlanquearCajasDeTexto();
                return;
            }

            if (!ValidarEmail(usuario))
            {
                MessageBox.Show("El correo electrónico no posee el formato correcto.", "Formato inválido", MessageBoxButtons.OK);
                BlanquearCajasDeTexto();
                return;
            }

            if (AutenticarDesdeBaseDeDatos(usuario, contrasena))
            {
                RedirigirAlDashboard();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos.", "Error", MessageBoxButtons.OK);
                BlanquearCajasDeTexto();
            }
        }


        private bool AutenticarDesdeBaseDeDatos(string usuario, string contrasena)
        {
            bool autenticado = false;

            try
            {
                using (SqlConnection connection = ConexionBDD.GetConnection())
                {
                    string query = @"
                SELECT u.ID_USUARIO, u.nombre_usuario, u.rol_usuario, l.usuario_login, l.contrasenia_login 
                FROM login l
                INNER JOIN usuarios u ON l.ID_USUARIO = u.ID_USUARIO
                WHERE l.usuario_login = @usuario AND l.contrasenia_login = @contrasena";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ConfiguracionProyecto.IDUsuario = Convert.ToInt32(reader["ID_USUARIO"]);
                                ConfiguracionProyecto.NombreUsuario = reader["nombre_usuario"].ToString();
                                ConfiguracionProyecto.Rol = reader["rol_usuario"].ToString();
                                ConfiguracionProyecto.Email = reader["usuario_login"].ToString();
                                autenticado = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK);
                autenticado = false;
            }

            return autenticado;
        }


        private void RedirigirAlDashboard()
        {
            if (ConfiguracionProyecto.Rol == "Residente")
            {
                DashboardResidente dashboardAdmin = new DashboardResidente();
                dashboardAdmin.Show();
            }
            else if (ConfiguracionProyecto.Rol == "Administrador")
            {

                DashboardAdmin dashboardResidente = new DashboardAdmin();
                dashboardResidente.Show();
            }
            else if (ConfiguracionProyecto.Rol == "GuardiaSeguridad")
            {
                DashboardGuardia dashboardGuardia = new DashboardGuardia();
                dashboardGuardia.Show();
            }
            else
            {
                MessageBox.Show("Rol de usuario no reconocido: " + ConfiguracionProyecto.Rol, "Error", MessageBoxButtons.OK);
            }

            this.Hide();
        }


        public bool ValidarEmail(string email)
        {
            string validacion = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, validacion);
        }

        private void BlanquearCajasDeTexto()
        {
            txt_Usuario.Text = "";
            txt_Contrasenia.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DashboardAdmin dashboard = new DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frm_loginContrasenia _logincontrasenia = new frm_loginContrasenia();
            _logincontrasenia.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frm_registroUsuario _registrousuario = new frm_registroUsuario();
            _registrousuario.Show();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Peru;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.SaddleBrown;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Peru;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.SaddleBrown;
        }

        private void btn_Aceptar_MouseEnter(object sender, EventArgs e)
        {
            btn_Aceptar.ForeColor = Color.Peru;
        }

        private void btn_Aceptar_MouseLeave(object sender, EventArgs e)
        {
            btn_Aceptar.ForeColor= Color.SaddleBrown;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DashboardResidente dashboardResidente = new DashboardResidente();
            dashboardResidente.Show();
        }
    }
}
