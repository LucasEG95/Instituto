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
            MenuPrincipal MP = new MenuPrincipal();
            bool BoolUsuario = BEIngreso.CorroborarUsuario(txtUsuario.Text);
            bool BoolContraseña = BEIngreso.CorroborarContraseña(txtContraseña.Text);
            if (BoolUsuario & BoolContraseña)
            {
                MP.Show(BEIngreso.Privilegio(txtUsuario.Text));
                this.Close();
            }
            else { if (!BoolContraseña && BoolUsuario)
                {
                    MessageBox.Show("Contraseña Incorrecta");

                }
                else {

                    MessageBox.Show("Usuario Incorrecto");
                } } ;
            
            
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
}
