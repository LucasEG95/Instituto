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
            catch (Exception)
            {
                throw new Exception("error al obtener las carreras de la bd");
            }
            
        }


        public static int ConsultarAños(string Nombre)
        {
            try {
                DataSet ds = ConexionBD.consultar($"select CantAños from Carrera where Nombre = '{Nombre}'");
                int años = (int)ds.Tables[0].Rows[0][0];
                return años;
            }
            catch (Exception)
            {
                throw new Exception("error al obtener los años de la carrera.");
            }
        }

        public static void aver(params int[] vl)
        {

        }
        public static DataSet ObtenerMaterias(int Año, string Nombre)
        {
            try
            {
               return ConexionBD.StoredConDatos("ObtenerMaterias",Nombre,Año);
            }
            catch
            {
                throw new Exception("error al obtener las materias");
            }

        }
    }
}
