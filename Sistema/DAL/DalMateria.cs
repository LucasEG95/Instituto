using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Sistema.DAL;
using System.Data;
namespace Sistema.DAL
{
    class DalMateria
    {

        public bool CargarMateria(int bCarrera, string bNombre, int bProfesor, int bAño, int bHoras, int bPromocional)
        {
            if (this.cantAños(bCarrera) >= bAño)
            {
                string Aux = "insert into Materia values (" + bCarrera + "," + bProfesor + ",'" + bNombre + "'," + bAño + "," + bHoras + "," + bPromocional + ")";
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
            return false;
        }
        private int cantAños(int CarreraID)
        {
            DataSet ds = new DataSet();
            ds = ConexionBD.consultar("select CantAños from Carrera where CarreraID=" + CarreraID);
            return Convert.ToInt32( ds.Tables[0].Rows[0]["CantAños"].ToString());
        }
        public bool ModificarMateria (int idMateria,int idCarrera, string nombre, int IDProfesor, int año, int horas, int Promocional)
        {
            string Consulta = "update Materia set CarreraID="+idCarrera+",ProfesorID="+IDProfesor+",Nombre='"+nombre+"',Año="+año+",CargaHoraria="+horas+",Promocional="+Promocional+" where MateriaID="+idMateria;
            try
            {
                ConexionBD.Actualizar(Consulta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool existemateria(string nombre, int carrera, string años)
        {
            try
            {
                return ConexionBD.existe("select * from Materia where Nombre='" + nombre + "'and Año="+años+" and CarreraID="+carrera);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EliminarMateria (int IDMateria)
        {
            try
            {
                ConexionBD.Begin();
                DataSet DS = ConexionBD.consultar("select * from Correlatividades where MateriaID=" + IDMateria + " or MateriaIDp =" + IDMateria);
                if(DS.Tables[0].Rows.Count == 0) {
                    try
                    {
                        ConexionBD.Eliminar("delete from Materia where MateriaID =" + IDMateria);
                        ConexionBD.Commit();
                        return true;

                    }
                    catch (Exception)
                    {

                        return false;
                    }
 
                }
                ConexionBD.Eliminar("delete from Correlatividades where MateriaID =" + IDMateria + " or MateriaIDp =" + IDMateria);
                ConexionBD.Eliminar("delete from Materia where MateriaID =" + IDMateria);
                ConexionBD.Commit();
                return true;
                
            }
            catch (Exception)
            {
                ConexionBD.Rollback();
                return false;
                 

            }
         //   try
          //  {
                //ConexionBD.Begin();
          //      ConexionBD.Eliminar("delete from Correlatividades where MateriaID =" + IDMateria +" or MateriaIDp ="+ IDMateria);
           //     ConexionBD.Eliminar("delete from Materia where MateriaID =" + IDMateria );
               // ConexionBD.Commit();
         
           //     return true;
           // }
           // catch (Exception ex)
           // {       // ConexionBD.Rollback();
            //    return false;
     //       }
        }
    }
}