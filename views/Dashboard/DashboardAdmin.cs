using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeAlarma.views.Usuarios;
using SistemaDeAlarma.views.Ubicaciones;
using SistemaDeAlarma.views.Sensores;
using SistemaDeAlarma.views.Lecturas;
using SistemaDeAlarma.views.Alertas;
using SistemaDeAlarma.config;
using System.Data.SqlClient;
using System.Media;
using SistemaDeAlarma.controller;

namespace SistemaDeAlarma.views.Dashboard
{

    public partial class DashboardAdmin : Form
    {
        private SoundPlayer soundPlayer;
        private sensoresController sensoresController = new sensoresController();


        public DashboardAdmin()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("Resources/Y2meta.wav");
        }
        public void centrarimagen()
        {
            int alto = this.ClientSize.Height;
            int ancho = this.ClientSize.Width;


            picture.Left = (ancho - picture.Width) / 2;
            picture.Top = (alto - picture.Height) / 2;
        }
        private void Dashboard_SizeChanged(object sender, EventArgs e)
        {
            centrarimagen();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sENSORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void uBICACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eVENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            centrarimagen();
        }

        private void listaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuarios _Usuarios = new frm_usuarios();
            _Usuarios.ShowDialog();
        }

        private void gestionarSensoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sensores _Sensores = new frm_sensores();
            _Sensores.ShowDialog();
        }

        private void gestionarUbicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gestionarAlarmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_alertas _Alertas = new frm_alertas();
            _Alertas.ShowDialog();
        }

        private void lecturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarLecturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lecturas _Lecturas = new frm_lecturas();
            _Lecturas.ShowDialog();
        }

        private void notificaciónToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listaUsuarios _listaUsuarios = new frm_listaUsuarios();
            _listaUsuarios.Show();
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_reporteUsuarios _reporteUsuarios = new frm_reporteUsuarios();
            _reporteUsuarios.Show();
        }

        private void listaSensoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listaSensores _listaSensores = new frm_listaSensores();
            _listaSensores.Show();
        }

        private void gestionarUbicacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ubicaciones _Ubicaciones = new frm_ubicaciones();
            _Ubicaciones.ShowDialog();
        }

        private void listaDeUbicacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_listaUbicaciones _listaUbicaciones = new frm_listaUbicaciones();
            _listaUbicaciones.Show();
        }

        private void listaDeLecturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listaLecturas _listaLecturas = new frm_listaLecturas();
            _listaLecturas.Show();
        }

        private void listaDeAlertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listaAlertas _listaAlertas = new frm_listaAlertas();
            _listaAlertas.Show();
        }

        private void reportesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_reporteSensores _reporteSensores = new frm_reporteSensores();
            _reporteSensores.Show();
        }

        private void reportesToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frm_reporteUbicaciones _reporteUbicaciones = new frm_reporteUbicaciones();
            _reporteUbicaciones.Show();
        }

        private void reportesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_reporteLecturas _reporteLecturas = new frm_reporteLecturas();
            _reporteLecturas.Show();
        }

        private void reportesToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frm_reporteAlertas _reporteAlertas = new frm_reporteAlertas();
            _reporteAlertas.Show();
        }

        private void lecturasArduinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lecturasArduino _LecturasArduino = new frm_lecturasArduino();
            _LecturasArduino.Show();

        }
    }
}
