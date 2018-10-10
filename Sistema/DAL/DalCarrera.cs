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


        public bool CargarCarrera(string bNombre, int bAños, string bNumResolucion, int bHorarios)
        {
            string aux = "insert into Carrera values ('" + bNombre + "'," + bAños + ",'" + bNumResolucion + "'," + bHorarios + ")";
            bool boolaux = false;
            try
            {
                boolaux = ConexionBD.existe("select Carrera.Nombre from Carrera where Nombre ='" + bNombre + "' ");

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
                //DataSet dsc = ConexionBD.consultar("select * from Materia where CarreraID=" + CarreraID);
                //if(dsc.Tables[0].Rows.Count == 0)
                ConexionBD.Begin();

               
                
                if (ConexionBD.existe("select CarreraID from Carrera where CarreraID =" + CarreraID)) 
                    
                {
                    if (ConexionBD.existe("select * from Materia where CarreraID=" + CarreraID))
                    {
                        ConexionBD.Eliminar($"delete from Materia where CarreraID ={CarreraID}");
                    }

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

                //ConexionBD.Eliminar("")
                //ConexionBD.Eliminar("delete from Materia where CarreraID=" + CarreraID);
                ConexionBD.Rollback();
                return false;
            }



            catch (Exception)
            {
                ConexionBD.Rollback();
                return false;
            }

        }




            //try
            //{

            //    DataSet DS = ConexionBD.consultar("select * from Materia where CarreraID=" + CarreraID );
            //    if (DS.Tables[0].Rows.Count == 0)
            //    {
            //        try
            //        {
            //            ConexionBD.Eliminar("delete from Carrera where CarreraID ="+CarreraID);
            //            return true;
            //        }
            //        catch (Exception)
            //        {
            //            return false;
            //        }
            //    }
            //    ConexionBD.Eliminar("delete from Materia where CarreraID=" + CarreraID );
            //    ConexionBD.Eliminar("delete from Carrera where CarreraID =" + CarreraID );
            //    return true;
            // }
            //catch (Exception)
            // {
            //     return false;





            public bool ModificarCarrera(int idCarrera, string nombre, int años, string numresolucion, int horas)
            {
                string Consulta = "update Carrera set Nombre='" + nombre + "',CantAños=" + años + ",NumResolucion='" + numresolucion + "',CargaHoraria=" + horas + " where CarreraID=" + idCarrera;
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
        }
    }






            //ConexionBD.existe("SELECT * FROM Carrera WHERE CarreraID =" + CarreraID);
            //try
            //{
            //    ConexionBD.Eliminar("DELETE FROM Carrera WHERE CarreraID=" + CarreraID);

            //    return true;
           // }

           //catch (Exception )
            //{
              // return false;
            //}
           



     


