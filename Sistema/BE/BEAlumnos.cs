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




        public void CargarAlumno(string DNI, byte Alumn)
        {
            DalAl.CargarAlumno(Convert.ToInt32(DNI), Alumn);
        }


        public void ModificarAlumno(string bDNI, byte Alumn)
        {
            DalAl.ModificarAlumno(Convert.ToInt32(bDNI), Alumn);
        }


        public bool ExisteAlumno(string DNI)
        {
            return DalAl.ExisteAlumno(Convert.ToInt32(DNI));
        }


        public bool AlumnoON(string DNI)
        {
            return DalAl.AlumnoON(Convert.ToInt32(DNI));
        }


        public void EliminarAlumno(string DNI)
        {
            DalAl.EliminarAlumno(Convert.ToInt32(DNI));
        }


        public void ControlarAlumno(string bDNI, byte Alumn, byte Alumnint)
        {
            if ((!ExisteAlumno(bDNI)) && (Alumn == 0)) { CargarAlumno(bDNI, Alumnint); }
            else if ((AlumnoON(bDNI)) && (Alumn == 1)) { Alumnint = 1; ModificarAlumno(bDNI, Alumnint); }
            else if ((!AlumnoON(bDNI)) && (Alumn == 0)) { Alumnint = 0; ModificarAlumno(bDNI, Alumnint); }
        }


    }
}
