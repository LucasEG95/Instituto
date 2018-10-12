using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAL;
using System.Data.SqlClient;
using System.Data;

namespace Sistema.BE
{
    class BeIngreso
    {
        public bool PrimeraLogin(string Usuario) {

            DalIngreso DalIng = new DalIngreso();
            return DalIng.PrimerIngreso(Usuario);
        }
        public int Login(string Usuario, string Contra)
        {
            
            DalIngreso DalIng = new DalIngreso();
            try
            {
                return Convert.ToInt32(DalIng.ValidadIngreso(Usuario, Contra));
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        public string CargaDePrimerContraseña(string usuario,string Contraseñanue,string ContraseñaRepetida, string Pregunta, string Respuesta)
        {   if(Contraseñanue== "")
            {
                return "Verifique que los campos Nueva Contraseña y Repetir Contraseña esten completos";
            }
            if(Contraseñanue != ContraseñaRepetida)
            {
                return "Nueva Contraseña y Repetir Contraseña no coinciden";
            }
            if ((Pregunta == "") || (Respuesta == "")) {

                return "Verifique que los campos Preegunta Secreta y Respues Secreta esten completos";
            }


            DalIngreso DI = new DalIngreso();
            if(DI.CargaDatosPrimerContraseña(usuario, Contraseñanue, Respuesta, Pregunta))
            {
                return "OK";

            }
            return "Fail";
        }
    }
}