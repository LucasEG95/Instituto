using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAL;

namespace Sistema.BE
{
    
    class BePersonas
    {
        DalPersonas DalPer;
        public void CargarPersonas(string bNombre, string bApellido, string bDNI, string bLocalidad, string bDireccion, string bTelefono, string bCelular, string bEmail)
        {
            DalPer = new DalPersonas();
            int dDNI, dTelefono, dCelular;
            dDNI = Convert.ToInt32(bDNI);
            dTelefono = Convert.ToInt32(bTelefono);
            dCelular = Convert.ToInt32(bCelular);

            try
            {
                DalPer.CargarPersona(bNombre, bApellido, dDNI, bLocalidad, bDireccion, dTelefono, dCelular, bEmail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPersonas(string bDNI)
        {
            DalPer = new DalPersonas();
            int dDNI;
            dDNI = Convert.ToInt32(bDNI);

            try
            {
                DalPer.EliminarPersonas(dDNI);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





    }
}
