using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DS;
using System.Data;

namespace Sistema.DAL
{
    class DalIngreso
    {
        DSIngresar DsIng = new DSIngresar();
        public string ValidadIngreso (string Usuario, string Contraseña)
        {
            DataTable DT = new DataTable();
            DataSet DS = new DataSet();
            DS = ConexionBD.consultar("select * from Usuarios where Usuario = " + Usuario + " and Contraseña = '" + Contraseña + "'");
            
            string S = DS.Tables[0].Rows[0]["Permiso"].ToString();

            return S;


        }
}
}
