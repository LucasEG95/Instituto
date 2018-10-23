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
        /// en el caso que se quieran poner alias a las variables que contengan espacios o puntuaciones
        /// se deben realizar "Campo [Alias]" en la consulta o en el pasaje de campos.
        /// para poner invisible un campo el metodo ConfigurarGrilla es util.
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
        /// <summary>
        /// este constructor permite pasar una consulta con where y demas 
        /// para armar una tabla mas especifica.
        /// </summary>
        /// <param name="consulta"></param>
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
        private void obtenerCamposYalias()
        {
            //Variables locales
            int indexInicio =0;
            string aux,aux2 = "";
            List<string> CamposyAlias = new List<string>();
            /*+--------------------------------------------------------------+
              +este for busca entre la consulta enviada el segmento donde se +
              +encuentra el inicio de la palabra reservada FROM y luego      +
              +guarda ese indice en la variable entera IndexInicio.          +
              +--------------------------------------------------------------+*/
            for(int i = 0; i < Consulta.Length; i++)
            {
                if(Consulta.Substring(i,4) == "from" || Consulta.Substring(i, 4) == "From" || Consulta.Substring(i, 4) == "FROM")
                {
                    indexInicio = i;
                    break;
                }

            }
            /*--------------------------------------------
            + guardo en la variable auxiliar la subcadena 
            + donde se encuentran los parametros de la tabla
            ----------------------------------------------*/
            aux = Consulta.Substring(7,indexInicio-7);
            /*--------------------------------------------
            + este for se encarga de llenar la lista con
            + los parametros separados por coma.
            + en el caso de que despues de un parametro halla
            + un espacio le suma 1 a el indice del for.
            ----------------------------------------------*/
            for (int i = 0; i < aux.Length; i++)
            {
                if (aux.Substring(i,1) == ",")
                {
                    CamposyAlias.Add(aux2);
                    aux2 = "";
                    if(aux.Substring(i+1, 1) == " ")
                    {
                        i++;
                    }
                    
                }
                else {aux2 += aux.Substring(i, 1);}
                if(i == aux.Length - 1)
                {
                    CamposyAlias.Add(aux2);
                }
            }
            /*--------------------------------------------
            + una vez completa la lista con todos los campos
            + y alias de la consulta, procedemos a llenar la
            + el arreglo de variables string Campos con
            + los parametros en la lista.
            ----------------------------------------------*/
            Campos = new string[CamposyAlias.Count];
            for(int i =0; i < CamposyAlias.Count; i++)
            {
                Campos[i] = CamposyAlias[i];
            }

        }
        private string obtenerCampos()
        {
            /*-----------------------------
              - Metodo encargado de separar
              - los campos de el alias
              -----------------------------*/
              //variable local
            string campo = "";
            //si la variable global Campos esta vacia
            //otiene el campo y alias con un metodo interno
            if(Campos == null)
            {
                obtenerCamposYalias();
            }
            //en el caso de que el primer valor de la 
            //variable Campos sea * directamente toma
            //el nombre de el campo del comboBox de
            //la lupa.
            if (Campos[0].Contains("*"))
            {
                return cmbFiltro.Text;
            }
            //en este for se recorre el campo seleccionado en el comboBox
            //y luego separa el nombre del campo de el nombre del aleas
            for (int i = 0; i < Campos[Index].Length; i++)
            {
                
                if (Campos[Index].Substring(i, 1) == " ")
                {
                    break;
                }
                campo += Campos[Index].Substring(i, 1);
            }
            //devuelve el nombre del campo seleccionado para aplicar el filtro.
            return campo;
        }
        private void Filtrar(string Consulta)
        {
            //toma la variable consulta y luego aplica un filtro a la misma
            //obteniendo como resultado todos los valores que se acerquen al texto
            //en el txtFiltro.
            
            if(Consulta.Contains("order by")|| Consulta.Contains("Order By")|| Consulta.Contains("ORDER BY"))
            {
                string[] Partes = ObtenerPartes();
                Consulta = Pegarwhere(Partes[0]);
                Consulta += Partes[1];
            }else
            {
               Consulta = Pegarwhere(Consulta);
            }

            dtLupa = ConexionBD.consultar(Consulta).Tables[0];
            dtLupa.AcceptChanges();
            GrillaLupa.DataSource = dtLupa;

        }

        private string[] ObtenerPartes()
        {
            string consultaParte1="";
            string consultaParte2="";
            string aux;
            for(int i = 0; i< Consulta.Length; i++)
            {
                aux = Consulta.Substring(i, 8);
                if (aux == "order by"|| aux == "Order by"|| aux == "order By"|| aux == "ORDER BY")
                {
                    consultaParte1 = Consulta.Substring(0, i - 1);
                    consultaParte2 = Consulta.Substring(i);
                    break;
                }
            }
             string[] Partes = new string[] { consultaParte1, consultaParte2 };

            return Partes;
        }
        private string Pegarwhere(string consulta)
        {
            if (consulta.Contains("where") || consulta.Contains("Where") || consulta.Contains("WHERE"))
            {
                consulta += $" and {obtenerCampos()} like '%{txtFiltro.Text.Trim()}%' ";
            }
            else
            {
                consulta += $" where {obtenerCampos()} like '%{txtFiltro.Text.Trim()}%' ";
            }

            return consulta;
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
            if (GrillaLupa.Columns[aux.SelectedIndex].HeaderText == aux.Text)
            {
                Index = aux.SelectedIndex;
            }
            else
            {
                for(int i = 0; i< GrillaLupa.Columns.Count; i++)
                {
                    if(GrillaLupa.Columns[i].HeaderText == aux.Text)
                    {
                        Index = i;
                    }
                }
            }
            

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar(LupaDinamica());
        }
        #endregion
        #region publicas

        /// <summary>
        /// este metodo permite esconder algunos campos de la grilla de la lupa aun que si se podran obtener desde
        /// la variable Valores[indice].
        /// </summary>
        /// <param name="camposInvisibles"></param>
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
