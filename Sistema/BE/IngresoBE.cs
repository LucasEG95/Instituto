using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.BE
{
    class IngresoBE
    {


        public int Privilegio(string Usuario)
        {
            return //retorna el numero segun el privilegio que tiene el usuario guardado en la BD.

        }
        public bool CorroborarUsuario(string Usuario) {
            if (Usuario == "")
            {
                return false;
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
