using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAL;
using Sistema.BE;
using System.Windows.Forms;
using System.Data;

namespace Sistema.BE
{
    class BePersonas
    {
        DalPersonas DalPer = new DalPersonas();
        BEUsuarios BeUs = new BEUsuarios();
        BEAlumnos BeAl = new BEAlumnos();
        BEProfesores BeProf = new BEProfesores();




        public void CargarPersonas(string bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad)
        {
            #region Validacion

            if (bNombre.Length <= 0)
            {
                MessageBox.Show("Debe ingresar el Nombre");
                return;
            }
            if (bApellido.Length <= 0)
            {
                MessageBox.Show("Debe ingresar el Apellido");
                return;
            }
            if (bDNI.Length <= 0)
            {
                MessageBox.Show("Debe ingresar el DNI");
                return;
            }
            if (bTelefono.Length <= 0)
            {
                bTelefono = "0";
            }
            if (bCelular.Length <= 0)
            {
                bCelular = "0";
            }

            #endregion


            try
            {
                DalPer.CargarPersona(Convert.ToInt32(bDNI), bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        public void ModificarPersona(string bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad)
        {
            #region Validacion

            if (bNombre.Length <= 0)
            {
                MessageBox.Show("Debe ingresar el Nombre");
                return;
            }
            if (bApellido.Length <= 0)
            {
                MessageBox.Show("Debe ingresar el Apellido");
                return;
            }
            if (bDNI.Length <= 0)
            {
                MessageBox.Show("Debe ingresar el DNI");
                return;
            }
            if (bTelefono.Length <= 0)
            {
                bTelefono = "0";
            }
            if (bCelular.Length <= 0)
            {
                bCelular = "0";
            }

            #endregion


            try
            {
                DalPer.ModificarPersona(Convert.ToInt32(bDNI), bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        
        public void EliminarPersona(string bDNI)
        {
            try
            {
                DalPer.EliminarPersona(Convert.ToInt32(bDNI));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }


        public DataTable ObtenerPersona(int DNI)
        {
            try
            {
                return DalPer.ObtenerPersonaDAL(DNI);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en BE ObtenerPersona");
                throw ex;
            }

        }


        public bool ExistePersona(string bDNI)
        {
            try
            {
                return DalPer.ExistePersona(Convert.ToInt32(bDNI));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }






        public void EliminarTodo(string bDNI)
        {
            try
            {
                ConexionBD.Begin();
                BeProf.EliminarProfesor(bDNI);
                BeAl.EliminarAlumno(bDNI);
                BeUs.EliminarUsuario(bDNI);
                EliminarPersona(bDNI);
                ConexionBD.Commit();
            }
            catch(Exception ex)
            {
                ConexionBD.Rollback();
                throw ex;
            }
        }


        public void CargarTodo(string bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad, string bUsuario, string bContraseña, int bPermiso, string bRespuesta, string bPregunta, bool Alumn, bool Prof, bool usu)
        {
            try
            {
                ConexionBD.Begin();
                if (!ExistePersona(bDNI))
                {
                    CargarPersonas(bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad);
                }
                else
                {
                    ModificarPersona(bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad);
                }

                if (!BeUs.ExisteUsuario(bDNI))
                {
                    if (usu) {BeUs.CargarUsuarios(bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta);}
                }
                else
                {
                    if (usu) { BeUs.ModificarUsuario(bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta); }
                    else { BeUs.EliminarUsuario(bDNI); }
                }
                
                if (!BeAl.ExisteAlumno(bDNI)) { if (Alumn) { BeAl.CargarAlumno(bDNI); } }
                else {if (!Alumn) { BeAl.EliminarAlumno(bDNI); }}

                if (!BeProf.ExisteProfesor(bDNI)) { if (Prof) { BeProf.CargarProfesor(bDNI); } }
                else {if (!Prof) { BeProf.EliminarProfesor(bDNI); }}

                ConexionBD.Commit();
            }
            catch(Exception ex)
            {
                ConexionBD.Rollback();
                throw ex;
            }
        }

        
    }
}
