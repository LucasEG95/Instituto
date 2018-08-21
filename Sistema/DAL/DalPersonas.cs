using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DS;

namespace Sistema.DAL
{


    class DalPersonas
    {
        DsPersonas dsPer = new DsPersonas();

        public void CargarPersona(string bNombre, string bApellido, int bDNI, string bLocalidad, string bDireccion, int bTelefono, int bCelular, string bEmail)
        {

            dsPer.Persona.Rows[0]["Nombre"] = Convert.ToString(bNombre);
            dsPer.Persona.Rows[0]["Apellido"] = Convert.ToString(bApellido);
            dsPer.Persona.Rows[0]["DNI"] = Convert.ToInt32(bDNI);
            dsPer.Persona.Rows[0]["Localidad"] = Convert.ToString(bLocalidad);
            dsPer.Persona.Rows[0]["Direccion"] = Convert.ToString(bDireccion);
            dsPer.Persona.Rows[0]["Email"] = Convert.ToString(bEmail);
            dsPer.Persona.Rows[0]["Telefono"] = Convert.ToInt32(bTelefono);
            dsPer.Persona.Rows[0]["Celular"] = Convert.ToInt32(bCelular);

            try {
                ConexionBD.StoredSinDatos( $"PersonasGuardar + '{dsPer.Persona.Rows[0]["Nombre"]}', '{dsPer.Persona.Rows[0]["Apellido"]}', '{dsPer.Persona.Rows[0]["DNI"].ToString()}', '{dsPer.Persona.Rows[1]["DNI"]}'" ); }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public void EliminarPersonas(int bDNI)
        {
            try
            {
                ConexionBD.StoredSinDatos("EliminarPersonas", dsPer.Persona);
            }
            catch (Exception ex)
            {
                throw ex;
            }






        }
    }
}
