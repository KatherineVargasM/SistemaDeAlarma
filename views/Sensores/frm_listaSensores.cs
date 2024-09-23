using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlarma.views.Sensores
{
    public partial class frm_listaSensores : Form
    {
        public frm_listaSensores()
        {
            InitializeComponent();
        }

        private void frm_listaSensores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAlarmaHumoDataSet.sensores' Puede moverla o quitarla según sea necesario.
            this.sensoresTableAdapter.Fill(this.sistemaAlarmaHumoDataSet.sensores);

        }
    }
}
