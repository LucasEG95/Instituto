using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Sistema.DAL;

namespace Sistema.DAL
{
    class DalMateria
    {
        
        public bool CargarMateria (int bCarrera, string bNombre, int bProfesor, int bAño, int bHoras, int bPromocional)
        {
            string Aux = "insert into Materia values ("+bCarrera+","+bProfesor+",'"+bNombre+"'," + bAño + "," + bHoras + ","+bPromocional+")";
            try
            {
                ConexionBD.Insertar(Aux);
                return true;

            }

            catch (Exception ex)
            {
                return false;
            }
        }
         public bool EliminarMateria (int IDMateria)
        {
            try
            {
                ConexionBD.Eliminar("delete from Materia where MateriaID =" + IDMateria );
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}