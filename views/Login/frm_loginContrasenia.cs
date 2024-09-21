using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaDeAlarma.controller;
using SistemaDeAlarma.models;
using SistemaDeAlarma.config;

namespace SistemaDeAlarma.views.Login
{
    public partial class frm_loginContrasenia : Form
    {
        public frm_loginContrasenia()
        {
            InitializeComponent();
        }

        private void frm_loginContrasenia_Load(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string contrasenaActual = txt_contrasenia.Text;
            string nuevaContrasena = txt_contrasenianueva.Text;
            string confirmarContrasena = txt_confirmarcontrasenia.Text;

            if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            if (VerificarContrasenia(usuario, contrasenaActual))
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cambiar la contraseña?", "Confirmación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    CambiarContrasenia(usuario, nuevaContrasena);
                    MessageBox.Show("Contraseña cambiada con éxito.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Se ha cancelado la operación.");
                }
            }
            else
            {
                MessageBox.Show("La contraseña actual es incorrecta.");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_contrasenia.Clear();
            txt_contrasenianueva.Clear();
            txt_confirmarcontrasenia.Clear();
        }


        private bool VerificarContrasenia(string usuario, string contrasena)
        {
            bool esValido = false;

            using (SqlConnection connection = ConexionBDD.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM login WHERE usuario_login = @usuario AND contrasenia_login = @contrasena";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@contrasena", contrasena);

                int count = (int)command.ExecuteScalar();
                esValido = count > 0;
            }

            return esValido;

        }

        private void CambiarContrasenia(string usuario, string nuevaContrasena)
        {
            using (SqlConnection connection = ConexionBDD.GetConnection())
            {
                string query = "UPDATE login SET contrasenia_login = @nuevaContrasena WHERE usuario_login = @usuario";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nuevaContrasena", nuevaContrasena);
                command.Parameters.AddWithValue("@usuario", usuario);

                command.ExecuteNonQuery();
            }
        }
    }
}
