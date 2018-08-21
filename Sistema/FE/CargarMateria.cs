using System;
using System.Windows.Forms;

namespace Sistema.FE
{
    public partial class CargarMateria : Form
    {
        BeMateria BeM;


        public CargarMateria()
        {
            InitializeComponent();
        }

        private void CargarMateria_Load(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void Nuevo()
        {
            cmbCarrera.Text = "";
            txtMateria.Text = "";
            txtProfesor.Text = "";
            txtAño.Text = "";
            txtHoras.Text = "";
            chkPromocional.Checked = false;
                
            
        }


        private void txtLupaCar_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            #region Validacion
            if (txtMateria.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre de la Materia");
                return;
            }
            if (cmbCarrera.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe elegir una Carrera");
                return;
            }
            #endregion

            BeM = new BeMateria();
            try
            {
                BeM.CargarMateria(txtMateria.Text, cmbCarrera.Text, txtProfesor.Text, txtAño.Text, txtHoras.Text, );
                MessageBox.Show("Carrera Guardada");
                Nuevo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BeM = new BeMateria();
            try
            {
                BeM.EliminarMateria(txtMateria.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
