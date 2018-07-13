using System;
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

        private void btIngresar_Click(object sender, EventArgs e)
        {
            IngresoBE BEIngreso = new IngresoBE();
            if (BEIngreso.CorroborarDatos(txtUsuario.Text, txtContraseña.Text)) {


            } ;
            MenuPrincipal MP = new MenuPrincipal();
            
            
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
}
