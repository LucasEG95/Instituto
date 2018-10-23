using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Sistema.DAL;
using System.Data;



namespace Sistema.DAL

{
    
    class DaLCarrera
    {
        public string error;

        public bool CargarCarrera(string bNombre, int bAños, string bNumResolucion, int bHorarios)
        {
            string aux = "insert into Carrera values ('" + bNombre + "'," + bAños + ",'" + bNumResolucion + "'," + bHorarios + ")";
            bool boolaux = false;
            try
            {
                boolaux = ConexionBD.existe("select Carrera.Nombre from Carrera where Nombre ='" + bNombre + "'");
                boolaux = ConexionBD.existe("select Carrera.NumResolucion from Carrera where NumResolucion='"+bNumResolucion+"'");

            }
            catch (Exception)
            {
                return false;
            }
            try
            {
                if (!boolaux)
                {
                    ConexionBD.Insertar(aux);
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarCarrera(int CarreraID)
        {


            try
            {

                ConexionBD.Begin();

                if (ConexionBD.existe("select CarreraID from Carrera where CarreraID =" + CarreraID))

                {
                    if (ConexionBD.existe("select * from Materia where CarreraID=" + CarreraID))
                    {
                        error = "Error, no se puede eliminar";
                        return false;                  
                    }

                    ConexionBD.Eliminar($"delete from Materia where CarreraID ={CarreraID}");
                    try
                        {
                            ConexionBD.Eliminar("delete from Materia where CarreraID=" + CarreraID);
                            ConexionBD.Eliminar("delete from Carrera where CarreraID= " + CarreraID);

                            ConexionBD.Commit();
                            return true;
                        }
                        catch (Exception)
                        {
                            ConexionBD.Rollback();
                            return false;
                        }
                    }
                ConexionBD.Rollback();
                return false;
                
            }



            catch (Exception)
            {
                ConexionBD.Rollback();
                return false;
            }

        }

            public bool ModificarCarrera(int idCarrera, string nombre, int años, string numresolucion, int horas)
            {
           
             string Consulta = "update Carrera set Nombre='" + nombre + "',CantAños=" + años + ",NumResolucion='" + numresolucion + "',CargaHoraria=" + horas + " where CarreraID=" + idCarrera;
            bool vercar = false;
            try
            {
                vercar = ConexionBD.existe("select Carrera.Nombre from Carrera where Nombre ='" + nombre + "'");
                vercar = ConexionBD.existe("select Carrera.NumResolucion from Carrera where NumResolucion ='" + numresolucion + "' ");
            }
            catch (Exception)
            {

                return false;
            }
            try
            {
                if (!vercar)
                {
                    ConexionBD.Actualizar(Consulta);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

            }
     }
 }