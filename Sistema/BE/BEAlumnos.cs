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
    class BEAlumnos
    {
        DalAlumno DalAl = new DalAlumno();




        public void CargarAlumno(string DNI)
        {
            DalAl.CargarAlumno(Convert.ToInt32(DNI));
        }


        public bool ExisteAlumno(string DNI)
        {
            return DalAl.ExisteAlumno(Convert.ToInt32(DNI));
        }


        public void EliminarAlumno(string DNI)
        {
            DalAl.EliminarAlumno(Convert.ToInt32(DNI));
        }


    }
}
