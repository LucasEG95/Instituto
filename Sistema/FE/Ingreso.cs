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
        public int privilegio=0;
        private void btIngresar_Click(object sender, EventArgs e)
        {
            IngresoBE BEIngreso = new IngresoBE();
            MenuPrincipal MP = new MenuPrincipal();
            privilegio = BEIngreso.login(txtUsuario.Text, txtContraseña.Text);
            if ( privilegio == 0)
            {
                MessageBox.Show("Usuario o Contraseña invalida");
            }
            else { MP.Show(privilegio);
                this.Close();
            }



            
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
}
