using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.BE;

namespace Sistema.FE
{
    public partial class OlvidoContraseña : Form
    {
        public OlvidoContraseña()
        {
            InitializeComponent();
        }

        private void OlvidoContraseña_Load(object sender, EventArgs e)
        {

        }
        private void Mostrar()
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            txtNuevaContra.Visible = true;
            txtRepetirContra.Visible = true;
            txtRespuesta.Visible = true;
            txtUsuario.ReadOnly = true;
            botonAceptar.Visible = true;
            
        }
        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            BeCambioContraseña BCC = new BeCambioContraseña();
            string aux = BCC.OlvidoContraPregunta(txtUsuario.Text);
            if (aux == "NO")
            {
                MessageBox.Show("Usuario Inexistente");

            }
            else
            {
                label6.Text = aux;
                this.Mostrar();
            }
            

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            BeCambioContraseña BCC = new BeCambioContraseña();
            string aux = BCC.OlvidoContraCambio(txtRespuesta.Text, txtUsuario.Text, txtNuevaContra.Text, txtRepetirContra.Text);
            if (!(aux == "OK"))
            {

                MessageBox.Show(aux);
            }
            else { 
            MessageBox.Show("Se cambio la contraseña");
            this.Close();
        }
        }
    }
}
