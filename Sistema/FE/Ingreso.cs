using System;
using System.Windows.Forms;
using Sistema.BE;
using System.Data;


namespace Sistema.FE
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private int Prioridad = 0;
        
        private void btIngresar_Click(object sender, EventArgs e)
        {
            BeIngreso beIng = new BeIngreso();
           
            if (beIng.PrimeraLogin(txtUsuario.Text)) {

                PrimeraContraseña PC = new PrimeraContraseña();
                txtContraseña.Text = PC.ResultContra(txtUsuario.Text);
            }

            
            Prioridad = beIng.Login(txtUsuario.Text, txtContraseña.Text);
         
            if (Prioridad == 0)
                {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            } else {
                Program.usuario =Convert.ToInt32(txtUsuario.Text.Trim());
            MenuPrincipal MP = new MenuPrincipal();
                MP.ShowDialog(Prioridad,txtContraseña.Text , txtUsuario.Text);
                this.Visible = false;
            }
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
