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
            DataSet ds = ConexionBD.consultar("select Nombre from Carrera");
            foreach(DataRow d in ds.Tables[0].Rows)
            {
                cmbCarrera.Items.Add(d[0]);
            }
        }
    }
}
