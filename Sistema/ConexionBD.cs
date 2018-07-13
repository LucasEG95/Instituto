using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Configuration.Assemblies;


namespace Sistema

{
    static class ConexionBD
    {
        public static SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Instituto"].ToString());

        #region Conectar
        public static void AbrirConeccion()
        {
            try
            {
                if(conection.State == ConnectionState.Open)
                {
                    throw new Exception("La conexion ya esta abierta");
                }
                conection.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void cerrarConeccion()
        {
            try {
                if (conection.State == ConnectionState.Closed)
                {
                    throw new Exception("La conexion ya se encuentra Cerrada.");
                }
                conection.Close();
            }catch(Exception e)
            {
                throw e;
            }

        }
        #endregion
        #region consultas

        public static DataSet consultar(string consulta)
        {
            SqlDataAdapter adaptador;
            DataSet ds = new DataSet();
            try
            {
                adaptador = new SqlDataAdapter(consulta,conection);
                adaptador.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static bool existe(string consulta)
        {
            
            SqlDataReader data;
            SqlCommand comando = new SqlCommand(consulta,conection);
            try
            {
                data = comando.ExecuteReader();
                if (data.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                throw e;
            }

        }
        public static bool Actualizar(string consulta)
        {
            SqlCommand comando = new SqlCommand(consulta, conection);
            try
            {
                if(comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static bool Eliminar(string consulta)
        {
            SqlCommand sql = new SqlCommand(consulta,conection);
            try
            {

                    if(sql.ExecuteNonQuery() > 0)
                    {
                        return true;
                }
                throw new Exception("no existe el campo seleccionado");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static bool Insertar(string consulta)
        {
            SqlCommand cmd = new SqlCommand(consulta,conection);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                throw new Exception("Error al insertar en la base de datos");
            }catch(Exception e)
            {
                throw e;
            }
        }
        public static bool Beguin()
        {
            SqlCommand cmd = new SqlCommand("BEGUIN TRAN", conection);
            try
            {
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                throw new Exception("error al ejecutar comando");
            }catch(Exception e)
            {
                throw e;
            }
        }
        public static bool Commit()
        {
            SqlCommand cmd = new SqlCommand("COMMIT", conection);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                throw new Exception("error al ejecutar comando");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static bool Rollback()
        {
            SqlCommand cmd = new SqlCommand("ROLLBACK", conection);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                throw new Exception("error al ejecutar comando");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static DataSet StoredConDatos(string stored)
        {
            DataSet DS = new DataSet();
            try {
                SqlCommand cmd = new SqlCommand("exec " + stored, conection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(DS);
                return DS;
            }catch(Exception e)
            {
                throw e;
            }
        }
        public static bool StoredSinDatos(string stored)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("exec "+stored,conection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                throw new Exception("Error al ejecutar el comando");
            }catch(Exception e)
            {
                throw e;
            }
        }









        #endregion
    }
}
