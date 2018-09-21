using System;
using System.Windows.Forms;
using Sistema.BE;
using System.Data;


namespace Sistema.FE
{
    public partial class CargaPersona : Form
    {
        BePersonas BeP = new BePersonas();

        DataTable dtLupa = new DataTable();
        DataTable dtLlenar, dtLlenar2 = new DataTable();
        bool usu;
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
            this.Width = 328;
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            rbDirect.Checked = false;
            rbSecret.Checked = false;
            rbProf.Checked = false;
            rbAlumn.Checked = false;
        }
        //Pone los txt en blanco

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usu)
                {
                    if (rbDirect.Checked) Permiso = 1;
                    else if (rbSecret.Checked) Permiso = 2;
                    else if (rbProf.Checked) Permiso = 3;
                    else if (rbAlumn.Checked) Permiso = 4;
                    
                    BeP.CargarPersonas(txtDNI.Text, txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtCelular.Text, txtEmail.Text, txtDireccion.Text, txtLocalidad.Text, usu,  txtUsuario.Text, txtContraseña.Text, Permiso, "", "");
                    Nuevo();
                }
                else
                {
                    BeP.CargarPersonas(txtDNI.Text, txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtCelular.Text, txtEmail.Text, txtDireccion.Text, txtLocalidad.Text, usu,  txtUsuario.Text, txtContraseña.Text, Permiso, "", "");
                    Nuevo();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Llama al metodo cargar del BE

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            try
            {
                BeP.EliminarPersonas(txtDNI.Text, usu);
                Nuevo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Llama al metodo eliminar del BE

        private void btnLupaPersona_Click(object sender, EventArgs e)
        {
            FormLupa FML = new FormLupa("Personas", new string[] { "DNI", "Nombres", "Apellidos" });
            FML.ShowDialog();

            if (FML.Valores != null)
            {
                Llenartxt((int)FML.Valores[0]);
            }

        }
        //Crea un formulario Lupa con los datos pasados en el metodo "LupaDinamica"(se pasa primero la tabla y despues de la coma los campos a traer)
        //al hacer doble click en una celda de la lupa esta pone en verdadero un booleano para diferenciar la razon por la que se cerro la lupa. tambien guarda el valor del dni.
        //llama al metodo Llenartxt, pasando el dni

        public void Llenartxt(int DNILupa)
        {
            Nuevo();

            dtLlenar = BeP.ObtenerPersona(DNILupa);
            
            txtDNI.Text = dtLlenar.Rows[0]["DNI"].ToString();
            txtNombres.Text = dtLlenar.Rows[0]["Nombres"].ToString();
            txtApellidos.Text = dtLlenar.Rows[0]["Apellidos"].ToString();
            txtTelefono.Text = dtLlenar.Rows[0]["Telefono"].ToString();
            txtCelular.Text = dtLlenar.Rows[0]["Celular"].ToString();
            txtEmail.Text = dtLlenar.Rows[0]["Email"].ToString();
            txtDireccion.Text = dtLlenar.Rows[0]["Direccion"].ToString();
            txtLocalidad.Text = dtLlenar.Rows[0]["Localidad"].ToString();

            dtLlenar2 = BeP.ObtenerUsuario(DNILupa);
            
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
                    case 3:
                        rbProf.Checked = true;
                        break;
                    case 4:
                        rbAlumn.Checked = true;
                        break;
                }
            }
        }
        //hace una consulta a la bd tomando como parametro el dni referenciado, llena una datatable y con los datos de la misma llena los txt.


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
            //if (txtDNI.Text.Trim().Length == 0)
            //{
            //    chkUsuario.Checked = false;
            //    //MessageBox.Show("Ingresar los demas datos Primero");
            //    return;
            //}
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
