using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema.DAL
{
    class DalIngreso
    {   public bool PrimerIngreso(string Usuario)
        {
            DataSet DS = new DataSet();
            return ConexionBD.existe("select * from Usuarios where Usuario="+Usuario+" and Pregunta=''");


        }
        public string ValidadIngreso (string Usuario, string Contraseña)
        {
            
            DataSet DS = new DataSet();
            DS = ConexionBD.consultar("select * from Usuarios where Usuario = " + Usuario + " and Contraseña = '" + Contraseña + "'");

            string S = DS.Tables[0].Rows[0]["Permiso"].ToString();

            return S;


        }
        public bool CargaDatosPrimerContraseña(string Usuario, string Contraseña, string Respuesta, string Pregunta)
        { string consulta = "update Usuarios set Contraseña='"+Contraseña+"', Respuesta ='"+Respuesta+"',Pregunta='"+Pregunta+"' where Usuario ="+Usuario ;
            return ConexionBD.Actualizar(consulta);

        }
}
}
