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
using SistemaDeAlarma.views.Eventos;

namespace SistemaDeAlarma.views.Dashboard
{

    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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
            frm_usuarios _Usuarios = new frm_usuarios();
            _Usuarios.ShowDialog();
        }

        private void sENSORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sensores _Sensores = new frm_sensores();
            _Sensores.ShowDialog();
        }

        private void uBICACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ubicaciones _Ubicaciones = new frm_ubicaciones();
            _Ubicaciones.ShowDialog();
        }

        private void eVENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_eventos _Eventos = new frm_eventos();
            _Eventos.ShowDialog();
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
