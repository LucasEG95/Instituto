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
        
        public void CargarPersona(int bDNI, string bNombre, string bApellido, int bTelefono, int bCelular, string bEmail, string bDireccion, string bLocalidad, bool usu, int bUsuario, string bContraseña, int bPermiso, string bRespuesta, string bPregunta)
        {
            try
            {
                ConexionBD.Begin();
                if (!ConexionBD.existe($"select DNI from Personas where DNI={bDNI}"))
                {
                    ConexionBD.StoredSinDatos("PersonasGuardar", bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad);
                    if (usu)
                    {
                        ConexionBD.StoredSinDatos("UsuariosGuardar",bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta);
                    }
                }
                else
                {
                    if (MessageBox.Show("Esta persona ya existe, desea modificarla?", "Comprovación", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        
                        ConexionBD.StoredSinDatos("PersonasModificar", bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad);
                        if (ConexionBD.existe($"Select Usuario from Usuarios u inner join Personas p on p.PersonaID = u.PersonaID where DNI={bDNI}"))
                        {
                            if (usu)
                            {
                                ConexionBD.StoredSinDatos("UsuariosModificar", bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta);
                            }
                            else
                            {
                                ConexionBD.StoredSinDatos("UsuariosEliminar", bDNI);
                            }
                            
                        }
                        else
                        {
                            ConexionBD.StoredSinDatos("UsuariosGuardar", bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta);
                        }
                    }
                    else
                    {
                        ConexionBD.Rollback();
                        return;
                    }
                }
                ConexionBD.Commit();
                MessageBox.Show("Guardado Correctamente");

            }
            catch (Exception ex)
            {
                ConexionBD.Rollback();
                throw ex;
            }
        }



        public void EliminarPersonas(int bDNI, bool usu)
        {
            try
            {
                ConexionBD.Begin();
                if (usu)
                {
                    ConexionBD.StoredSinDatos("UsuariosEliminar", bDNI);
                }
                ConexionBD.StoredSinDatos("PersonasEliminar", bDNI);
                ConexionBD.Commit();
                MessageBox.Show("Eliminado Correctamente");
            }
            catch (Exception ex)
            {
                ConexionBD.Rollback();
                throw ex;
            }
        }
        

        public DataTable ObtenerPersonaDAL( int DNI)
        {
            try
            {
                return ConexionBD.consultar($"select * from Personas where DNI={DNI}").Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en DAL ObtenerPersona");
                throw ex;
            }

        }



        public DataTable ObtenerUsuarioDAL(int DNI)
        {
            try
            {
                return ConexionBD.consultar($"select u.Usuario, u.Contraseña, u.Permiso from Usuarios u inner join Personas p on p.PersonaID = u.PersonaID where p.DNI = {DNI}").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en DAL ObtenerUsuario");
                throw ex;
            }

        }
    }
}
