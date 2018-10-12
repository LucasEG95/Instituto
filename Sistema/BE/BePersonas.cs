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




        public void CargarPersonas(string bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad, bool Per)
        {
            #region Validacion
            Exception ex = new Exception();
            if (bNombre.Length <= 0)
            {
                throw new Exception("Debe ingresar el Nombre");
            }
            if (bApellido.Length <= 0)
            {
                throw new Exception("Debe ingresar el Apellido");
            }
            if (bDNI.Length <= 0)
            {
                throw new Exception("Debe ingresar el DNI");
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
            //Verifica que las variables cumplan ciertas condiciones

            try
            {
                DalPer.CargarPersona(Convert.ToInt32(bDNI), bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad, Per);
                
            }
            catch (Exception)
            {
                throw ex;
            }
            
        }
        // Valida algunas variables y luego ejecuta el metodo Cargar del DAL

        public void ModificarPersona(string bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad, bool Per)
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
            //

            try
            {
                DalPer.ModificarPersona(Convert.ToInt32(bDNI), bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad, Per);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        //Ejecuta el metodo ExistePersona del DAL

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
        //Ejecuta el metodo EliminarPersona del DAL

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
        //Ejecuta el metodo ObtenerPersona del DAL

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
        //Ejecuta el metodo ExistePersona del DAL





        public void EliminarTodo(string bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad, string bUsuario, string bContraseña, int bPermiso, string bRespuesta, string bPregunta, byte Alumn, byte Prof, bool usu, bool Per)
        {
            try
            {
                ConexionBD.Begin();
                BeProf.EliminarProfesor(bDNI);
                BeAl.EliminarAlumno(bDNI);
                BeUs.EliminarUsuario(bDNI);
                EliminarPersona(bDNI);
                ConexionBD.Commit();
                //intenta eliminar todos los campos relacionados al DNI dado, pertenecientes a las distintas tablas.
                //si da error(alguno de los campos a eliminar tiene valores relacionados en otra tabla) entonces cancela todo el proceso realizado.
            }
            catch(Exception ex)
            {
                ConexionBD.Rollback();
                try
                {
                    ConexionBD.Begin();
                    BeAl.ModificarAlumno(bDNI, 1);
                    BeProf.ModificarProfesor(bDNI, 1);
                    BeUs.ModificarUsuario(bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta, true);
                    ModificarPersona(bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad, true);
                    ConexionBD.Commit();
                    //si fallo a la hora de eliminar los campos entonces trata de Inabilitarlos todos
                }
                catch (Exception ex2)
                {
                    ConexionBD.Rollback();
                    throw ex2;
                }
                throw ex;
            }
        }
        //Elimina o Inabilita todos los campos relacionados directamente con la Persona

        public void CargarTodo(string bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad, string bUsuario, string bContraseña, int bPermiso, string bRespuesta, string bPregunta, byte Alumn, byte Prof, bool usu, bool Per)
        {
            try
            {
                ConexionBD.Begin();
                if ((!ExistePersona(bDNI)) & (Per))
                {
                    Exception ex = new Exception("Debe ingresar una Persona Habilitada");
                    throw ex;
                }
                // Evita que el usuario ingrese personas Deshabilitadas
                else if (Per) { InabilitarTodo(bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta, Per, usu);}
                else if (usu) { InabilitarTodo(bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta, Per, usu);}
                else
                {
                    if (!ExistePersona(bDNI))
                    {
                        CargarPersonas(bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad, Per);
                    }
                    else
                    {
                        ModificarPersona(bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad, Per);
                    }
                    //carga o modifica la persona dependiendo de si la misma Existe en la BD

                    if (!BeUs.ExisteUsuario(bDNI))
                    {
                        if (!usu) { BeUs.CargarUsuarios(bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta, usu); }
                    }
                    else
                    {
                        if (!usu) { BeUs.ModificarUsuario(bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta, usu); }
                        else { BeUs.ModificarUsuario(bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta, usu); }
                    }
                    //carga o modifica el usuario dependiendo de si el mismo Existe en la BD

                    byte Alumnint = 0, Profint = 0;
                    ControlarAlumno(bDNI, Alumn, Alumnint);
                    //si el alumno no existe (Metodo ExisteAlumno)y Alumn(chkAlumno) es 0(Chk tildado) entonces crea un alumno nuevo, si no pasa al siquiente
                    //Ejecuta el metodo AlumnoON (verifica que el alumno exista y ademas que su valor de Inactivo sea 0), si da verdadero entonces verifica si Alumn es 1,  si es asi modifica el alumno en la BD
                    //Si lo anterior no se cumple significa que el alumno existe pero su valor de Inactivo es 1 y que Alumn vale 0, por lo que modifica los valores en la BD

                    ControlarProfesor(bDNI, Prof, Profint);
                    //Mismo sistema que con los Alumnos pero aplicado a los Profesores
                }
                ConexionBD.Commit();
            }
            catch(Exception ex)
            {
                ConexionBD.Rollback();
                throw ex;
            }
        }
        //Carga o modifica los campos, dadas ciertas condiciones


        public void InabilitarTodo(string bDNI, string bNombre, string bApellido, string bTelefono, string bCelular, string bEmail, string bDireccion, string bLocalidad, string bUsuario, string bContraseña, int bPermiso, string bRespuesta, string bPregunta, bool Per, bool usu)
        {
            if (Per) { usu = true; ModificarPersona(bDNI, bNombre, bApellido, bTelefono, bCelular, bEmail, bDireccion, bLocalidad, Per); }
            if (BeUs.ExisteUsuario(bDNI)) BeUs.ModificarUsuario(bDNI, bUsuario, bContraseña, bPermiso, bRespuesta, bPregunta, usu); 
            if (BeAl.ExisteAlumno(bDNI)) BeAl.ModificarAlumno(bDNI, 1); 
            if (BeProf.ExisteProfesor(bDNI)) BeProf.ModificarProfesor(bDNI, 1); 
        }
        //Si el valor de Per es verdadero(Persona desactivada) desactiva el Usuario, Alumno y Profesor (si existen) que esten relacionados con dicha persona 

        public void ControlarAlumno(string bDNI, byte Alumn, byte Alumnint)
        {
            if (!BeAl.ExisteAlumno(bDNI)) { if (Alumn == 0) { BeAl.CargarAlumno(bDNI, Alumnint); } }
            else if (BeAl.AlumnoON(bDNI)) { if (Alumn == 1) { Alumnint = 1; BeAl.ModificarAlumno(bDNI, Alumnint); } }
            else { BeAl.ModificarAlumno(bDNI, Alumnint); }
        }


        public void ControlarProfesor(string bDNI, byte Prof, byte Profint)
        {
            if (!BeProf.ExisteProfesor(bDNI)) { if (Prof == 0) { BeProf.CargarProfesor(bDNI, Profint); } }
            else if (BeProf.ProfesorON(bDNI)) { if (Prof == 1) { Profint = 1; BeProf.ModificarProfesor(bDNI, Profint); } }
            else { BeProf.ModificarProfesor(bDNI, Profint); }
        }
    }
}
