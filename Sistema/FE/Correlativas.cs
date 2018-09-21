using System;
using System.Windows.Forms;
using Sistema.BE;
using System.Data;
using Sistema.DAL;

namespace Sistema.FE
{
    public partial class Correlativas : Form
    {
        #region Variables

        BeCorrelativas Bec = new BeCorrelativas();
        DalCorrelativas dalcons = new DalCorrelativas();
        private int carreraid;
        private int materiaidp;

        #endregion

        public Correlativas()
        {
            InitializeComponent();
        }

        private void Correlativas_Load(object sender, EventArgs e)
        {
        }

        #region Metodos

        private void btnLupaCar_Click(object sender, EventArgs e)
        {
            FormLupa FML = new FormLupa("Carrera", new string[] { "CarreraID", "Nombre", "CantAños", "NumResolucion" });
            FML.ConfigurarGrilla(new int[] { 0 });
            FML.ShowDialog();
            if (FML.Valores != null)
            {
                txtCarrera.Text = FML.Valores[1].ToString();
                carreraid = Convert.ToInt32(FML.Valores[0]);
                cmbAño.Items.Clear();
                txtMateria.Text = "";
                GrillaMatCorrelativas.Rows.Clear();
                for (int i = 1; i <= (int)FML.Valores[2]; i++)
                {
                    cmbAño.Items.Add(i);
                }
            }
        }
        
        private void btnLupaMat_Click(object sender, EventArgs e)
        {
            DataTable dsaux = new DataTable();
            if ((txtCarrera.Text.Trim() != null)&&(txtCarrera.Text.Trim() != ""))
            {
                FormLupa FML = new FormLupa($"Select MateriaID, Nombre, Año, CargaHoraria [Carga Horaria] from Materia where Año = {cmbAño.Text.Trim()} and CarreraID = {carreraid}");
                FML.ConfigurarGrilla(new int[] { 0 });
                FML.ShowDialog();
                if (FML.Valores != null)
                {
                    txtMateria.Text = FML.Valores[1].ToString();
                    materiaidp = Convert.ToInt32(FML.Valores[0]);
                    GrillaMatCorrelativas.Rows.Clear();
                    if ((dsaux = dalcons.TraerCorMat(materiaidp)).Rows.Count != 0)
                    {
                        for (int i = 0; i < dsaux.Rows.Count; i++)
                        {
                                GrillaMatCorrelativas.Rows.Add(dsaux.Rows[i][0], dsaux.Rows[i][1], dsaux.Rows[i][2], dsaux.Rows[i][3]);
                        }
                    }
                }
            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool comparador = true;
            FormLupa FML = new FormLupa($"Select MateriaID, Nombre, Año, CargaHoraria [Carga Horaria] from Materia where Año < {cmbAño.Text.Trim()} and CarreraID = {carreraid}");
            FML.ConfigurarGrilla(new int[] { 0 });
            FML.ShowDialog();
            if (FML.Valores != null)
            {
                if (GrillaMatCorrelativas.Rows.Count == 0)
                {
                    GrillaMatCorrelativas.Rows.Add(FML.Valores);
                }
                else
                {
                    for (int i = 0; i < GrillaMatCorrelativas.Rows.Count; i++)
                    {
                        if ((int)GrillaMatCorrelativas.Rows[i].Cells[0].Value == (int)FML.Valores[0])
                        {
                            comparador = false;
                        }
                    }
                    if (comparador)
                    {
                        GrillaMatCorrelativas.Rows.Add(FML.Valores);
                    }
                    else
                    {
                        MessageBox.Show("Materia ya agregada a la tabla");
                    }
                }
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GrillaMatCorrelativas.Rows.Remove(GrillaMatCorrelativas.CurrentCell.OwningRow);
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable dtCor = new DataTable();
            dtCor.Columns.Add();
            dtCor.Columns.Add();

            dalcons.EliminarTodoIDp(materiaidp);
            for (int i = 0; i < GrillaMatCorrelativas.Rows.Count; i++ )
            {
                
                dtCor.Rows.Add(materiaidp, GrillaMatCorrelativas.Rows[i].Cells[0].Value);
            }
            Bec.GuardarCorrelativasBE(dtCor);
            txtCarrera.Text = "";
            cmbAño.Items.Clear();
            txtMateria.Text = "";
            GrillaMatCorrelativas.Rows.Clear();
            
        }

        private void cmbAño_TextChanged(object sender, EventArgs e)
        {
            txtMateria.Text = "";
            GrillaMatCorrelativas.Rows.Clear();
        }

        #endregion
    }
}
