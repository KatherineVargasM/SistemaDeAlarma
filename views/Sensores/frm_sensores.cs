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

namespace SistemaDeAlarma.views.Sensores
{
    public partial class frm_sensores : Form
    {
        private sensoresController sensoresController;
        private ubicacionesController ubicacionesController;

        public frm_sensores()
        {
            InitializeComponent();
            sensoresController = new sensoresController();
            ubicacionesController = new ubicacionesController();

        }

        private void frm_sensores_Load(object sender, EventArgs e)
        {
            CargarSensores();
            CargarUbicaciones();
        }
        private void CargarSensores()
        {
            var sensores = sensoresController.ObtenerTodosLosSensores();
            lst_Sensores.DataSource = sensores;
            lst_Sensores.DisplayMember = "IdSensor";
            lst_Sensores.ValueMember = "IdSensor";
        }
        private void CargarUbicaciones()
        {
            var ubicacionesController = new ubicacionesController();
            var ubicaciones = sensoresController.ObtenerTodosLosSensores();
            cmb_IdUbicacion.DataSource = ubicaciones;
            cmb_IdUbicacion.DisplayMember = "LugarUbicacion";
            cmb_IdUbicacion.ValueMember = "IdUbicacion";
            cmb_IdUbicacion.SelectedIndex = -1;
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
                if (!ValidarCampos(txt_Tipo, txt_Estado))
                {
                    return;
                }

                var sensor = new sensoresModel
                {
                    IdUbicacion = Convert.ToInt32(cmb_IdUbicacion.SelectedValue),
                    TipoSensor = txt_Tipo.Text,
                    FechaInstalacionSensor = dtp_FechaInstalacion.Value,
                    EstadoSensor = txt_Estado.Text
                };

                var insertado = sensoresController.InsertarSensor(sensor);

                if (insertado != null)
                {
                    CargarSensores();
                    ControlErrores.ManejarInsertar();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el sensor.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar agregar el sensor: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Tipo.Clear();
            txt_Estado.Clear();
            dtp_FechaInstalacion.Value = DateTime.Now;
            cmb_IdUbicacion.SelectedIndex = -1;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_Tipo, txt_Estado))
                {
                    return;
                }

                var sensor = new sensoresModel
                {
                    IdSensor = Convert.ToInt32(lst_Sensores.SelectedValue),
                    IdUbicacion = Convert.ToInt32(cmb_IdUbicacion.SelectedValue),
                    TipoSensor = txt_Tipo.Text,
                    FechaInstalacionSensor = dtp_FechaInstalacion.Value,
                    EstadoSensor = txt_Estado.Text
                };

                var resultado = sensoresController.ActualizarSensor(sensor);

                if (resultado == "OK")
                {
                    CargarSensores();
                    ControlErrores.ManejarActualizar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el sensor.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el sensor: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_Sensores.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un sensor de la lista para eliminar.", "Error", MessageBoxButtons.OK);
                    return;
                }

                var idSensor = Convert.ToInt32(lst_Sensores.SelectedValue);
                var resultado = sensoresController.EliminarSensor(idSensor);

                if (resultado == "OK")
                {
                    CargarSensores();
                    ControlErrores.ManejarEliminar();
                }
                else if (resultado == "Error de restricción de clave foránea")
                {
                    MessageBox.Show("No se puede eliminar el sensor debido a restricciones de clave foránea en la base de datos.", "Error de Eliminación", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el sensor.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el sensor: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void lst_Sensores_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Sensores.SelectedValue != null)
            {
                var sensor = sensoresController.ObtenerSensorPorId(Convert.ToInt32(lst_Sensores.SelectedValue));
                if (sensor != null)
                {
                    txt_Tipo.Text = sensor.TipoSensor;
                    txt_Estado.Text = sensor.EstadoSensor;
                    dtp_FechaInstalacion.Value = sensor.FechaInstalacionSensor;
                    cmb_IdUbicacion.SelectedValue = sensor.IdUbicacion;
                }
                else
                {
                    MessageBox.Show("No se encontró el sensor seleccionado.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ítem de la lista.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
