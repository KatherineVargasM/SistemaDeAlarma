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
    public partial class frm_listaUsuarios : Form
    {
        public frm_listaUsuarios()
        {
            InitializeComponent();
        }

        private void frm_listaUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAlarmaHumoDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.sistemaAlarmaHumoDataSet.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'sistemaAlarmaHumoDataSet.ubicaciones' Puede moverla o quitarla según sea necesario.
            this.ubicacionesTableAdapter.Fill(this.sistemaAlarmaHumoDataSet.ubicaciones);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
