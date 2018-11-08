using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DS;
using System.Windows.Forms;
using System.Data;

namespace Sistema.DAL
{
    class DalProfesor
    {

        public void CargarProfesor(int bDNI, byte Prof)
        {
            try
            {
                if (!ConexionBD.existe($"select ProfesorID from Profesores a inner join Personas p on p.PersonaID = a.PersonaID where p.DNI = {bDNI}"))
                {
                    ConexionBD.Insertar($"declare @persona int set @persona = (select PersonaID from Personas where DNI = {bDNI}) insert into Profesores(PersonaID, Inactivo) values (@persona, {Prof})");
                }
            }
            catch (Exception)
            {
                Exception ex = new Exception("Error en cargar profesor ");
                throw ex;
            }
        }


        public void ModificarProfesor(int bDNI, byte Prof)
        {
            try
            { 
                ConexionBD.Actualizar($"declare @persona int set @persona = (select PersonaID from Personas where DNI = {bDNI}) update Profesores set Inactivo = {Prof} where PersonaID = @persona");
            }
            catch (Exception)
            {
                Exception ex = new Exception("Error en modificar profesor");
                throw ex;
            }
        }


        public bool ExisteProfesor(int bDNI)
        {
            try
            {
                return ConexionBD.existe($"select ProfesorID from Profesores a inner join Personas p on p.PersonaID = a.PersonaID where p.DNI = {bDNI}");
            }
            catch (Exception)
            {
                Exception ex = new Exception("Error en existe profesor");
                throw ex;
            }
        }


        public bool ProfesorON(int bDNI)
        {
            try
            {
                return ConexionBD.existe($"select ProfesorID from Profesores a inner join Personas p on p.PersonaID = a.PersonaID where p.DNI = {bDNI} and a.Inactivo ={0}");
            }
            catch (Exception)
            {
                Exception ex = new Exception("Error en profesorON");
                throw ex;
            }
        }


        public void EliminarProfesor(int bDNI)
        {
            try
            {
                ConexionBD.Eliminar($"declare @PersonaID int set @PersonaID = (select PersonaID from Personas where DNI = {bDNI}) delete from Profesores where PersonaID = @PersonaID");
            }
            catch (Exception)
            {
                Exception ex = new Exception("Error al eliminar el profesor");
                throw ex;
            }
        }
    }
}
