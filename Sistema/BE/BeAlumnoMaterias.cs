using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema.BE
{
    class BeAlumnoMaterias
    {
        public static int Año;
        public static string Carrera;
        public static string Nombre;
        public static string error;

        public static DataTable ObtenerCarreras()
        {
            try
            {
                
                return DAL.DalAlumnoMaterias.ConsultarCarreras().Tables[0];
            }
            catch (Exception e)
            {
                error = e.Message;
                return null;
            }
        }

        public static int ObtenerAños()
        {
            try
            {
                return DAL.DalAlumnoMaterias.ConsultarAños(Nombre);
            }
            catch (Exception e)
            {
                error = e.Message;
                return -1;
            }
            
        }


        public static DataTable ObtenerMaterias()
        {
            try
            {
                
               return DAL.DalAlumnoMaterias.ObtenerMaterias(Año, Carrera).Tables[0];

                
            }catch(Exception e)
            {
                error = e.Message;
                return null;
            }
        }

        public static bool GuardarAlumnoMaterias(DataTable Materias,int AlumnoID)
        {
            try
            {
                if (AlumnoID == 0)throw new Exception("ingrese Alumno");

                if (!DAL.DalAlumnoMaterias.guardarMateriasAlumnos(Materias, AlumnoID))
                {
                    return false;
                }
                return true;

            }catch(Exception e)
            {
                error = e.Message;
                return false;
            }
        }

        public static DataTable obtenerAlumnoMaterias(int AlumnoID)
        {
            try
            {
                return DAL.DalAlumnoMaterias.obtenerAlumnosMaterias(AlumnoID);
            }catch(Exception e)
            {
                error = e.Message;
                return null;
            }
        }

    }
}
