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

        public void CargarPersonas(string bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad)
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

            #endregion


            try
            {
                DalPer.CargarPersona(Convert.ToInt32(bDNI), bNombre, bApellido, Convert.ToInt32(bTelefono), Convert.ToInt32(bCelular), bEmail, bDireccion, bLocalidad);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPersonas(string bDNI)
        {

            try
            {
                DalPer.EliminarPersonas(Convert.ToInt32(bDNI));
                MessageBox.Show("Persona Eliminada");
            }
            catch (Exception ex)
            {
                throw ex;
            }





        }
    }
}
