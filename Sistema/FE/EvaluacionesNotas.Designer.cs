namespace Sistema.FE
{
    partial class EvaluacionesNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCarrera = new System.Windows.Forms.Label();
            this.lbAño = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbMateria = new System.Windows.Forms.Label();
            this.lbParciales = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGVNotas = new System.Windows.Forms.DataGridView();
            this.ltxtAlumnos = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materia:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbCarrera
            // 
            this.lbCarrera.AutoSize = true;
            this.lbCarrera.Location = new System.Drawing.Point(62, 26);
            this.lbCarrera.Name = "lbCarrera";
            this.lbCarrera.Size = new System.Drawing.Size(107, 13);
            this.lbCarrera.TabIndex = 3;
            this.lbCarrera.Text = "Nombre de la Carrera";
            // 
            // lbAño
            // 
            this.lbAño.AutoSize = true;
            this.lbAño.Location = new System.Drawing.Point(62, 83);
            this.lbAño.Name = "lbAño";
            this.lbAño.Size = new System.Drawing.Size(83, 13);
            this.lbAño.TabIndex = 4;
            this.lbAño.Text = "Año de Cursada";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(62, 203);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(99, 13);
            this.lbTipo.TabIndex = 5;
            this.lbTipo.Text = "Tipo de Evaluacion";
            this.lbTipo.Visible = false;
            // 
            // lbMateria
            // 
            this.lbMateria.AutoSize = true;
            this.lbMateria.Location = new System.Drawing.Point(62, 144);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(108, 13);
            this.lbMateria.TabIndex = 6;
            this.lbMateria.Text = "Nombre de la Materia";
            // 
            // lbParciales
            // 
            this.lbParciales.AutoSize = true;
            this.lbParciales.Location = new System.Drawing.Point(474, 26);
            this.lbParciales.Name = "lbParciales";
            this.lbParciales.Size = new System.Drawing.Size(35, 13);
            this.lbParciales.TabIndex = 7;
            this.lbParciales.Text = "Notas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tipo:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Lista Alumnos";
            // 
            // dataGVNotas
            // 
            this.dataGVNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVNotas.Location = new System.Drawing.Point(397, 42);
            this.dataGVNotas.Name = "dataGVNotas";
            this.dataGVNotas.Size = new System.Drawing.Size(190, 173);
            this.dataGVNotas.TabIndex = 10;
            this.dataGVNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVNotas_CellContentClick);
            // 
            // ltxtAlumnos
            // 
            this.ltxtAlumnos.FormattingEnabled = true;
            this.ltxtAlumnos.Location = new System.Drawing.Point(207, 43);
            this.ltxtAlumnos.Name = "ltxtAlumnos";
            this.ltxtAlumnos.Size = new System.Drawing.Size(156, 173);
            this.ltxtAlumnos.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(160, 236);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(305, 236);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // EvaluacionesNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 276);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.ltxtAlumnos);
            this.Controls.Add(this.dataGVNotas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbParciales);
            this.Controls.Add(this.lbMateria);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbAño);
            this.Controls.Add(this.lbCarrera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EvaluacionesNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas de Evaluaciones";
            this.Load += new System.EventHandler(this.EvaluacionesNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCarrera;
        private System.Windows.Forms.Label lbAño;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbMateria;
        private System.Windows.Forms.Label lbParciales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGVNotas;
        private System.Windows.Forms.ListBox ltxtAlumnos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
    }
}