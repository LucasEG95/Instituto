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
        DalIngreso DalIng;
        public int Login(string Usuario, string Contra)
       {
            DalIng = new DalIngreso;
        try
        {
            return DalIng.
        }
        catch (Exception ex)
        { 
            throw ex;          
        }

}
}