using System;
using System.Windows.Forms;
using Sistema.BE;

namespace Sistema.FE
{
    public partial class CargarCarrera : Form
    {
        BeCarrera BeC;

        public CargarCarrera()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CargarCarrera_Load(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            txtAños.Text = "";
            txtCarrera.Text = "";
            txtHoras.Text = "";
            txtResolucion.Text = "";
        
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            #region Validacion

            if(txtCarrera.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingrsar el nombre de la Carrera");
                return;
            }
            if(txtResolucion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el Nº de Resolucion");
                return;
            }

            #endregion

            BeC = new BeCarrera();
            try
            {
                BeC.CargarCarrera(txtAños.Text, txtCarrera.Text, txtHoras.Text, txtResolucion, Text);
                MessageBox.Show("Carrera Guardada");
                Nuevo();
                
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BeC = new BeCarrera();
            try
            {
                BeC.EliminarCarrera(txtCarrera.Text);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
