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

namespace SistemaDeAlarma
{
    public partial class frm_login : Form
    {
        private Dictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "juancarlospacas@gmail.com", "12345" },
            { "luisrodrigoparrales@gmail.com", "12345" }
        };

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "" || txt_Contrasenia.Text == "")
            {
                MessageBox.Show("Llene las cajas de texto con la informacion requerida");
                ControlTamanioFormulario();
                BlanquearCajasDeTexto();
                return;
            }

            if (ValidarEmail(txt_Usuario.Text))
            {
                if (usuarios.ContainsKey(txt_Usuario.Text) && usuarios[txt_Usuario.Text] == txt_Contrasenia.Text)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    if (AutenticarDesdeBaseDeDatos(txt_Usuario.Text, txt_Contrasenia.Text))
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario o la contraseña son incorrectos.");
                        ControlTamanioFormulario();
                        BlanquearCajasDeTexto();
                    }
                }
            }
            else
            {
                MessageBox.Show("El correo electronico no posee el formato correcto.");
                ControlTamanioFormulario();
                BlanquearCajasDeTexto();
            }
        }

        private bool AutenticarDesdeBaseDeDatos(string usuario, string contrasenia)
        {
            bool autenticado = false;

            try
            {
                using (SqlConnection connection = ConexionBDD.GetConnection())
                {
                    string query = "SELECT COUNT(1) FROM LOGIN WHERE usuario_login = @usuario AND contrasenia_login = @contrasenia";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasenia", contrasenia);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            autenticado = true;
                        }
                        else
                        {
                            MessageBox.Show("El usuario o la contraseña no coinciden.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
            }

            return autenticado;
        }


        public bool ValidarEmail(string email)
        {
            string validacion = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, validacion);
        }

        public void ControlTamanioFormulario()
        {
            decimal alto = frm_login.ActiveForm.Height;
            decimal ancho = frm_login.ActiveForm.Width;
        }

        private void BlanquearCajasDeTexto()
        {
            txt_Usuario.Text = "";
            txt_Contrasenia.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
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
    }
}
