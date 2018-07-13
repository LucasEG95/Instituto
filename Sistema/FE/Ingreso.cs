using System;
using System.Windows.Forms;


namespace Sistema.FE
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show(1);
            
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
}
