using SistemaDeAlarma.config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlarma.views.Login
{
    public partial class frm_registroUsuario : Form
    {
        public frm_registroUsuario()
        {
            InitializeComponent();
        }

        private void lbl_FechaNaci_Click(object sender, EventArgs e)
        {

        }

        private void btn_siguiente_MouseEnter(object sender, EventArgs e)
        {
            btn_siguiente.ForeColor = Color.Peru;
        }

        private void btn_siguiente_MouseLeave(object sender, EventArgs e)
        {
            btn_siguiente.ForeColor = Color.SaddleBrown;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_apellido.Text) ||
                string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_rol.Text) ||
                string.IsNullOrWhiteSpace(txt_telefono.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK);
                return;
            }

            string insertQuery = "INSERT INTO usuarios (apellido_usuario, nombre_usuario, rol_usuario, telefono_usuario, email_usuario, fecha_nacimiento) " +
                                 "VALUES (@apellido, @nombre, @rol, @telefono, @correo, @fechaNacimiento)";

            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@apellido", txt_apellido.Text);
                    insertCmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    insertCmd.Parameters.AddWithValue("@rol", txt_rol.Text);
                    insertCmd.Parameters.AddWithValue("@telefono", txt_telefono.Text);
                    insertCmd.Parameters.AddWithValue("@correo", txt_email.Text);
                    insertCmd.Parameters.AddWithValue("@fechaNacimiento", dtp_fechanacimiento.Value);

                    try
                    {
                        insertCmd.ExecuteNonQuery();
                        frm_nuevaCuenta _frm_nuevacuenta = new frm_nuevaCuenta();
                        _frm_nuevacuenta.Show();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void frm_registroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
