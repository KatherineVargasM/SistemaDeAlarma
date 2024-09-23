using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlarma.views.Ubicaciones
{
    public partial class frm_listaUbicaciones : Form
    {
        public frm_listaUbicaciones()
        {
            InitializeComponent();
        }

        private void frm_listaUbicaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAlarmaHumoDataSet.ubicaciones' Puede moverla o quitarla según sea necesario.
            this.ubicacionesTableAdapter.Fill(this.sistemaAlarmaHumoDataSet.ubicaciones);

        }
    }
}
