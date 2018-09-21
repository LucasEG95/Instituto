
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Sistema.DAL
{
    class DalCorrelativas
    {
        
        public void GuardarCorrelativasDAL(DataTable dtCor)
        {
            if (MessageBox.Show("Verifique las correlatividades antes de Guardar. Esta seguro de guardar las correlativas?", "Comprovacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dtCor.Rows.Count; i++)
                {
                    ConexionBD.StoredSinDatos("CorrelatividadGuardar",Convert.ToInt32(dtCor.Rows[i][0]),Convert.ToInt32(dtCor.Rows[i][1]));
                }
            }
        }


        public void EliminarCorrelativasDAL(DataTable dtCor)
        {
            for (int i = 0; i < dtCor.Rows.Count; i++)
            {
                ConexionBD.StoredSinDatos("CorrelatividadEliminar", Convert.ToInt32(dtCor.Rows[i][0]), Convert.ToInt32(dtCor.Rows[i][1]));
            }
        }


        
        public DataTable TraerCorMat(int MatIDp)
        {
            DataTable dtTraer = new DataTable();
            dtTraer = ConexionBD.consultar($"Select c.MateriaID, m.Nombre, m.Año, m.CargaHoraria from Correlatividades c inner join Materia m on m.MateriaID = c.MateriaID where c.MateriaIDp = {MatIDp}").Tables[0];
            return dtTraer;
        }


        public void EliminarTodoIDp(int materiaidp)
        {
            ConexionBD.Eliminar($"delete from Correlatividades where MateriaIDp = {materiaidp}");
        }



    }
}
