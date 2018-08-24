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
        //maxi
        DataTable dtLupa = new DataTable();
        public object[] Valores;
        private string Tabla;
        private object[] Campos;

        

        public FormLupa(string Tabla, string[] Campos)
        {
            
            InitializeComponent();
            this.Tabla = Tabla;
            this.Campos = Campos;
            dtLupa = ConexionBD.consultar(LupaDinamica()).Tables[0]; 
        }

        private string LupaDinamica()
        {
            string select = "Select ";
            for (int i = 0; i < this.Campos.Length; i++)
            {
                if (i != 0)
                {
                    select += ", ";
                }
                select += this.Campos[i];
                
                
            }

            select += $" from {this.Tabla}";
            
            return select;
        }
        private void Filtrar(string Consulta)
        {
            Consulta += $" where {cmbFiltro.Text} like '%{txtFiltro.Text.Trim()}%'";
            
            dtLupa =ConexionBD.consultar(Consulta).Tables[0];
            dtLupa.AcceptChanges();
            GrillaLupa.DataSource = dtLupa;
           
        }
        //Concatena texto y variables string de forma que quede una consulta de sql, ejecuta dicha consulta y guarda la tabla resultante.
        //agrega los campos de la consulta a el combobox

        private void FormLupa_Load(object sender, EventArgs e)
        {
            this.GrillaLupa.DataSource = dtLupa;
            //maxi
            for (int i = 0; i < GrillaLupa.Columns.Count; i++)
            {
                cmbFiltro.Items.Add(GrillaLupa.Columns[i].HeaderText);
            }
            cmbFiltro.Text = cmbFiltro.Items[0].ToString();
        }
        //pone que la info sea de solo lectura y llena la grilla con los datos de la tabla.

        private void GrillaLupa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //maxi
            Valores = new object[this.GrillaLupa.Columns.Count];
            for(int i= 0; i < Valores.Length; i++)
            {
                Valores[i] = GrillaLupa.CurrentCell.OwningRow.Cells[i].Value;
            }
            this.Close();

        }
        //guarda el valor del DNI elegido, de un booleano y cierra el programa.


            
        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Focus();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar(LupaDinamica());
        }
    }
}
