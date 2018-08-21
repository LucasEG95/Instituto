﻿using System;
using System.Windows.Forms;
using Sistema.BE;


namespace Sistema.FE
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        public int Prioridad = 0;
        private void btIngresar_Click(object sender, EventArgs e)
        {
            BeIngreso beIng = new BeIngreso();
            Prioridad = beIng.Login(txtUsuario.Text, txtContraseña.Text);
            if (Prioridad == 0)
                {
                MessageBox.Show("Usuario o contraseña mal");
            } else {
            
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show(Prioridad);
            }
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
}
