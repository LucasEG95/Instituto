using System;
using System.Windows.Forms;

namespace Sistema.FE
{
    public partial class CambiarContraseña1 : Form
    {
        public CambiarContraseña1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CambiarContraseña1_Load(object sender, EventArgs e)
        {
           if(Program.usuario == 0)
            {
                MessageBox.Show("error de identificación");
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contraseña = (string)ConexionBD.consultar($"select Contraseña from Usuarios where Usuario = {Program.usuario}").Tables[0].Rows[0]["Contraseña"];
            if (txtContraAnt.Text.Trim() != contraseña)
            {
                MessageBox.Show($"La contraseña Anterior {txtContraAnt.Text.Trim()} es incorrecta");
                return;
            }
            if (txtContra.Text.Trim().Length == 0)
            {
                MessageBox.Show($"ingrese Contraseña nueva");
                return;
            }
            if (txtContraRepet.Text.Trim().Length == 0)
            {
                MessageBox.Show("ingrese la reiteracion de la contraseña");
                return;
            }
            if (!txtContra.Text.Trim().Equals(txtContraRepet.Text.Trim()))
            {
                MessageBox.Show("las contraseñas no coinciden");
                return;
            }
            ConexionBD.Actualizar($"update Usuarios set Contraseña = {txtContra.Text.Trim()} where Usuario = {Program.usuario}");
            MessageBox.Show("se ha modificado la contraseña");
            this.Dispose();

        }
    }
}
