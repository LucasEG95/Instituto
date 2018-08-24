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
        DataTable dtLlenar = new DataTable();

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

        }
        //Pone los txt en blanco

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                BeP.CargarPersonas(txtDNI.Text, txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtCelular.Text, txtEmail.Text, txtDireccion.Text, txtLocalidad.Text);
               
                Nuevo();

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
                BeP.EliminarPersonas(txtDNI.Text);

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
            FormLupa FML = new FormLupa();
            FML.LupaDinamica("Personas", new string[] { "DNI", "Nombres", "Apellidos" });
            if (FML.dclick == true)
            {
                Llenartxt(FML.DNILupa);
            }

        }
        //Crea un formulario Lupa con los datos pasados en el metodo "LupaDinamica"(se pasa primero la tabla y despues de la coma los campos a traer)
        //al hacer doble click en una celda de la lupa esta pone en verdadero un booleano para diferenciar la razon por la que se cerro la lupa. tambien guarda el valor del dni.
        //llama al metodo Llenartxt, pasando el dni

        public void Llenartxt(int DNILupa)
        {
            dtLlenar = ConexionBD.consultar($"select * from Personas where DNI={DNILupa}").Tables[0];
            txtDNI.Text = dtLlenar.Rows[0]["DNI"].ToString();
            txtNombres.Text = dtLlenar.Rows[0]["Nombres"].ToString();
            txtApellidos.Text = dtLlenar.Rows[0]["Apellidos"].ToString();
            txtTelefono.Text = dtLlenar.Rows[0]["Telefono"].ToString();
            txtCelular.Text = dtLlenar.Rows[0]["Celular"].ToString();
            txtEmail.Text = dtLlenar.Rows[0]["Email"].ToString();
            txtDireccion.Text = dtLlenar.Rows[0]["Direccion"].ToString();
            txtLocalidad.Text = dtLlenar.Rows[0]["Localidad"].ToString();
        }
        //hace una consulta a la bd tomando como parametro el dni referenciado, llena una datatable y con los datos de la misma llena los txt.
    }
}
