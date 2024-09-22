using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeAlarma.controller;
using SistemaDeAlarma.models;
using SistemaDeAlarma.config;

namespace SistemaDeAlarma.views.Usuarios
{
    public partial class frm_usuarios : Form
    {
        private usuariosController usuariosController;

        public frm_usuarios()
        {
            InitializeComponent();
            usuariosController = new usuariosController();
        }

        private void frm_usuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            var usuarios = usuariosController.ObtenerTodosLosUsuarios();
            lst_Usuarios.DataSource = usuarios;
            lst_Usuarios.DisplayMember = "NombreCompleto";
            lst_Usuarios.ValueMember = "IdUsuario";
        }

        private bool ValidarCampos(params TextBox[] cajasDeTexto)
        {
            foreach (var caja in cajasDeTexto)
            {
                if (string.IsNullOrWhiteSpace(caja.Text))
                {
                    MessageBox.Show("Complete la información", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }
        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_Apellido, txt_Nombre, txt_Rol, txt_Telefono, txt_Email))
                {
                    return;
                }

                var usuario = new usuariosModel
                {
                    Apellido = txt_Apellido.Text,
                    Nombre = txt_Nombre.Text,
                    Rol = txt_Rol.Text,
                    Telefono = txt_Telefono.Text,
                    Email = txt_Email.Text,
                    FechaNacimiento = dtp_FechaNacimiento.Value
                };

                var insertado = usuariosController.InsertarUsuario(usuario);

                if (insertado != null)
                {
                    CargarUsuarios();
                    ControlErrores.ManejarInsertar();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el usuario.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar agregar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Apellido.Clear();
            txt_Nombre.Clear();
            txt_Rol.Clear();
            txt_Telefono.Clear();
            txt_Email.Clear();
            dtp_FechaNacimiento.Value = DateTime.Now;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_Apellido, txt_Nombre, txt_Rol, txt_Telefono, txt_Email))
                {
                    return;
                }

                var usuario = new usuariosModel
                {
                    IdUsuario = Convert.ToInt32(lst_Usuarios.SelectedValue),
                    Apellido = txt_Apellido.Text,
                    Nombre = txt_Nombre.Text,
                    Rol = txt_Rol.Text,
                    Telefono = txt_Telefono.Text,
                    Email = txt_Email.Text,
                    FechaNacimiento = dtp_FechaNacimiento.Value
                };

                var resultado = usuariosController.ActualizarUsuario(usuario);

                if (resultado == "OK")
                {
                    CargarUsuarios();
                    ControlErrores.ManejarActualizar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }


        private void lst_Usuarios_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Usuarios.SelectedValue != null)
            {
                var usuario = usuariosController.ObtenerUsuarioPorId(Convert.ToInt32(lst_Usuarios.SelectedValue));
                if (usuario != null)
                {
                    txt_Apellido.Text = usuario.Apellido;
                    txt_Nombre.Text = usuario.Nombre;
                    txt_Rol.Text = usuario.Rol;
                    txt_Telefono.Text = usuario.Telefono;
                    txt_Email.Text = usuario.Email;
                    dtp_FechaNacimiento.Value = usuario.FechaNacimiento;
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario seleccionado.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ítem de la lista.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
