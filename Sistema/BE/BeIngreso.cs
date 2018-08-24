using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAL;
using System.Data.SqlClient;

namespace Sistema.BE
{
    class BeIngreso
    {

        public int Login(string Usuario, string Contra)
        {
            DalIngreso DalIng = new DalIngreso();
            try
            {
                return Convert.ToInt32(DalIng.ValidadIngreso(Usuario, Contra));
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}