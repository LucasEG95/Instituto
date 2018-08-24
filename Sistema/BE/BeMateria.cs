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
            int dAños = Convert.ToInt32(bAño);
            int dHoras = Convert.ToInt32(bHoras);
            if (bPromocional)
            {
                dPromocional = 1;
            }
            else {
                dPromocional = 0;
            };

            
               return DalMat.CargarMateria(bCarrera, bNombre, bProfesor, dAños, dHoras, dPromocional );
            
        }

        public bool EliminarMateria(int id)
        {
            DalMateria DM = new DalMateria();
            return DM.EliminarMateria(id);
        }
    }
}