using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema;
namespace Sistema.DAL
{
    class DalCambioContraseña
    {
        public bool CambiarContraseña(string ContraseñaNue, string User)
        {
            return ConexionBD.Actualizar("update Usuarios set Contraseña='" + ContraseñaNue + "' where Usuario =" + User);
        }

    }

}
