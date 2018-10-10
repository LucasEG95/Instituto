using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using Sistema.BE;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Sistema.FE
{
    public partial class CargarCarrera : Form
    {
        public CargarCarrera()
        {
            InitializeComponent();
        }

        private void CargarCarrera_Load(object sender, EventArgs e)
        {

        }

        //BeCarreras Bec = new BeCarreras();

        //DataTable dtLupa = new DataTable();
        //DataTable dtCompletar = new DataTable();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            BeCarreras Bec = new BeCarreras();

            if (Bec.CargarCarrera(txtCarrera.Text, txtAños.Text, txtResolucion.Text, txtHoras.Text))
            {
                MessageBox.Show("Carrera Guardada");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, verifique los datos ingresados");
            }
        }
        private int IDCARRERA;
        
        private void btnEliminar_CLick(object sender, EventArgs e)
                
        {
            BeCarreras BeC = new BeCarreras();
            
            if (BeC.EliminarCarrera(IDCARRERA))
            {
                MessageBox.Show("Carrera Eliminada");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la carrera");
            }
        }

        private void btnlupC_Click(object sender, EventArgs e)
        {

            FormLupa flupa = new FormLupa("select Carrera.CarreraID, Carrera.Nombre 'Carrera'," +
                " Carrera.CantAños 'Años'," +
                " Carrera.Numresolucion 'Nº Resolucion'," +
                " Carrera.CargaHoraria 'Horas'from Carrera");
            flupa.ConfigurarGrilla(new int[] { 0 });
            flupa.ShowDialog();


            if (flupa.Valores != null)
            {
                txtCarrera.Text = (string)flupa.Valores[1];
                IDCARRERA = (int)flupa.Valores[0];
                txtAños.Text = Convert.ToString(flupa.Valores[2]);
                txtResolucion.Text = (string)flupa.Valores[3];
                txtHoras.Text = Convert.ToString(flupa.Valores[4]);

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            BeCarreras bec = new BeCarreras();

            if (bec.ModificarCarrera(IDCARRERA, txtCarrera.Text, txtAños.Text, txtResolucion.Text, txtHoras.Text))
            {
                MessageBox.Show("Se modifico la carrera");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la carrera," +
                                " verifique si los datos son correctos");
            }
        }
    }
}
        
       
        

        //public void completartxt(string NombreLupa)
        // {
        //    dtCompletar = ConexionBD.consultar("select * from Carrera where Nombre ={NombreLupa}").Tables[0];
        //    txtCarrera.Text = dtCompletar.Rows[0]["Carrera"].ToString();
        //    txtAños.Text = dtCompletar.Rows[0]["Años"].ToString();
        //    txtResolucion.Text = dtCompletar.Rows[0]["Nº Resolucion"].ToString();
        //    txtHoras.Text = dtCompletar.Rows[0]["Horas"].ToString();
    

       //boton modificar en el dal
    





      

     
 

