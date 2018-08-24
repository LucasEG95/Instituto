using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.FE
{
    public partial class FormLupa : Form
    {

        DataTable dtLupa = new DataTable();
        public Boolean dclick = false;
        public int DNILupa;

        public FormLupa()
        {
            
            InitializeComponent();
            
        }

        public void LupaDinamica(string Tabla, string[]Campos)
        {
            string select = "Select ";
            for (int i = 0; i < Campos.Length; i++)
            {
                if (i != 0)
                {
                    select += ", ";
                }
                select += Campos[i];
                cmbFiltro.Items.Add(Campos[i]);
                
            }

            select += $" from {Tabla}";
            dtLupa = ConexionBD.consultar(select).Tables[0];
        }
        //Concatena texto y variables string de forma que quede una consulta de sql, ejecuta dicha consulta y guarda la tabla resultante.
        //agrega los campos de la consulta a el combobox

        private void FormLupa_Load(object sender, EventArgs e)
        {
            this.GrillaLupa.ReadOnly = true;
            this.GrillaLupa.DataSource = dtLupa;

        }
        //pone que la info sea de solo lectura y llena la grilla con los datos de la tabla.

        private void GrillaLupa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dclick = true;
            DNILupa = Convert.ToInt32(GrillaLupa.CurrentRow.Cells[0].Value);
            this.Close();

        }
        //guarda el valor del DNI elegido, de un booleano y cierra el programa.


            
        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Focus();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
           

                
        }
    }
}
