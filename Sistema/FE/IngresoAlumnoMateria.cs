using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.FE
{
    public partial class IngresoAlumnoMateria : Form
    {

        private int año;
        private string materia;
        private string alumno;
        public IngresoAlumnoMateria()
        {
            InitializeComponent();
        }

        private void IngresoAlumnoMateria_Load(object sender, EventArgs e)
        {
            try {
                DataTable dt = BE.BeAlumnoMaterias.ObtenerCarreras();
                foreach (DataRow d in dt.Rows)
                {
                    cmbCarrera.Items.Add(d[0]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(BE.BeAlumnoMaterias.error);
                return;
            }

        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAño.Items.Clear();
            cmbAño.Text = "";
            ComboBox aux = (ComboBox)sender;
            BE.BeAlumnoMaterias.Nombre = aux.Text;
            int años = BE.BeAlumnoMaterias.ObtenerAños();
            if (años < 0)
            {
                MessageBox.Show(BE.BeAlumnoMaterias.error);
                return;
            }
            for (int i = años; i > 0; i--)
            {
                cmbAño.Items.Add(i);
            }
            

            

        }

        private void ConfigurarGrilla(DataTable dt)
        {
            dgvMateriasExist.DataSource = dt;
        }

        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
                BE.BeAlumnoMaterias.Año = Convert.ToInt32(cmbAño.Text.Trim());
                BE.BeAlumnoMaterias.Carrera = cmbCarrera.Text;
            ConfigurarGrilla(BE.BeAlumnoMaterias.ObtenerMaterias());

           


        }
    }
}
