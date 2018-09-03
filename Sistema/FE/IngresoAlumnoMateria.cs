﻿using System;
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
    public partial class IngresoAlumnoMateria : Form
    {

        private int PersonaID;
        private DS.DSIngresoMaterias DSME = new DS.DSIngresoMaterias();
        private DS.DSIngresoMaterias DSMA = new DS.DSIngresoMaterias();

        public IngresoAlumnoMateria()
        {
            InitializeComponent();
        }

        private void IngresoAlumnoMateria_Load(object sender, EventArgs e)
        {

            try {
                DataTable dt = BE.BeAlumnoMaterias.ObtenerCarreras();
                foreach (DataRow d in dt.Rows)
                {
                    cmbCarrera.Items.Add(d[0]);
                }
                ConfigurarGrilla();
            }
            catch (Exception es)
            {
                MessageBox.Show(BE.BeAlumnoMaterias.error);
                return;
            }

        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmbAño.Items.Clear();
            cmbAño.Text = "";
            ComboBox aux = (ComboBox)sender;
            BE.BeAlumnoMaterias.Nombre = aux.Text;
            int años = BE.BeAlumnoMaterias.ObtenerAños();
            if (años < 0)
            {
                MessageBox.Show(BE.BeAlumnoMaterias.error);
                return;
            }
            for (int i = años; i > 0; i--)
            {
                cmbAño.Items.Add(i);
            }
            

            

        }

        private void ConfigurarGrilla()
        {
            dgvMateriasExist.DataSource = DSME.Materias;
            dgvMateriasExist.Columns["PersonaID"].Visible = false;

            dgvMateriasAnotadas.DataSource = DSMA.Materias;
            dgvMateriasAnotadas.Columns["PersonaID"].Visible = false;

        }

        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            BE.BeAlumnoMaterias.Año = Convert.ToInt32(cmbAño.Text.Trim());
            BE.BeAlumnoMaterias.Carrera = cmbCarrera.Text;
            DataTable dt = BE.BeAlumnoMaterias.ObtenerMaterias();
            DSME.Clear();
            
            foreach (DataRow d in dt.Rows)
            {
                bool aprovacion = true;
                if(DSMA.Materias.Rows.Count > 0)
                {
                    for (int i = 0; i < DSMA.Materias.Rows.Count; i++)
                    {
                        if ((string)DSMA.Materias.Rows[i][0] == (string)d[0])
                        {
                            aprovacion = false;
                        }

                    }
                    if (aprovacion)
                    {
                        DSME.Materias.AddMateriasRow((string)d[0], (int)d[1]);
                    }

                }
                else { DSME.Materias.AddMateriasRow((string)d[0], (int)d[1]); }
                
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLupa Lupa = new FormLupa("select Nombres,Apellidos, p.PersonaID from Personas p inner join Alumnos a on p.PersonaID = a.PersonaID");
            Lupa.ConfigurarGrilla(new int[] {2});
            Lupa.ShowDialog();

            if(Lupa.Valores != null)
            {
                txtAlumno.Text = $"{Lupa.Valores[0].ToString().Trim()} {Lupa.Valores[1].ToString().Trim()}";
                PersonaID = (int)Lupa.Valores[2];
            }
        }

        private void dgvMateriasExist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dgvMateriasExist.CurrentCell.RowIndex;
            DSMA.Materias.AddMateriasRow((string)DSME.Materias.Rows[indexRow][0],(int)DSME.Materias.Rows[indexRow][1]);
            DSME.Materias.Rows.RemoveAt(indexRow);
        }

        private void bAgregarTodas_Click(object sender, EventArgs e)
        {
            DSMA.Merge(DSME);
            DSME.Clear();
        }

        private void dgvMateriasAnotadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dgvMateriasAnotadas.CurrentCell.RowIndex;
            DSMA.Materias.Rows.RemoveAt(indexRow);
        }
    }
}
