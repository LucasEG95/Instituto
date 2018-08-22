using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAL;

namespace Sistema.BE
{
    class IngresoBE
    {


     public int login(string User, string Pass)
        { DalIngreso DIng = new DalIngreso();
            return Convert.ToInt32(DIng.Login(User,Pass));

        }

    }
}
