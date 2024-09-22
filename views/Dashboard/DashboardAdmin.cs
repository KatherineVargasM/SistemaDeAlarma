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
            frm_ubicaciones _Ubicaciones = new frm_ubicaciones();
            _Ubicaciones.ShowDialog();
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
                                 $"Se encendió el sensor del ID: {sensorAleatorio.IdSensor}.\n" +
                                 $"Ubicación: {ubicacion.LugarUbicacion}.\n" +
                                 "Por favor, evacue el área inmediatamente.\n" +
                                 "En caso de emergencia, llame al 911 o al número de emergencia del edificio.\n" +
                                 "Verifique que todos estén a salvo.";

                DialogResult result = MessageBox.Show(mensaje, "Alerta de Humo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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


    }
}
