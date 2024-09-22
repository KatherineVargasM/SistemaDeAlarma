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

namespace SistemaDeAlarma.views.Lecturas
{
    public partial class frm_lecturas : Form
    {
        private lecturasController lecturasController;

        public frm_lecturas()
        {
            InitializeComponent();
            lecturasController = new lecturasController();
        }

        private void frm_lecturas_Load(object sender, EventArgs e)
        {
            CargarLecturas();
        }

        private void CargarLecturas()
        {
            var lecturas = lecturasController.ObtenerTodasLasLecturas();
            lst_lecturas.DataSource = lecturas;
            lst_lecturas.DisplayMember = "FechaLectura";
            lst_lecturas.ValueMember = "ID_LECTURA";
            lst_lecturas.SelectedIndex = -1;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_espesor.Text) || string.IsNullOrWhiteSpace(txt_abundancia.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                var lectura = new lecturasModel
                {
                    espesor_humo = txt_espesor.Text,
                    abundancia_humo = txt_abundancia.Text
                };

                var insertado = lecturasController.InsertarLectura(lectura);

                if (insertado != null)
                {
                    MessageBox.Show("Lectura registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLecturas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar la lectura.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                var lectura = new lecturasModel
                {
                    ID_LECTURA = Convert.ToInt32(lst_lecturas.SelectedValue),
                    espesor_humo = txt_espesor.Text,
                    abundancia_humo = txt_abundancia.Text
                };

                var resultado = lecturasController.ActualizarLectura(lectura);

                if (resultado == "OK")
                {
                    MessageBox.Show("Lectura actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLecturas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la lectura.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_espesor.Clear();
            txt_abundancia.Clear();
            lst_lecturas.ClearSelected();
        }

        private void lst_lecturas_DoubleClick(object sender, EventArgs e)
        {
            if (lst_lecturas.SelectedValue != null)
            {
                var lectura = lecturasController.ObtenerLecturaPorId(Convert.ToInt32(lst_lecturas.SelectedValue));
                if (lectura != null)
                {
                    txt_espesor.Text = lectura.espesor_humo;
                    txt_abundancia.Text = lectura.abundancia_humo;
                }
                else
                {
                    MessageBox.Show("No se encontró la lectura seleccionada.", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
