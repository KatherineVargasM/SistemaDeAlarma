using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlarma.views.Alertas
{
    public partial class frm_listaAlertas : Form
    {
        public frm_listaAlertas()
        {
            InitializeComponent();
        }

        private void frm_listaAlertas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAlarmaHumoDataSet.alertas' Puede moverla o quitarla según sea necesario.
            this.alertasTableAdapter.Fill(this.sistemaAlarmaHumoDataSet.alertas);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
