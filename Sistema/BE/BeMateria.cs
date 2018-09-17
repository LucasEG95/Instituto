using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Sistema.DAL;

namespace Sistema.BE
{
    class BeMaterias
    {
       public DalMateria DalMat;
        public bool CargarMateria(int bCarrera, string bNombre, int bProfesor, string bAño, string bHoras, bool bPromocional)
        {
            DalMat = new DalMateria();
            int dPromocional;
            int dAños;
            int dHoras;
            try
            {
                dAños = Convert.ToInt32(bAño);
            }
            catch (Exception)
            {
                return false;
            }
            try
            {
                dHoras = Convert.ToInt32(bHoras);
            }
            catch (Exception)
            {
                return false;
            }
            
            if (bPromocional)
            {
                dPromocional = 1;
            }
            else {
                dPromocional = 0;
            };
            if (bProfesor == 0) {
                return false;
            }
            if (bCarrera == 0) {
                return false;
            }
               return DalMat.CargarMateria(bCarrera, bNombre, bProfesor, dAños, dHoras, dPromocional );
        
    }

        public bool EliminarMateria(int id)
        {
            DalMateria DM = new DalMateria();
            return DM.EliminarMateria(id);
        }
        public bool ModificarMateria(int idCarrera,int idMateria, string nombre, int Profesor, string año, string horas, bool promocional)
        {
            DalMat = new DalMateria();
            int dPromocional;
            int dAños;
            int dHoras;
            try
            {
                dAños = Convert.ToInt32(año);
            }
            catch (Exception)
            {
                return false;
            }
            try
            {
                dHoras = Convert.ToInt32(horas);
            }
            catch (Exception)
            {
                return false;
            }

            if (promocional)
            {
                dPromocional = 1;
            }
            else
            {
                dPromocional = 0;
            };
            if (Profesor == 0)
            {
                return false;
            }
            if (idCarrera == 0)
            {
                return false;
            }
            if (idMateria == 0)
            {
                return false;
            }
            return DalMat.ModificarMateria(idMateria, idCarrera, nombre, Profesor, dAños, dHoras, dPromocional);
        }
    }
}