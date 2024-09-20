using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SistemaDeAlarma.views.Dashboard;

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
                lbl_Mensajes.Text = "Llene las cajas de texto con la informacion requerida";
                lbl_Mensajes.Visible = true;
                ControlTamanioFormulario();
                BlanquearCajasDeTexto();
                return;
            }

            if (ValidarEmail(txt_Usuario.Text))
            {
                if(usuarios.ContainsKey(txt_Usuario.Text) && usuarios[txt_Usuario.Text] == txt_Contrasenia.Text)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    lbl_Mensajes.Text = "";
                    lbl_Mensajes.Visible = false;
                    this.Hide();
                }
                else
                {
                    lbl_Mensajes.Text = "El usuario o la contraseña son incorrectos.";
                    lbl_Mensajes.Visible = true;
                    ControlTamanioFormulario();
                    BlanquearCajasDeTexto();
                }
            }
            else
            {
                lbl_Mensajes.Text = "El correo electronico no posee el formato correcto.";
                lbl_Mensajes.Visible = true;
                ControlTamanioFormulario();
                BlanquearCajasDeTexto();
            }
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
        }
    }
}
