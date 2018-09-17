using System;
using System.Windows.Forms;
using Sistema.BE;
namespace Sistema.FE
{
    public partial class CambiarContraseña1 : Form
    {
        public CambiarContraseña1()
        {
            InitializeComponent();
        }
        private string ContraseñaActual;
        private string user;
        public string ShowDialog(string contraseña, string usuario)
        {
            user = usuario;
            ContraseñaActual = contraseña;
            this.ShowDialog();
            return ContraseñaActual;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CambiarContraseña1_Load(object sender, EventArgs e)
        {
          
        }

        private void bAceptarCambiar_Click(object sender, EventArgs e)
        {
            BeCambioContraseña BCC = new BeCambioContraseña();
            string aux = BCC.cambiarContraseña(txtContra.Text, user, ContraseñaActual, txtContraAnt.Text, txtContraRepet.Text);
            if (aux == txtContra.Text)
            {
                ContraseñaActual = aux;
                MessageBox.Show("Cambio realizado con exito");
                this.Close();

            }
            else {
                MessageBox.Show(aux);
            }

           
        }
    }
}
