﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Pagina_inicial : Form
    {
        public Pagina_inicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Ocultar el Form2
            this.Hide();

            // Mostrar el Form1
            Login form1 = new Login();
            form1.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
