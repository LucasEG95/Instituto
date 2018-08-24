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
        public int IdCarrera=1;
        public int IdProfesor=4;
        private void btnCargar_Click(object sender, EventArgs e)
        {
            BeMaterias BM = new BeMaterias();
            if (BM.CargarMateria(IdCarrera, txtMateria.Text, IdProfesor, txtAño.Text, txtHoras.Text, chkPromocional.Checked))
            {

                MessageBox.Show("La materia se cargo Correctamente");

                this.Close();
            }
            else { MessageBox.Show("No se cargo la materia, verifique los datos"); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BeMaterias BM = new BeMaterias();
            if (BM.EliminarMateria(2))
            {
                MessageBox.Show("Se elimino");
            }
            else { MessageBox.Show("no se elimino"); }
        }
    }
}
