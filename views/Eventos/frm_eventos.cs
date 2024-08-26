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

namespace SistemaDeAlarma.views.Eventos
{
    public partial class frm_eventos : Form
    {
        private eventosController eventosController;
        public frm_eventos()
        {
            InitializeComponent();
            eventosController = new eventosController();
        }

        private void frm_eventos_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarSensores();
            CargarEventos();
        }

        private void CargarEventos()
        {
            var eventos = eventosController.ObtenerTodosLosEventos();
            lst_Eventos.DataSource = eventos;
            lst_Eventos.DisplayMember = "TipoEvento";
            lst_Eventos.ValueMember = "IdEvento";
        }

        private void CargarUsuarios()
        {
            var usuarios = eventosController.ObtenerTodosLosUsuarios();
            cmb_Usuario.DataSource = usuarios;
            cmb_Usuario.DisplayMember = "NombreCompleto";
            cmb_Usuario.ValueMember = "IdUsuario";
            cmb_Usuario.SelectedIndex = -1;
        }

        private void CargarSensores()
        {
            var sensores = eventosController.ObtenerTodosLosSensores();
            cmb_Sensor.DataSource = sensores;
            cmb_Sensor.DisplayMember = "IdSensor";
            cmb_Sensor.ValueMember = "IdSensor";
            cmb_Sensor.SelectedIndex = -1;
        }

        private bool ValidarCampos(params Control[] controles)
        {
            foreach (var control in controles)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace((control as TextBox).Text))
                {
                    MessageBox.Show("Complete la información", "Error", MessageBoxButtons.OK);
                    return false;
                }
                if (control is ComboBox && (control as ComboBox).SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una opción", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_Tipo, txt_Nivel, txt_Descripcion, cmb_Usuario, cmb_Sensor))
                {
                    return;
                }

                var evento = new eventosModel
                {
                    IdUsuario = Convert.ToInt32(cmb_Usuario.SelectedValue),
                    IdSensor = Convert.ToInt32(cmb_Sensor.SelectedValue),
                    FechaEvento = dtp_Fecha.Value,
                    TipoEvento = txt_Tipo.Text,
                    NivelAlarmaEvento = txt_Nivel.Text,
                    DescripcionEvento = txt_Descripcion.Text
                };

                var insertado = eventosController.InsertarEvento(evento);

                if (insertado != null)
                {
                    CargarEventos();
                    ControlErrores.ManejarInsertar();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el evento.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar agregar el evento: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Tipo.Clear();
            txt_Nivel.Clear();
            txt_Descripcion.Clear();
            cmb_Usuario.SelectedIndex = -1;
            cmb_Sensor.SelectedIndex = -1;
            dtp_Fecha.Value = DateTime.Now;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_Tipo, txt_Nivel, txt_Descripcion, cmb_Usuario, cmb_Sensor))
                {
                    return;
                }

                var evento = new eventosModel
                {
                    IdEvento = Convert.ToInt32(lst_Eventos.SelectedValue),
                    IdUsuario = Convert.ToInt32(cmb_Usuario.SelectedValue),
                    IdSensor = Convert.ToInt32(cmb_Sensor.SelectedValue),
                    FechaEvento = dtp_Fecha.Value,
                    TipoEvento = txt_Tipo.Text,
                    NivelAlarmaEvento = txt_Nivel.Text,
                    DescripcionEvento = txt_Descripcion.Text
                };

                var resultado = eventosController.ActualizarEvento(evento);

                if (resultado == "OK")
                {
                    CargarEventos();
                    ControlErrores.ManejarActualizar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el evento.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el evento: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_Eventos.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un evento de la lista para eliminar.", "Error", MessageBoxButtons.OK);
                    return;
                }

                var idEvento = Convert.ToInt32(lst_Eventos.SelectedValue);
                var resultado = eventosController.EliminarEvento(idEvento);

                if (resultado == "OK")
                {
                    CargarEventos();
                    ControlErrores.ManejarEliminar();
                }
                else if (resultado == "Error de restricción de clave foránea")
                {
                    MessageBox.Show("No se puede eliminar el evento debido a restricciones de clave foránea en la base de datos.", "Error de Eliminación", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el evento.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el evento: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void lst_Eventos_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Eventos.SelectedValue != null)
            {
                var evento = eventosController.ObtenerEventoPorId(Convert.ToInt32(lst_Eventos.SelectedValue));
                if (evento != null)
                {
                    cmb_Usuario.SelectedValue = evento.IdUsuario;
                    cmb_Sensor.SelectedValue = evento.IdSensor;
                    dtp_Fecha.Value = evento.FechaEvento;
                    txt_Tipo.Text = evento.TipoEvento;
                    txt_Nivel.Text = evento.NivelAlarmaEvento;
                    txt_Descripcion.Text = evento.DescripcionEvento;
                }
                else
                {
                    MessageBox.Show("No se encontró el evento seleccionado.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ítem de la lista.", "Error", MessageBoxButtons.OK);
            }
        }
    }
    
}
