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
    class DalUsuario
    {

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


        public void CargarUsuario(int bDNI, int bUsuario, string bContraseña, int bPermiso, string bRespuesta, string bPregunta)
        {
            try
            {
                ConexionBD.StoredSinDatos("UsuariosGuardar", bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ModificarUsuario(int bDNI, int bUsuario, string bContraseña, int bPermiso, string bRespuesta, string bPregunta)
        {
            try
            {
                ConexionBD.StoredSinDatos("UsuariosModificar", bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public bool ExisteUsuario(int bDNI)
        {
            try
            {
                return ConexionBD.existe($"select u.UsuarioID from Usuarios u inner join Personas p on u.PersonaID = p.PersonaID where p.DNI = {bDNI}");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public void EliminarUsuario(int bDNI)
        {
            try
            {
                ConexionBD.StoredSinDatos("UsuariosEliminar", bDNI);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
