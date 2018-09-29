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

        public void CargarProfesor(int bDNI)
        {
            try
            {
                if (!ConexionBD.existe($"select ProfesorID from Profesores a inner join Personas p on p.PersonaID = a.PersonaID where p.DNI = {bDNI}"))
                {
                    ConexionBD.Insertar($"declare @persona int set @persona = (select PersonaID from Personas where DNI = {bDNI}) insert into Profesores(PersonaID) values (@persona)");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool ExisteProfesor(int bDNI)
        {
            try
            {
                return ConexionBD.existe($"select ProfesorID from Profesores a inner join Personas p on p.PersonaID = a.PersonaID where p.DNI = {bDNI}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void EliminarProfesor(int bDNI)
        {
            try
            {
                ConexionBD.Eliminar($"declare @PersonaID int set @PersonaID = (select PersonaID from Personas where DNI = {bDNI}) delete from Profesores where PersonaID = @PersonaID");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
