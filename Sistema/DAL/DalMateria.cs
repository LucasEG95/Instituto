using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Sistema.DAL;

namespace Sistema.DAL
{
    class DalMateria
    {
        DsMateria dsmat = new DsMateria();

        public void CargarMateria (string bCarrera, string bNombre, string bProfesor, int bAño, int bHoras, bool bPromocional)
        {
            dsmat.Materia.Row[0]["Carrera"] = Convert.ToString(bCarrera);
            dsmat.Materia.Row[0]["Materia"] = Convert.ToString(bNombre);
            dsmat.Materia.Row[0]["Profesor"] = Convert.ToString(bProfesor);
            dsmat.Materia.Row[0]["Año"] = Convert.ToInt32(bAño);
            dsmat.Materia.row[0]["Horas"] = Convert.ToInt32(bHoras);
            dsmat.Materia.Row[0]["Promocional"] = Convert.ToBoolean(bPromocional);

            try
            {
                ConexionBD.StoredSinDatos($"GuardarMateria + '{dsmat.Materia.Row[0]["Carrera"]}', '{dsmat.Materia.Row[0]["Materia"]}', '{dsmat.Materia.Row[0]["Profesor"]}', '{dsmat.Materia.Row[0]["Año"]}', '{dsmat.Materia.Row[0]["Horas"]}', '{dsmat.Materia.Row[0]["Promocional"]}',");

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarMateria (string bNombre)
        {
            try
            {
                ConexionBD.StoredSinDatos("EliminarMateria", dsmat.Materia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}