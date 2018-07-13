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

        /// <summary>
        /// abre la conexion con el servidor.
        /// </summary>
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
        /// <summary>
        /// cierra la conexion con el servidor.
        /// </summary>
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

        /// <summary>
        /// hay que pasar como parametro la consulta
        /// y devuelve un dataset con todos los datos que esta devuelve
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
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
        /// <summary>
        /// pasar como parametro la consulta donde se piden los datos que se quieren
        /// corroborar
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
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

        /// <summary>
        /// sirve para realizar updates a la base de datos.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
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

        /// <summary>
        /// elimina datos de la base de datos.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
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

        /// <summary>
        /// para insertar datos dentro de una tabla enviar la consulta.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
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
        /// <summary>
        /// para iniciar una transaccion.
        /// </summary>
        /// <returns></returns>
        public static bool Begin()
        {
            SqlCommand cmd = new SqlCommand("BEGIN TRAN", conection);
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

        /// <summary>
        /// para aceptar la transaccion en caso que sea correcta.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// para rechazar la transaccion
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// nombreDelStored parametro,parametro,parametro
        /// recorda que los string van entre ''
        /// </summary>
        /// <param name="stored"></param>
        /// <returns></returns>
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

        /// <summary>
        /// lo mismo que el que tiene datos pero este no devuelve un dataset XD
        /// </summary>
        /// <param name="stored"></param>
        /// <returns></returns>
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
