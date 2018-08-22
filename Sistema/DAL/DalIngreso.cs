using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema.DAL
{
    class DalIngreso
    {
       public string Login (string User, string Pass)
        {
            try
            {
                string Consulta = "select * from dbo.Usuarios where dbo.Usuarios.Usuario ='" + User + "' and dbo.Usuarios.Contraseña ='" + Pass + "'";
                DataSet Datalogin = new DataSet();
                Datalogin = ConexionBD.consultar(Consulta);
                string Perm = Datalogin.Tables["Usuarios"].Rows[0]["Permiso"].ToString();

            }
            catch (Exception)
            {

                return "0";
            }
            
        }

    }
}
