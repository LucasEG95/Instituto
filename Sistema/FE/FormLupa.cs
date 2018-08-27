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
        #region variables
        
        public object[] Valores;


        private DataTable dtLupa = new DataTable();
        private string Consulta = null;
        private string Tabla;
        private string[] Campos;
        private int Index =0;
        #endregion
        #region Constructores
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
        #endregion
        #region internos
        private string LupaDinamica()
        {
            if (Consulta != null)
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
        private void obtenerAlias()
        {
            int indexInicio =0;
            string aux,aux2 = "";
            List<string> CamposyAlias = new List<string>();
            
            for(int i = 0; i < Consulta.Length; i++)
            {
                if(Consulta.Substring(i,4) == "from" || Consulta.Substring(i, 4) == "From")
                {
                    indexInicio = i;
                    break;
                }

            }
            aux = Consulta.Substring(7,indexInicio-7);

            for(int i = 0; i < aux.Length; i++)
            {
                if (aux.Substring(i,1) == ",")
                {
                    CamposyAlias.Add(aux2);
                    aux2 = "";
                    i++;
                }
                else {aux2 += aux.Substring(i, 1);}
                if(i == aux.Length - 1)
                {
                    CamposyAlias.Add(aux2);
                }
            }
            
            Campos = new string[CamposyAlias.Count];
            for(int i =0; i < CamposyAlias.Count; i++)
            {
                Campos[i] = CamposyAlias[i];
            }

        }
        private string obtenerCampos()
        {
            string campo = "";
            if(Campos == null)
            {
                obtenerAlias();
            }
            for (int i = 0; i < Campos[Index].Length; i++)
            {

                if (Campos[Index].Substring(i, 1) == " ")
                {
                    break;
                }
                campo += Campos[Index].Substring(i, 1);
            }
            return campo;
        }
        private void Filtrar(string Consulta)
        {

            Consulta += $" where {obtenerCampos()} like '%{txtFiltro.Text.Trim()}%'";

            dtLupa = ConexionBD.consultar(Consulta).Tables[0];
            dtLupa.AcceptChanges();
            GrillaLupa.DataSource = dtLupa;

        }
        #endregion
        #region funciones
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
        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Focus();
            ComboBox aux = (ComboBox)sender;
            Index = aux.SelectedIndex;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar(LupaDinamica());
        }
        #endregion
        #region publicas
        public void ConfigurarGrilla(int[] camposInvisibles)
        {
            for(int i = 0; i < camposInvisibles.Length; i++)
            {
                GrillaLupa.Columns[camposInvisibles[i]].Visible = false;
            }
        }
        #endregion

    }
}
