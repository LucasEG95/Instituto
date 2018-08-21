using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Sistema.DAL;

namespace Sistema.BE
{
    class BeCarreras
    {
        DALCarrera DalCar;
        public void CargarCarrera (string bCarrera, string bAños, string bNºResolucion, string bHorarios)
        {
            DalCar = new DALCarrera();
            int dAños, dHorarios;
            dAños = Convert.ToInt32(bAños);
            dHorarios = Convert.ToInt32(bHorarios);

            try
            {
                DalCar.CargarCarrera(bCarrera, dAños, bNºResolucion, dHorarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }

          
        }
        public void EliminarCarrera(string bNombre)
        {
            DalCar = new DALCarrera();

            try
            {
                DalCar.EliminarPersona(bNombre);
                
            }
            catch (Exception ex)
            {
                throw ex;

            }
            
        }

    }
}
