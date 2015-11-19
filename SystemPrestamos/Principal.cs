﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SystemPrestamos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroUsuarios usuario = new RegistroUsuarios();
            usuario.Show();
        }
            
        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes registro = new RegistroClientes();
            registro.Show();
        }

        private void cobradoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroCobradores cobrador = new RegistroCobradores();
            cobrador.Show();
        }

        private void rutasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroRutas ruta = new RegistroRutas();
            ruta.Show();
        }
    }
}
