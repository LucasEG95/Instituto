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
        public string OlvidoContraPregunta(string Usuario)
        { DalCambioContraseña DCC = new DalCambioContraseña();
            if (!(Usuario == ""))
            {
                return DCC.OlvidoContraseña(Usuario);

            }else { return "NO"; }
            }
            private bool Respuesta (string respuesta, string Usuario) {
            DalCambioContraseña DCC = new DalCambioContraseña();
            return DCC.ExisteRespuesta(respuesta, Usuario);
              }
        public string OlvidoContraCambio(string respuesta, string Usuario, string Contraseña, string RepeContraseña)
        {
            if (this.Respuesta(respuesta, Usuario))
            { if (Contraseña == RepeContraseña)
                {if (Contraseña == "") { return "Campo contraseña vacio"; } else {
                        DalCambioContraseña DCC = new DalCambioContraseña();
                        DCC.CambiarContraseña(Contraseña, Usuario);
                        return "OK";
                    }
                    }
                else { return "El campo Nueva Contraseña y Repetir Contraseña no coinciden"; }
            }
            else { return "Respuesta incorrecta"; }
            
        }
    }
}
