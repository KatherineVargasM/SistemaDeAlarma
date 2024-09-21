using SistemaDeAlarma.config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlarma.views.Login
{
    public partial class frm_nuevaCuenta : Form
    {
        public frm_nuevaCuenta()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (txt_contrasenia.Text != txt_repitacontrasenia.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK);
                return;
            }

            string usuario = txt_usuario.Text;
            string contrasenia = txt_contrasenia.Text;

            if (!IsValidEmail(usuario))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (cmb_usuario.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un usuario.", "Error", MessageBoxButtons.OK);
                return;
            }

            int idUsuario = (int)cmb_usuario.SelectedValue;
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                SqlCommand checkUserCmd = new SqlCommand("SELECT COUNT(*) FROM login WHERE usuario_login = @usuario", conn);
                checkUserCmd.Parameters.AddWithValue("@usuario", usuario);

                int userExists = (int)checkUserCmd.ExecuteScalar();

                if (userExists > 0)
                {
                    MessageBox.Show("El usuario ya existe.", "Error", MessageBoxButtons.OK);
                    return;
                }

                string insertQuery = "INSERT INTO login (usuario_login, contrasenia_login, ID_Usuario) VALUES (@usuario, @contrasenia, @idUsuario)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@usuario", usuario);
                insertCmd.Parameters.AddWithValue("@contrasenia", contrasenia);
                insertCmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                try
                {
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Cuenta creada con éxito.", "Éxito", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear la cuenta: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void frm_nuevaCuenta_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT ID_Usuario, apellido_usuario FROM Usuarios", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmb_usuario.DataSource = dt;
                cmb_usuario.DisplayMember = "apellido_usuario";
                cmb_usuario.ValueMember = "ID_Usuario";
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
