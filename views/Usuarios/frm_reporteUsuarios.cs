using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlarma.views.Usuarios
{
    public partial class frm_reporteUsuarios : Form
    {
        public frm_reporteUsuarios()
        {
            InitializeComponent();
        }

        private void frm_reporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAlarmaHumoDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.sistemaAlarmaHumoDataSet.usuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
