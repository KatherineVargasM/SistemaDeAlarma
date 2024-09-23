using SistemaDeAlarma.views.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeAlarma.views.Ubicaciones;
using SistemaDeAlarma.views.Sensores;
using SistemaDeAlarma.views.Lecturas;
using SistemaDeAlarma.views.Alertas;
using SistemaDeAlarma.controller;
using System.Media;

namespace SistemaDeAlarma.views.Dashboard
{
    public partial class DashboardGuardia : Form
    {
        private SoundPlayer soundPlayer;
        private sensoresController sensoresController = new sensoresController();

        public DashboardGuardia()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("Resources/Y2meta.wav");
        }

        private void DashboardGuardia_Load(object sender, EventArgs e)
        {
            centrarimagen();
        }

        public void centrarimagen()
        {
            int alto = this.ClientSize.Height;
            int ancho = this.ClientSize.Width;


            picture.Left = (ancho - picture.Width) / 2;
            picture.Top = (alto - picture.Height) / 2;
        }

        private void DashboardGuardia_SizeChanged(object sender, EventArgs e)
        {

        }

        private void reporteAleryasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reporteAlertas _reporteAlertas = new frm_reporteAlertas();
            _reporteAlertas.Show();
        }

        private void lISTADEUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listaUsuarios _listaUsuarios = new frm_listaUsuarios();
            _listaUsuarios.Show();
        }

        private void reporteDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reporteUsuarios _reporteUsuarios = new frm_reporteUsuarios();
            _reporteUsuarios.Show();
        }

        private void listaSensoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listaSensores _listaSensores = new frm_listaSensores();
            _listaSensores.Show();
        }

        private void reporteSensoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reporteSensores _reporteSensores = new frm_reporteSensores();
            _reporteSensores.Show();
        }

        private void listaUbicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listaUbicaciones _listaUbicaciones = new frm_listaUbicaciones();
            _listaUbicaciones.Show();
        }

        private void reporteUbicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reporteUbicaciones _reporteUbicaciones = new frm_reporteUbicaciones();
            _reporteUbicaciones.Show();
        }

        private void gestionarAlertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_alertas _Alertas = new frm_alertas();
            _Alertas.ShowDialog();
        }

        private void listaDeAlertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listaAlertas _listaAlertas = new frm_listaAlertas();
            _listaAlertas.Show();
        }

        private void lecturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeLecturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listaLecturas _listaLecturas = new frm_listaLecturas();
            _listaLecturas.Show();
        }

        private void reporteDeLecturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reporteLecturas _reporteLecturas = new frm_reporteLecturas();
            _reporteLecturas.Show();
        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarNotificacionHumo();
        }

        private void MostrarNotificacionHumo()
        {
            soundPlayer.PlayLooping();
            var sensores = sensoresController.ObtenerTodosLosSensores();

            if (sensores != null && sensores.Count > 0)
            {
                Random rand = new Random();
                var sensorAleatorio = sensores[rand.Next(sensores.Count)];
                ubicacionesController ubicacionesController = new ubicacionesController();
                var ubicacion = ubicacionesController.ObtenerUbicacionPorId(sensorAleatorio.IdUbicacion);
                string mensaje = $"¡Se está detectando humo en este momento!\n" +
                                 $"Se encendió el sensor: {sensorAleatorio.IdSensor}.\n" +
                                 $"Ubicación: {ubicacion.LugarUbicacion}.\n" +
                                 "En caso de emergencia, llame al 911.\n" +
                                 "Por favor, evacue el área inmediatamente.\n" +
                                 "Verifique que todos estén a salvo.";

                DialogResult result = MessageBox.Show(mensaje, "ALERTA DE HUMO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    soundPlayer.Stop();
                }
            }
            else
            {
                MessageBox.Show("No hay sensores disponibles para mostrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }
    }
}
