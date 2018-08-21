using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Sistema.DS;

namespace Sistema.DAL

{
    class DALCarrera
    {
        DSCarrera dscar = new DSCarrera();

        public void CargarCarrera (string bNombre, int bAños, string bNºResolucion, int bHorarios)
        {
            dscar.Carrera.Rows[0]["Carrera"] = Convert.ToString(bNombre);
            dscar.Carrera.Rows[0]["Año"] = Convert.ToInt32(bAños);
            dscar.Carrera.Rows[0]["Nº Resolucion"] = Convert.ToString(bNºResolucion);
            dscar.Carrera.Rows[0]["Horas"] = Convert.ToInt32(bHorarios);

            try
            {
                ConexionBD.StoredSinDatos( $"GuardarCarrera + '{dscar.Carrera.Rows[0]["Carrera"]}' ,'{dscar.Carrera.Rows[1]["Carrera"]}',  '{dscar.Carrera.Rows[0]["Año"]}' , '{dscar.Carrera.Rows[0]["NºResolucion"]}' , ");
            }


            catch (Exception ex)
            {
                throw ex;
            }
                

            }

        public void EliminarCarrera(string bNombre)
        {
            try
            {
                ConexionBD.StoredSinDatos("EliminarCarrera", dscar.Carrera);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           

            }
        }
        }


     


