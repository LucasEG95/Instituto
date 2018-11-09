using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema;
using System.Data;
namespace Sistema.DAL
{
    class DalCambioContraseña
    {
        public bool CambiarContraseña(string ContraseñaNue, string User)
        {
            return ConexionBD.Actualizar("update Usuarios set Contraseña='" + ContraseñaNue + "' where Usuario =" + User);
        }
        public string OlvidoContraseña(string Usuario) {
            if(ConexionBD.existe("select * from Usuarios where Usuario = " + Usuario))
            {
                DataSet DS = new DataSet();
                DS = ConexionBD.consultar("select Pregunta from Usuarios where Usuario =" + Usuario);
                return DS.Tables[0].Rows[0]["Pregunta"].ToString();
            }
            return "NO";


        }
        public bool ExisteRespuesta(string respuesta, string Usuario)
        {
            return ConexionBD.existe("select * from Usuarios where Respuesta='" + respuesta+"' and Usuario=" + Usuario);


        }
               
        }  
    }


