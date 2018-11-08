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
    class BEUsuarios
    {
        DalUsuario DalUs = new DalUsuario();




        public void CargarUsuarios(string bDNI, string bUsuario, string bContraseña, int bPermiso, string bRespuesta, string bPregunta, bool usu)
        {
            if (bUsuario.Length <= 0)
            {
                bUsuario = "0";
            }
            if (bPermiso == 0)
            {
                Exception ex = new Exception("Debe elegir un nivel de Permiso");
                throw ex;
            }

            try
            {
                DalUs.CargarUsuario(Convert.ToInt32(bDNI), Convert.ToInt32(bUsuario), bContraseña, bPermiso, bRespuesta, bPregunta, usu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ObtenerUsuario(int DNI)
        {
            try
            {
                return DalUs.ObtenerUsuarioDAL(DNI);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en BE ObtenerUsuario", ex);

            }

        }


        public void EliminarUsuario(string DNI)
        {
            DalUs.EliminarUsuario(Convert.ToInt32(DNI));
        }


        public bool ExisteUsuario(string bDNI)
        {
            return DalUs.ExisteUsuario(Convert.ToInt32(bDNI));
        }


        public void ModificarUsuario(string bDNI, string bUsuario, string bContraseña, int bPermiso, string bRespuesta, string bPregunta, bool bInactivo)
        {
            DalUs.ModificarUsuario(Convert.ToInt32(bDNI), Convert.ToInt32(bUsuario), bContraseña, bPermiso, bRespuesta, bPregunta, bInactivo);
        }
    }
}
