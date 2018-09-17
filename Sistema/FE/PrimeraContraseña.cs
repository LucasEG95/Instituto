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
    public partial class PrimeraContraseña : Form
    {
        public PrimeraContraseña()
        {
            InitializeComponent();

        }
        private string AuxUsuario;
        public string ResultContra(string Usuario){
            AuxUsuario = Usuario;
            this.ShowDialog();
            return txtNuevaContra.Text;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            BeIngreso BI = new BeIngreso();
            string aux =  BI.CargaDePrimerContraseña(AuxUsuario, txtNuevaContra.Text, txtRepetirContraseña.Text, txtPreguntaSecret.Text, txtRespuestaSecret.Text);
            if (aux == "OK")
            {
                MessageBox.Show("Contraseña generada con exito");
                this.Close();

            }
            else {  MessageBox.Show(aux);
        }
        }
    }
}
