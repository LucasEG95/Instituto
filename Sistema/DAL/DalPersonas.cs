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
        
        public void CargarPersona(int bDNI, string bNombre, string bApellido, int bTelefono, int bCelular, string bEmail, string bDireccion, string bLocalidad)
        {
            if (!ConexionBD.existe("select DNI from Personas where DNI="+ bDNI))
            {
                ConexionBD.StoredSinDatos("PersonasGuardar", bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad);
                MessageBox.Show("Persona Guardada");
            }
            else
            {
                
                if(MessageBox.Show("Esta persona ya existe, desea modificarla?", "Comprovación", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    
                    ConexionBD.StoredSinDatos("PersonasModificar", bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad);
                    MessageBox.Show("Persona Modificada");
                }
                else
                {
                    return;
                }
            }
        }



        public void EliminarPersonas(int bDNI)
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
        
    }
}
