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
    public partial class MateriasEvaluacion : Form
    {
        public MateriasEvaluacion()
        {
            InitializeComponent();
        }

        private void MateriasEvaluacion_Load(object sender, EventArgs e)
        {


        }
        

        private void btnNotas_Click(object sender, EventArgs e)
        {
            EvaluacionesNotas b = new EvaluacionesNotas();
            b.ShowDialog();
        }
    }

}
