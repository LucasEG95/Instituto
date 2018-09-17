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
    public partial class CargaMateria : Form
    {
        public CargaMateria()
        {
            InitializeComponent();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            BeMaterias BM = new BeMaterias();


            if (BM.CargarMateria(IDCARRERA, txtMateria.Text, IDPROFESOR, txtAño.Text, txtHoras.Text, chkPromocional.Checked))
            {

                MessageBox.Show("La materia se cargo Correctamente");

                this.Close();
            }
            else { MessageBox.Show("No se cargo la materia, verifique los datos"); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BeMaterias BM = new BeMaterias();
            if (BM.EliminarMateria(IDMATERIA))
            {
                MessageBox.Show("Se elimino");
                this.Close();
            }
            else { MessageBox.Show("no se elimino"); }
        }
        private int IDCARRERA;
        private void btnLupaCar_Click(object sender, EventArgs e)
        {
            // string[] CamposCarrera = new string[5];
            // CamposCarrera[0] = "CarreraID";
            // CamposCarrera[1] = "Nombre";
            // CamposCarrera[2] = "CantAños"
            // CamposCarrera[3] = "NumResolucion";
            //  CamposCarrera[4] = "CargaHoraria";
            FormLupa FL = new FormLupa("select Carrera.CarreraID, Carrera.Nombre 'Carrera', Carrera.CantAños 'Cantidad de años', Carrera.NumResolucion 'Resolucion', Carrera.CargaHoraria 'Carga horaria' from Carrera");
            FL.ConfigurarGrilla(new int[] { 0 });
            FL.ShowDialog();
            if (FL.Valores != null)
            {
                txtCarrera.Text = (string)FL.Valores[1];
                IDCARRERA = (int)FL.Valores[0];
            }
        }
        private int IDPROFESOR;
        private void btnLupaProf_Click(object sender, EventArgs e)
        {
            FormLupa lupa = new FormLupa("select Profesores.ProfesorID,Personas.Nombres, Personas.Apellidos, Personas.DNI from Personas,Profesores where Personas.PersonaID = Profesores.PersonaID");
            lupa.ConfigurarGrilla(new int[] { 0 });
            lupa.ShowDialog();
            if (lupa.Valores != null)
            {
                txtProfesor.Text = lupa.Valores[1].ToString() + " " + lupa.Valores[2].ToString();
                IDPROFESOR = Convert.ToInt32(lupa.Valores[0].ToString());
            }
        }
        private int IDMATERIA;
        private void btBuscarMateria_Click(object sender, EventArgs e)
        {
            FormLupa Fl = new FormLupa("select Carrera.CarreraID, Carrera.Nombre 'Carrera',Materia.MateriaID ,Materia.Nombre 'Materia',Profesores.ProfesorID,Personas.Nombres'Nombre Profesor',Personas.Apellidos 'Apellido Profesor',Materia.Año,Materia.CargaHoraria'Carga Horaria',Materia.Promocional from Materia,Carrera,Profesores,Personas where Materia.CarreraID = Carrera.CarreraID and Profesores.ProfesorID = Materia.ProfesorID and Profesores.PersonaID = Personas.PersonaID");
            Fl.ConfigurarGrilla(new int[] { 0, 2, 4 });
            Fl.ShowDialog();
            if (Fl.Valores != null)
            {
                IDCARRERA = (int)Fl.Valores[0];
                IDPROFESOR = (int)Fl.Valores[4];
                IDMATERIA = (int)Fl.Valores[2];
                txtCarrera.Text = (string)Fl.Valores[1];
                txtMateria.Text = (string)Fl.Valores[3];
                txtProfesor.Text = (string)Fl.Valores[5] + " " + (string)Fl.Valores[6];
                txtAño.Text = Convert.ToString(Fl.Valores[7]);
                txtHoras.Text = Convert.ToString(Fl.Valores[8]);
                chkPromocional.Checked = (bool)Fl.Valores[9];
            }


        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            BeMaterias BM = new BeMaterias();
            if (BM.ModificarMateria(IDCARRERA, IDMATERIA, txtMateria.Text, IDPROFESOR, txtAño.Text, txtHoras.Text, chkPromocional.Checked))
            {
                MessageBox.Show("Se modifico la materia");
            }
            else
            {
                MessageBox.Show("No se modifico");
            }
        }
    }
}
