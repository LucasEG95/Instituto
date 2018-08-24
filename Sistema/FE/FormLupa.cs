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
        private DataTable dtLupa = new DataTable();
        public object[] Valores;

        private string Consulta = null;
        private string Tabla;
        private object[] Campos;

        
        /// <summary>
        /// para extraer datos de el click de la lupa se debe acceder al atributo publico Valores.
        /// </summary>
        /// <param name="Tabla"></param>
        /// <param name="Campos"></param>
        public FormLupa(string Tabla, string[] Campos)
        {
            
            InitializeComponent();
            this.Tabla = Tabla;
            this.Campos = Campos;
            dtLupa = ConexionBD.consultar(LupaDinamica()).Tables[0];
            this.GrillaLupa.DataSource = dtLupa;
        }
        public FormLupa(string consulta)
        {

            InitializeComponent();
            this.Consulta = consulta;
            dtLupa = ConexionBD.consultar(LupaDinamica()).Tables[0];
            this.GrillaLupa.DataSource = dtLupa;
        }
        private string LupaDinamica()
        {
            if(Consulta != null)
            {
                return Consulta;
            }
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

        private void FormLupa_Load(object sender, EventArgs e)
        {
            
            //maxi
            for (int i = 0; i < GrillaLupa.Columns.Count; i++)
            {
                if (GrillaLupa.Columns[i].Visible == true)
                {
                    cmbFiltro.Items.Add(GrillaLupa.Columns[i].HeaderText);
                }
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

        public void ConfigurarGrilla(int[] camposInvisibles)
        {
            for(int i = 0; i < camposInvisibles.Length; i++)
            {
                GrillaLupa.Columns[camposInvisibles[i]].Visible = false;
            }
        }
            
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
