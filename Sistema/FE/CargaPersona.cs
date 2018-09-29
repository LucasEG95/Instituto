using System;
using System.Windows.Forms;
using Sistema.BE;
using System.Data;


namespace Sistema.FE
{
    public partial class CargaPersona : Form
    {
        BePersonas BePer = new BePersonas();
        BEUsuarios BeUs = new BEUsuarios();
        BEProfesores BeProf = new BEProfesores();
        BEAlumnos BeAl = new BEAlumnos();

        DataTable dtLupa = new DataTable();
        DataTable dtLlenar, dtLlenar2 = new DataTable();

        bool usu, Alumn, Prof;
        int Permiso;

        public CargaPersona()
        {
            InitializeComponent();
        }

        private void CargaPersona_Load(object sender, EventArgs e)
        {
            Nuevo();
            
        }

        
        private void Nuevo()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtLocalidad.Text = "";
            txtTelefono.Text = "";
            chkUsuario.Checked = false;
            usu = false;
            Alumn = false;
            Prof = false;
            this.Width = 328;
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            rbDirect.Checked = false;
            rbSecret.Checked = false;
            chkProf.Checked = false;
            chkAlumn.Checked = false;
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Permiso = 0;
                if (chkAlumn.Checked) { Permiso = 4; Alumn = true; }
                if (chkProf.Checked & (Permiso > 3 | Permiso == 0)) { Permiso = 3; Prof = true; }
                if (rbSecret.Checked & (Permiso > 2 | Permiso == 0)) Permiso = 2;
                else if (rbDirect.Checked & (Permiso > 1 | Permiso == 0)) Permiso = 1;

                BePer.CargarTodo(txtDNI.Text, txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtCelular.Text, txtEmail.Text, txtDireccion.Text, txtLocalidad.Text, txtUsuario.Text, txtContraseña.Text, Permiso, "", "", Alumn, Prof, usu);
                    
                MessageBox.Show("Guardado Correctamente");
                Nuevo();
            }
            catch
            {
                MessageBox.Show("Error al cargar la Persona");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Eliminar esta Persona y Usuario", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BePer.EliminarTodo(txtDNI.Text);
                    MessageBox.Show("Eliminado Correctamente");
                    Nuevo();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        private void btnLupaPersona_Click(object sender, EventArgs e)
        {
            FormLupa FML = new FormLupa("Personas", new string[] { "DNI", "Nombres", "Apellidos" });
            FML.ShowDialog();

            if (FML.Valores != null)
            {
                Llenartxt((int)FML.Valores[0]);
            }

        }


        public void Llenartxt(int DNILupa)
        {
            Nuevo();

            dtLlenar = BePer.ObtenerPersona(DNILupa);
            
            txtDNI.Text = dtLlenar.Rows[0]["DNI"].ToString();
            txtNombres.Text = dtLlenar.Rows[0]["Nombres"].ToString();
            txtApellidos.Text = dtLlenar.Rows[0]["Apellidos"].ToString();
            txtTelefono.Text = dtLlenar.Rows[0]["Telefono"].ToString();
            txtCelular.Text = dtLlenar.Rows[0]["Celular"].ToString();
            txtEmail.Text = dtLlenar.Rows[0]["Email"].ToString();
            txtDireccion.Text = dtLlenar.Rows[0]["Direccion"].ToString();
            txtLocalidad.Text = dtLlenar.Rows[0]["Localidad"].ToString();

            dtLlenar2 = BeUs.ObtenerUsuario(DNILupa);
            
            if (dtLlenar2.Rows.Count != 0)
            {
                chkUsuario.Checked = true;
                txtUsuario.Text = dtLlenar2.Rows[0]["Usuario"].ToString();
                txtContraseña.Text = dtLlenar2.Rows[0]["Contraseña"].ToString();
                Permiso = Convert.ToInt32(dtLlenar2.Rows[0]["Permiso"]);
                switch (Permiso)
                {
                    case 1:
                        rbDirect.Checked = true;
                        break;
                    case 2:
                        rbSecret.Checked = true;
                        break;
                }
                if (BeAl.ExisteAlumno(DNILupa.ToString())) { chkAlumn.Checked = true; Alumn = true; }
                if (BeProf.ExisteProfesor(DNILupa.ToString())) { chkProf.Checked = true; Prof = true; }
            }
        }


        private void chkProf_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProf.Checked == true)
            {
                Prof = true;
            }
            else
            {
                Prof = false;
            }
        }


        private void chkAlumn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlumn.Checked == true)
            {
                Alumn = true;
            }
            else
            {
                Alumn = false;
            }
        }


        private void chkUsuario_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text.Trim().Length == 0)
            {
                chkUsuario.Checked = false;
                MessageBox.Show("Ingresar los demas datos Primero");
                return;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }


        private void chkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUsuario.Checked == true)
            {
                this.Width = 567;
                txtUsuario.Text = txtDNI.Text.Trim();
                txtContraseña.Text = txtDNI.Text.Trim();
                usu = true;
            }
            else
            {
                this.Width = 328;
                usu = false;
            }
            
        }
        
    }
}
