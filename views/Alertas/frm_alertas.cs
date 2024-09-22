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

namespace SistemaDeAlarma.views.Alertas
{
    public partial class frm_alertas : Form
    {
        private alertasController alertasController;
        private lecturasController lecturasController;

        public frm_alertas()
        {
            InitializeComponent();
            alertasController = new alertasController();
            lecturasController = new lecturasController();
        }

        private void frm_alertas_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarSensores();
            CargarAlertas();
            CargarLecturas();
        }

        private void CargarAlertas()
        {
            var alertas = alertasController.ObtenerTodasLasAlertas();
            lst_Alertas.DataSource = alertas;
            lst_Alertas.DisplayMember = "FechaAlerta";
            lst_Alertas.ValueMember = "IdAlerta";
        }

        private void CargarUsuarios()
        {
            var usuarios = alertasController.ObtenerTodosLosUsuarios();
            cmb_Usuario.DataSource = usuarios;
            cmb_Usuario.DisplayMember = "NombreCompleto";
            cmb_Usuario.ValueMember = "IdUsuario";
            cmb_Usuario.SelectedIndex = -1;
        }

        private void CargarSensores()
        {
            var sensores = alertasController.ObtenerTodosLosSensores();
            cmb_Sensor.DataSource = sensores;
            cmb_Sensor.DisplayMember = "LugarUbicacion";
            cmb_Sensor.ValueMember = "IdSensor";
            cmb_Sensor.SelectedIndex = -1;
        }

        private void CargarLecturas()
        {
            var lecturas = lecturasController.ObtenerTodasLasLecturas();
            cmb_Lecturas.DataSource = lecturas;
            cmb_Lecturas.DisplayMember = "FechaLectura";
            cmb_Lecturas.ValueMember = "ID_LECTURA";
            cmb_Lecturas.SelectedIndex = -1;
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

        private void lbl_Titulo_Click(object sender, EventArgs e)
        {
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_Tipo, txt_Nivel, txt_Descripcion, cmb_Usuario, cmb_Sensor, cmb_Lecturas))
                {
                    return;
                }

                var alerta = new alertasModel
                {
                    IdUsuario = Convert.ToInt32(cmb_Usuario.SelectedValue),
                    IdSensor = Convert.ToInt32(cmb_Sensor.SelectedValue),
                    IdLectura = Convert.ToInt32(cmb_Lecturas.SelectedValue),
                    FechaAlerta = dtp_Fecha.Value,
                    TipoAlerta = txt_Tipo.Text,
                    NivelAlarmaAlerta = txt_Nivel.Text,
                    DescripcionAlerta = txt_Descripcion.Text
                };

                var insertado = alertasController.InsertarAlerta(alerta);

                if (insertado != null)
                {
                    CargarAlertas();
                    ControlErrores.ManejarInsertar();
                    BlanquearCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar la alerta.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar agregar la alerta: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_Tipo, txt_Nivel, txt_Descripcion, cmb_Usuario, cmb_Sensor, cmb_Lecturas))
                {
                    return;
                }

                var alerta = new alertasModel
                {
                    IdAlerta = Convert.ToInt32(lst_Alertas.SelectedValue),
                    IdUsuario = Convert.ToInt32(cmb_Usuario.SelectedValue),
                    IdSensor = Convert.ToInt32(cmb_Sensor.SelectedValue),
                    IdLectura = Convert.ToInt32(cmb_Lecturas.SelectedValue),
                    FechaAlerta = dtp_Fecha.Value,
                    TipoAlerta = txt_Tipo.Text,
                    NivelAlarmaAlerta = txt_Nivel.Text,
                    DescripcionAlerta = txt_Descripcion.Text
                };

                var actualizado = alertasController.ActualizarAlerta(alerta);

                if (actualizado)
                {
                    CargarAlertas();
                    ControlErrores.ManejarActualizar();
                    BlanquearCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la alerta.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar modificar la alerta: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }


        private void lst_Alertas_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Alertas.SelectedValue != null)
            {
                var alerta = alertasController.ObtenerAlertaPorId(Convert.ToInt32(lst_Alertas.SelectedValue));
                if (alerta != null)
                {
                    cmb_Usuario.SelectedValue = alerta.IdUsuario;
                    cmb_Sensor.SelectedValue = alerta.IdSensor;
                    cmb_Lecturas.SelectedValue = alerta.IdLectura;
                    dtp_Fecha.Value = alerta.FechaAlerta;
                    txt_Tipo.Text = alerta.TipoAlerta;
                    txt_Nivel.Text = alerta.NivelAlarmaAlerta;
                    txt_Descripcion.Text = alerta.DescripcionAlerta;
                }
                else
                {
                    MessageBox.Show("No se encontró la alerta seleccionada.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ítem de la lista.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            BlanquearCampos();
        }

        private void BlanquearCampos()
        {
            txt_Tipo.Clear();
            txt_Nivel.Clear();
            txt_Descripcion.Clear();
            cmb_Usuario.SelectedIndex = -1;
            cmb_Sensor.SelectedIndex = -1;
            cmb_Lecturas.SelectedIndex = -1;
            dtp_Fecha.Value = DateTime.Now;
        }
    }
    
}

