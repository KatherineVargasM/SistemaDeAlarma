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

namespace SistemaDeAlarma.views.Ubicaciones
{
    public partial class frm_ubicaciones : Form
    {
        private ubicacionesController ubicacionesController;
        public frm_ubicaciones()
        {
            InitializeComponent();
            ubicacionesController = new ubicacionesController();
        }

        private void frm_ubicaciones_Load(object sender, EventArgs e)
        {
            CargarUbicaciones();
        }

        private void CargarUbicaciones()
        {
            var ubicaciones = ubicacionesController.ObtenerTodasLasUbicaciones();
            lst_Ubicaciones.DataSource = ubicaciones;
            lst_Ubicaciones.DisplayMember = "LugarUbicacion";
            lst_Ubicaciones.ValueMember = "IdUbicacion";
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

        private void lst_Ubicaciones_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Ubicaciones.SelectedValue != null)
            {
                var ubicacion = ubicacionesController.ObtenerUbicacionPorId(Convert.ToInt32(lst_Ubicaciones.SelectedValue));
                if (ubicacion != null)
                {
                    txt_Lugar.Text = ubicacion.LugarUbicacion;
                    txt_Descripcion.Text = ubicacion.DescripcionUbicacion;
                }
                else
                {
                    MessageBox.Show("No se encontró la ubicación seleccionada.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ítem de la lista.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Grabar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_Lugar, txt_Descripcion))
                {
                    return;
                }

                var ubicacion = new ubicacionesModel
                {
                    LugarUbicacion = txt_Lugar.Text,
                    DescripcionUbicacion = txt_Descripcion.Text
                };

                var insertada = ubicacionesController.InsertarUbicacion(ubicacion);

                if (insertada != null)
                {
                    CargarUbicaciones();
                    ControlErrores.ManejarInsertar();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar la ubicación.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar agregar la ubicación: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Modificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_Lugar, txt_Descripcion))
                {
                    return;
                }

                var ubicacion = new ubicacionesModel
                {
                    IdUbicacion = Convert.ToInt32(lst_Ubicaciones.SelectedValue),
                    LugarUbicacion = txt_Lugar.Text,
                    DescripcionUbicacion = txt_Descripcion.Text
                };

                var resultado = ubicacionesController.ActualizarUbicacion(ubicacion);

                if (resultado == "OK")
                {
                    CargarUbicaciones();
                    ControlErrores.ManejarActualizar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la ubicación.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la ubicación: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            txt_Lugar.Clear();
            txt_Descripcion.Clear();
        }
    }
}
