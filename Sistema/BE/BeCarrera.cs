using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Sistema.DAL;
using System.Windows.Forms;


namespace Sistema.BE
{
    class BeCarreras
    {
        public DaLCarrera dalc;
        public bool CargarCarrera(string bNombre, string bAños, string bNumResolucion, string bHorarios)
        {
            dalc = new DaLCarrera();

            int dAños;
            int dHorarios;
            
            try
            {
                dAños = Convert.ToInt32(bAños);
            }
            catch (Exception)
            {
                return false;
            }
            try
            {
                dHorarios = Convert.ToInt32(bHorarios);
            }
            catch (Exception)
            {
                return false;
            }


            return dalc.CargarCarrera(bNombre, dAños, bNumResolucion, dHorarios);



        }
        public bool EliminarCarrera(int ID)
        {
            DaLCarrera DC = new DaLCarrera();
            if(DC.EliminarCarrera(ID))
            {
                return true;
            }
            else
            {
                MessageBox.Show(DC.error);
                return false;
            }
               //return DC.EliminarCarrera(ID);
        }

        public bool ModificarCarrera(int idCarrera, string bNombre, string bAños, string bNumResolucion, string bHorarios)
        {
            dalc = new DaLCarrera();
            int daños;
            int dhoras;
            if((bNombre == "")|(bNumResolucion == ""))
            {
                return false;
            }
            try
            {
                daños = Convert.ToInt32(bAños);
            }
            catch (Exception)
            {
                return false;
            }
            try
            {
                dhoras = Convert.ToInt32(bHorarios);
            }
            catch (Exception)
            {
                return false;
            }

            return dalc.ModificarCarrera(idCarrera, bNombre, daños, bNumResolucion, dhoras);
       }

      
     }
 }