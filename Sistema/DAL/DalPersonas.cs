using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DS;
using System.Windows.Forms;
using System.Data;

namespace Sistema.DAL
{
    class DalPersonas
    {
        
        public void CargarPersona(int bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad, bool Per)
        {
            try
            {
                ConexionBD.StoredSinDatos("PersonasGuardar", bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad, Per);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ModificarPersona(int bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad, bool Per)
        {
            try
            {
                ConexionBD.StoredSinDatos("PersonasModificar", bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad, Per);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public bool ExistePersona(int bDNI)
        {
            try
            {
                return ConexionBD.existe($"select DNI from Personas where DNI={bDNI}");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public void EliminarPersona(int bDNI)
        {
            try
            {
                ConexionBD.StoredSinDatos("PersonasEliminar", bDNI);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Elimina a la Persona que corresponda al DNI ingresado

        public DataTable ObtenerPersonaDAL(int DNI)
        {
            try
            {
                return ConexionBD.consultar($"select * from Personas where DNI={DNI}").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en DAL ObtenerPersona");
                throw ex;
            }

        }
        //Hace una consulta a la BD , la cual devuelte un DS y selecciona la Primera tabla del mismo.




    }
}
