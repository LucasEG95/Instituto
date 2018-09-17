using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAL;

namespace Sistema.BE
{
    class BeCambioContraseña
    {

        public string cambiarContraseña(string nuevacontra, string user, string ContraseñaActual, string txtContraAnt, string txtContraRepet) {
            DalCambioContraseña DCC = new DalCambioContraseña();

            if (ContraseñaActual == txtContraAnt)
            {
                if (nuevacontra == txtContraRepet)
                {
                    if (DCC.CambiarContraseña(nuevacontra, user))
                    {

                        return nuevacontra;
                    }
                    else
                    {

                        return "NO OK";
                    }
                }
                else
                {

                    return ("Contraseña nueva y repetir contraseña no coinciden");

                }

            }
            else
            {
                return ("Contraseña anterior incorrecta");
            }


           
        }

    }
}
