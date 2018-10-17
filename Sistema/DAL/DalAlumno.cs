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
    class DalAlumno
    {

        public void CargarAlumno(int bDNI, byte Alumn)
        {
            try
            {
                if (!ConexionBD.existe($"select AlumnoID from Alumnos a inner join Personas p on p.PersonaID = a.PersonaID where p.DNI = {bDNI}"))
                {
                    ConexionBD.Insertar($"declare @persona int set @persona = (select PersonaID from Personas where DNI = {bDNI}) insert into Alumnos(PersonaID, Inactivo) values (@persona, {Alumn})");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        

        public void ModificarAlumno(int bDNI, byte Alumn)
        {
            ConexionBD.Actualizar($"declare @persona int set @persona = (select PersonaID from Personas where DNI = {bDNI}) update Alumnos set Inactivo = {Alumn} where PersonaID = @persona");
        }


        public bool ExisteAlumno(int bDNI)
        {
            try
            {
                return ConexionBD.existe($"select AlumnoID from Alumnos a inner join Personas p on p.PersonaID = a.PersonaID where p.DNI = {bDNI}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool AlumnoON(int bDNI)
        {
            try
            {
                return ConexionBD.existe($"select AlumnoID from Alumnos a inner join Personas p on p.PersonaID = a.PersonaID where p.DNI = {bDNI} and a.Inactivo ={0}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void EliminarAlumno(int bDNI)
        {
            try
            {
                ConexionBD.Eliminar($"declare @PersonaID int set @PersonaID = (select PersonaID from Personas where DNI = {bDNI}) delete from Alumnos where PersonaID = @PersonaID");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
