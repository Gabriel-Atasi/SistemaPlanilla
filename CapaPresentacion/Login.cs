﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            form.Show();
            this.Hide();

            form.FormClosing += frm_Cerrar;
        }
        private void frm_Cerrar(object sender, FormClosingEventArgs e)
        {
            txtCorreo.Text = "";
            txtClave.Text = "";
            this.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrase formRegistrase = new Registrase();
            formRegistrase.Show();
            this.Hide();
            formRegistrase.FormClosing += frm_Cerrar;
        }
    }
}
