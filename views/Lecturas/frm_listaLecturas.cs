﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlarma.views.Lecturas
{
    public partial class frm_listaLecturas : Form
    {
        public frm_listaLecturas()
        {
            InitializeComponent();
        }

        private void frm_listaLecturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaAlarmaHumoDataSet.lecturas' Puede moverla o quitarla según sea necesario.
            this.lecturasTableAdapter.Fill(this.sistemaAlarmaHumoDataSet.lecturas);

        }
    }
}
