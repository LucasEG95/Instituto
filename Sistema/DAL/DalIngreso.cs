using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DS;

namespace Sistema.DAL
{
    class DalIngreso
    {
        DSIngresar DsIng = new DSIngresar;
        public int ValidadIngreso (string Usuario, string Contraseña)
        {   
            DsIng = ConexionBD.consultar("select * from Usuario where Usuario = '" + Usuario + "' and '" + Contraseña + "'");
        }
}
}
