using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAL;
using System.Windows.Forms;
using System.Data;

namespace Sistema.BE
{
    class BEProfesores
    {
        DalProfesor DalProf = new DalProfesor();




        public void CargarProfesor(string DNI, byte Prof)
        {
            DalProf.CargarProfesor(Convert.ToInt32(DNI), Prof);
        }


        public void ModificarProfesor(string bDNI, byte Prof)
        {
            DalProf.ModificarProfesor(Convert.ToInt32(bDNI), Prof);
        }


        public bool ExisteProfesor(string DNI)
        {
            return DalProf.ExisteProfesor(Convert.ToInt32(DNI));
        }


        public bool ProfesorON(string DNI)
        {
            return DalProf.ProfesorON(Convert.ToInt32(DNI));
        }


        public void EliminarProfesor(string DNI)
        {
            DalProf.EliminarProfesor(Convert.ToInt32(DNI));
        }



    }
}
