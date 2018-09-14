using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema.DAL
{
    class DalAlumnoMaterias
    {


        public static DataSet ConsultarCarreras()
        {
            try {
                DataSet ds = ConexionBD.consultar("select Nombre from Carrera");
                return ds;
            }
            catch (Exception e)
            {
                throw new Exception("error al obtener las carreras.",e);
            }
            
        }


        public static int ConsultarAños(string Nombre)
        {
            try {
                DataSet ds = ConexionBD.consultar($"select CantAños from Carrera where Nombre = '{Nombre}'");
                int años = (int)ds.Tables[0].Rows[0][0];
                return años;
            }
            catch (Exception e)
            {
                throw new Exception("error al obtener los años de la carrera.",e);
            }
        }
        public static DataSet ObtenerMaterias(int Año, string Nombre)
        {
            try
            {
               return ConexionBD.StoredConDatos("ObtenerMaterias",Año,Nombre);
            }
            catch(Exception e)
            {
                throw new Exception("error al obtener las materias",e);
            }

        }

        public static bool guardarMateriasAlumnos(DataTable Materias,int AlumnoID)
        {
            try
            {
                if (!ConexionBD.StoredSinDatos("AlumnoMateriaEliminarTodos", AlumnoID)) return false;
                ConexionBD.Begin();
                foreach(DataRow d in Materias.Rows)
                {
                    
                    if (!ConexionBD.StoredSinDatos("guardarAlumnoMateria", (int)d[1], AlumnoID))
                    {
                        return false;
                    }
                }
                ConexionBD.Commit();
                return true;
                
            }catch(Exception e)
            {
                ConexionBD.Rollback();
                return false;
            }
        }

        public static DataTable obtenerAlumnosMaterias(int AlumnoID)
        {
            try
            {
                return ConexionBD.consultar($"select m.Nombre,m.MateriaID from MatAlumno a inner join Materia m on m.MateriaID = a.MateriaID where a.AlumnoID ={AlumnoID}").Tables[0];
            }catch(Exception e)
            {
                throw new Exception("error al traer los datos de la bd");
            }
        }
    }
}
