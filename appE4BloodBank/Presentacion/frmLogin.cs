﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace appE4BloodBank.Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnINICIAR_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Administrador" & txtContraseña.Text == "1234")
            {
                MessageBox.Show("BIENVENIDO");
                Form Principal = new frmPrincipal();
                Principal.Show();
            
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
