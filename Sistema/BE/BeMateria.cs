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
        DalMateria DalMat;
        public void CargarMateria(string bCarrera, string bNombre, string bProfesor, string bAño, string bHoras, string bPromocional)
        {
            DalMat = new DalMateria();
            int dAños, dHoras;
            bool dPromocional;
            dAños = Convert.ToInt32(bAño);
            dHoras = Convert.ToInt32(bHoras);
            dPromocional = Convert.ToBoolean(bPromocional);

            try
            {
                DalMat.CargarMateria(bCarrera, bNombre, bProfesor, bAño, bHoras, bPromocional);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}