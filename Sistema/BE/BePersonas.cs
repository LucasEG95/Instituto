using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAL;
using System.Windows.Forms;
using System.Data;

namespace Sistema.BE
{
    
    class BePersonas
    {
        DalPersonas DalPer = new DalPersonas();

        public void CargarPersonas(string bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad, bool usu, string bUsuario, string bContraseña, int bPermiso, string bRespuesta, string bPregunta)
        {
            #region Validacion

            if (bNombre.Length <= 0)
            {
                MessageBox.Show("Debe ingresar el Apellido");
                return;
            }
            if (bApellido.Length <= 0)
            {
                MessageBox.Show("Debe ingresar el Nombre");
                return;
            }
            if (bDNI.Length <= 0)
            {
                MessageBox.Show("Debe ingresar el DNI");
                return;
            }
            if (bTelefono.Length <= 0)
            {
                bTelefono = "0";
            }
            if (bCelular.Length <= 0)
            {
                bCelular = "0";
            }
            if(bUsuario.Length <= 0)
            {
                bUsuario = "0";
            }

            #endregion


            try
            {
                DalPer.CargarPersona(Convert.ToInt32(bDNI), bNombre, bApellido, Convert.ToInt32(bTelefono), Convert.ToInt32(bCelular), bEmail, bDireccion, bLocalidad, usu, Convert.ToInt32(bUsuario), bContraseña, Convert.ToInt32(bPermiso), bRespuesta, bPregunta);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPersonas(string bDNI, bool usu)
        {

            try
            {
                DalPer.EliminarPersonas(Convert.ToInt32(bDNI), usu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

        public DataTable ObtenerPersona(int DNI)
        {
            try
            {
                return DalPer.ObtenerPersonaDAL(DNI);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en BE ObtenerPersona");
                throw ex;
            }

        }


        public DataTable ObtenerUsuario(int DNI)
        {
            try
            {
                return DalPer.ObtenerUsuarioDAL(DNI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en BE ObtenerUsuario");
                throw ex;
            }

        }
    }
}
