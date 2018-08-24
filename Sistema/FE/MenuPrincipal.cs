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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            

       }
        public int DistanciaBT = 20;
        public int BTTop = 50;
        public int BTWidth = 200;
        public int BTHeight = 80;
        public void ShowDialog(int num) {
            
            Button BTCarrera = new Button();
            BTCarrera.Text = "Carreras";

//            BTCarrera.Click += new EventHandler(BTCarrera_Click);

            Button BTMateria = new Button();
            BTMateria.Text = "Materias";

            BTMateria.Click += new EventHandler(BTMateria_Click);

            Button BTPersona = new Button();
            BTPersona.Text = "Persona";

            BTPersona.Click += new EventHandler(BTPersona_Click);

            Button BTEvaluaciones = new Button();
            BTEvaluaciones.Text = "Evaluaciones";

          //  BTEvaluaciones.Click += new EventHandler(BTEvaluaciones_Click);

            Button BTInformes = new Button();
            BTInformes.Text = "Informes";

            //BTInformes.Click += new EventHandler(BTInformes_Click);

            Button BTConsulta = new Button();
            BTConsulta.Text = "Consultas";

            //BTConsulta.Click += new EventHandler(BTConsulta_Click);

            Button BTCambiarContr = new Button();
            BTCambiarContr.Text = "Cambiar Contraseña";

//            BTCambiarContr.Click += new EventHandler(BTCambiarContr_Click);

            Button BTCorrelativas = new Button();
            BTCorrelativas.Text = "Correlativas";

  //          BTCorrelativas.Click += new EventHandler(BTCorrelativas_Click);

            BTCarrera.Width = BTWidth;
            BTCarrera.Height = BTHeight;

            BTMateria.Width = BTWidth;
            BTMateria.Height = BTHeight;

            BTPersona.Width = BTWidth;
            BTPersona.Height = BTHeight;

            BTEvaluaciones.Width = BTWidth;
            BTEvaluaciones.Height = BTHeight;

            BTInformes.Width = BTWidth;
            BTInformes.Height = BTHeight;

            BTConsulta.Width = BTWidth;
            BTConsulta.Height = BTHeight;

            BTCambiarContr.Width = 232;
            BTCambiarContr.Height = 28;

            BTCambiarContr.Top = this.Bottom + 200;
            BTCambiarContr.Left = this.Right + 150;

            BTCorrelativas.Width = BTWidth;
            BTCorrelativas.Height = BTHeight;

            if (num == 1)
            {
                this.Controls.Add(BTCarrera);
                BTCarrera.Top = BTTop;
                BTCarrera.Left = DistanciaBT;
                this.Controls.Add(BTMateria);
                BTMateria.Top = BTTop;
                BTMateria.Left = BTCarrera.Right + DistanciaBT;
                this.Controls.Add(BTPersona);
                BTPersona.Top = BTTop;
                BTPersona.Left = BTMateria.Right + DistanciaBT;
                this.Controls.Add(BTEvaluaciones);
                BTEvaluaciones.Top = BTTop;
                BTEvaluaciones.Left = BTPersona.Right + DistanciaBT;
                this.Controls.Add(BTInformes);
                BTInformes.Top = BTTop;
                BTInformes.Left = BTEvaluaciones.Right + DistanciaBT;
                this.Controls.Add(BTConsulta);
                BTConsulta.Top = BTTop;
                BTConsulta.Left = BTInformes.Right + DistanciaBT;
                this.Controls.Add(BTCambiarContr);
            //    BTCambiarContr.Top = this.Bottom - 125;
             //   BTCambiarContr.Left = this.Right - 282;
                this.Controls.Add(BTCorrelativas);
                BTCorrelativas.Top = BTCarrera.Bottom + 30;
                BTCorrelativas.Left = DistanciaBT;
            }
            else { if (num == 2)
                {
                    this.Controls.Add(BTCarrera);
                    BTCarrera.Top = BTTop;
                    BTCarrera.Left = DistanciaBT;
                    this.Controls.Add(BTMateria);
                    BTMateria.Top = BTTop;
                    BTMateria.Left = BTCarrera.Right + DistanciaBT;
                    this.Controls.Add(BTPersona);
                    BTPersona.Top = BTTop;
                    BTPersona.Left = BTMateria.Right + DistanciaBT;
                    this.Controls.Add(BTInformes);
                    BTInformes.Top = BTTop;
                    BTInformes.Left = BTPersona.Right + DistanciaBT;
                    this.Controls.Add(BTConsulta);
                    BTConsulta.Top = BTTop;
                    BTConsulta.Left = BTInformes.Right + DistanciaBT;
                    this.Controls.Add(BTCambiarContr);
                 //   BTCambiarContr.Top = this.Bottom - 125;
                  //  BTCambiarContr.Left = this.Right - 282;
                    this.Controls.Add(BTCorrelativas);
                    BTCorrelativas.Top = BTTop;
                    BTCorrelativas.Left = BTConsulta.Right + DistanciaBT;
                }
                else
                {
                    if (num == 3)
                    {
                        this.Controls.Add(BTPersona);
                        BTPersona.Top = BTTop;
                        BTPersona.Left = DistanciaBT;
                        this.Controls.Add(BTInformes);
                        BTInformes.Top = BTTop;
                        BTInformes.Left = BTPersona.Right + DistanciaBT;
                        this.Controls.Add(BTConsulta);
                        BTConsulta.Top = BTTop;
                        BTConsulta.Left = BTInformes.Right + DistanciaBT;
                        this.Controls.Add(BTCambiarContr);
                        //BTCambiarContr.Top = this.Bottom - 25;
                        //BTCambiarContr.Left = this.Right - 282;
                    }
                    else {if (num == 4) {
                            this.Controls.Add(BTEvaluaciones);
                            BTEvaluaciones.Top = BTTop;
                            BTEvaluaciones.Left = DistanciaBT;
                            this.Controls.Add(BTConsulta);
                            BTConsulta.Top = BTTop;
                            BTConsulta.Left = BTEvaluaciones.Right + DistanciaBT;
                            this.Controls.Add(BTCambiarContr);
                            BTCambiarContr.Top = this.Bottom - 125;
                            BTCambiarContr.Left = this.Right - 282;


                        }
                        else { if (num == 5)
                            {
                                this.Controls.Add(BTConsulta);
                                BTConsulta.Top = BTTop;
                                BTConsulta.Left = DistanciaBT;
                                this.Controls.Add(BTCambiarContr);
                                BTCambiarContr.Top = this.Bottom - 125;
                                BTCambiarContr.Left = this.Right - 282;

                            }
                        }
                    }
                }
             
            }
            this.Show();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //    private void BTCarrera_Click(object sender, EventArgs e)
        //    {
        //CargarCarrera CC = new CargarCarrera();
        //CC.ShowDialog();
        // }

                private void BTMateria_Click(object sender, EventArgs e) {
        
         CargaMateria CM = new CargaMateria();
         CM.ShowDialog();
        }


        private void BTPersona_Click(object sender, EventArgs e)
        {
            CargaPersona CP = new CargaPersona();
            CP.ShowDialog();
        }


        //private void BTEvaluaciones_Click(object sender, EventArgs e) {
        //EvaluacionesNotas EN = new EvaluacionesNotas();
        //EN.ShowDialog();
        //}


        //        private void BTCambiarContr_Click(object sender, EventArgs e) {
        //CambiarContraseña1 CContraseña = new CambiarContraseña1();
        //CContraseña.ShowDialog();
        //}


        // private void BTInformes_Click(object sender, EventArgs e) {

        // }


        //private void BTConsulta_Click(object sender, EventArgs e) {

        //    }

        // private void BTCorrelativas_Click(object sender, EventArgs e)
        //{
        //Correlativas Correlativas = new Correlativas();
        //Correlativas.ShowDialog();
        //}

        // private void MenuPrincipal_Load(object sender, EventArgs e)
        //{

        //    }
    }
}

