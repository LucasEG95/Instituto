using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.BE
{
    class IngresoBE
    {
        public bool CorroborarDNI(string DNI) {
            if (DNI == "")
            {
                return false;
            }
            }
            return //Booleano que viene del DAL.
  }
    public bool CorroborarContraseña(string Contraseña) {
        if (Contraseña == "")
        {
            return false;
        }
        return //Booleano que viene del DAL.
    }

    }
}
