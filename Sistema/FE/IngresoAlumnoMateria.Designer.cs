namespace Sistema.FE
{
    partial class IngresoAlumnoMateria
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
            this.dgvMateriasExist = new System.Windows.Forms.DataGridView();
            this.dgvMateriasAnotadas = new System.Windows.Forms.DataGridView();
            this.bAgregarTodas = new System.Windows.Forms.Button();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasExist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAnotadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMateriasExist
            // 
            this.dgvMateriasExist.AllowUserToAddRows = false;
            this.dgvMateriasExist.AllowUserToDeleteRows = false;
            this.dgvMateriasExist.AllowUserToResizeColumns = false;
            this.dgvMateriasExist.AllowUserToResizeRows = false;
            this.dgvMateriasExist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriasExist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMateriasExist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMateriasExist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMateriasExist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasExist.ColumnHeadersVisible = false;
            this.dgvMateriasExist.Location = new System.Drawing.Point(12, 174);
            this.dgvMateriasExist.Name = "dgvMateriasExist";
            this.dgvMateriasExist.ReadOnly = true;
            this.dgvMateriasExist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMateriasExist.RowHeadersVisible = false;
            this.dgvMateriasExist.Size = new System.Drawing.Size(256, 167);
            this.dgvMateriasExist.TabIndex = 0;
            this.dgvMateriasExist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriasExist_CellDoubleClick);
            // 
            // dgvMateriasAnotadas
            // 
            this.dgvMateriasAnotadas.AllowUserToAddRows = false;
            this.dgvMateriasAnotadas.AllowUserToDeleteRows = false;
            this.dgvMateriasAnotadas.AllowUserToResizeColumns = false;
            this.dgvMateriasAnotadas.AllowUserToResizeRows = false;
            this.dgvMateriasAnotadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriasAnotadas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMateriasAnotadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMateriasAnotadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMateriasAnotadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasAnotadas.ColumnHeadersVisible = false;
            this.dgvMateriasAnotadas.Location = new System.Drawing.Point(407, 174);
            this.dgvMateriasAnotadas.Name = "dgvMateriasAnotadas";
            this.dgvMateriasAnotadas.ReadOnly = true;
            this.dgvMateriasAnotadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMateriasAnotadas.RowHeadersVisible = false;
            this.dgvMateriasAnotadas.Size = new System.Drawing.Size(256, 167);
            this.dgvMateriasAnotadas.TabIndex = 0;
            this.dgvMateriasAnotadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriasAnotadas_CellDoubleClick);
            // 
            // bAgregarTodas
            // 
            this.bAgregarTodas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bAgregarTodas.FlatAppearance.BorderSize = 0;
            this.bAgregarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregarTodas.Location = new System.Drawing.Point(299, 235);
            this.bAgregarTodas.Name = "bAgregarTodas";
            this.bAgregarTodas.Size = new System.Drawing.Size(75, 23);
            this.bAgregarTodas.TabIndex = 1;
            this.bAgregarTodas.Text = "flechitas";
            this.bAgregarTodas.UseVisualStyleBackColor = false;
            this.bAgregarTodas.Click += new System.EventHandler(this.bAgregarTodas_Click);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(73, 86);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(320, 21);
            this.cmbCarrera.TabIndex = 2;
            this.cmbCarrera.SelectedIndexChanged += new System.EventHandler(this.cmbCarrera_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año";
            // 
            // cmbAño
            // 
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(471, 86);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(159, 21);
            this.cmbAño.TabIndex = 4;
            this.cmbAño.SelectedIndexChanged += new System.EventHandler(this.cmbAño_SelectedIndexChanged);
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(73, 32);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(183, 20);
            this.txtAlumno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alumno";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(262, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "b";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(230, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(334, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // IngresoAlumnoMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 407);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bAgregarTodas);
            this.Controls.Add(this.dgvMateriasAnotadas);
            this.Controls.Add(this.dgvMateriasExist);
            this.Name = "IngresoAlumnoMateria";
            this.Text = "lalala";
            this.Load += new System.EventHandler(this.IngresoAlumnoMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasExist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAnotadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMateriasExist;
        private System.Windows.Forms.DataGridView dgvMateriasAnotadas;
        private System.Windows.Forms.Button bAgregarTodas;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}