using System;
using System.Windows.Forms;
using Sistema.BE;


namespace Sistema.FE
{
    public partial class CargaPersona : Form
    {
        BePersonas BeP;

        public CargaPersona()
        {
            InitializeComponent();
        }

        private void CargaPersona_Load(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtLocalidad.Text = "";
            txtTelefono.Text = "";

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            #region Validacion

            if(txtApellidos.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el Apellido");
                return;
            }
            if (txtNombres.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el Nombre");
                return;
            }
            if (txtDNI.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el DNI");
                return;
            }

            #endregion

            BeP = new BePersonas();
            try
            {
                BeP.CargarPersonas(txtNombres.Text, txtApellidos.Text, txtDNI.Text, txtLocalidad.Text, txtDireccion.Text, txtTelefono.Text, txtTelefono.Text, txtEmail.Text);
                MessageBox.Show("Persona Guardada");
                Nuevo();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BeP = new BePersonas();
            try
            {
                BeP.EliminarPersonas(txtDNI.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnLupaPersona_Click(object sender, EventArgs e)
        {

        }
    }
}
