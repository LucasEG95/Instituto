namespace Sistema.FE
{
    partial class Correlativas
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.btnLupaCar = new System.Windows.Forms.Button();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.btnLupaMat = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.GrillaMatCorrelativas = new System.Windows.Forms.DataGridView();
            this.MateriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargaHoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMatCorrelativas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Materia";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(84, 89);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.ReadOnly = true;
            this.txtMateria.Size = new System.Drawing.Size(229, 20);
            this.txtMateria.TabIndex = 2;
            // 
            // cmbAño
            // 
            this.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(84, 55);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(229, 21);
            this.cmbAño.TabIndex = 1;
            this.cmbAño.TextChanged += new System.EventHandler(this.cmbAño_TextChanged);
            // 
            // btnLupaCar
            // 
            this.btnLupaCar.Location = new System.Drawing.Point(344, 21);
            this.btnLupaCar.Name = "btnLupaCar";
            this.btnLupaCar.Size = new System.Drawing.Size(24, 23);
            this.btnLupaCar.TabIndex = 8;
            this.btnLupaCar.Text = "button1";
            this.btnLupaCar.UseVisualStyleBackColor = true;
            this.btnLupaCar.Click += new System.EventHandler(this.btnLupaCar_Click);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(85, 23);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.ReadOnly = true;
            this.txtCarrera.Size = new System.Drawing.Size(229, 20);
            this.txtCarrera.TabIndex = 0;
            // 
            // btnLupaMat
            // 
            this.btnLupaMat.Location = new System.Drawing.Point(344, 87);
            this.btnLupaMat.Name = "btnLupaMat";
            this.btnLupaMat.Size = new System.Drawing.Size(24, 23);
            this.btnLupaMat.TabIndex = 10;
            this.btnLupaMat.Text = "button2";
            this.btnLupaMat.UseVisualStyleBackColor = true;
            this.btnLupaMat.Click += new System.EventHandler(this.btnLupaMat_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(140, 305);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(344, 185);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(24, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "button2";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(344, 227);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(24, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "button2";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // GrillaMatCorrelativas
            // 
            this.GrillaMatCorrelativas.AllowUserToAddRows = false;
            this.GrillaMatCorrelativas.AllowUserToDeleteRows = false;
            this.GrillaMatCorrelativas.AllowUserToResizeColumns = false;
            this.GrillaMatCorrelativas.AllowUserToResizeRows = false;
            this.GrillaMatCorrelativas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GrillaMatCorrelativas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaMatCorrelativas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GrillaMatCorrelativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaMatCorrelativas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriaID,
            this.Nombre,
            this.Año,
            this.CargaHoraria});
            this.GrillaMatCorrelativas.Location = new System.Drawing.Point(24, 115);
            this.GrillaMatCorrelativas.Name = "GrillaMatCorrelativas";
            this.GrillaMatCorrelativas.ReadOnly = true;
            this.GrillaMatCorrelativas.RowHeadersVisible = false;
            this.GrillaMatCorrelativas.RowHeadersWidth = 48;
            this.GrillaMatCorrelativas.Size = new System.Drawing.Size(300, 184);
            this.GrillaMatCorrelativas.TabIndex = 15;
            // 
            // MateriaID
            // 
            this.MateriaID.HeaderText = "MateriaID";
            this.MateriaID.Name = "MateriaID";
            this.MateriaID.ReadOnly = true;
            this.MateriaID.Visible = false;
            this.MateriaID.Width = 5;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 195;
            // 
            // Año
            // 
            this.Año.FillWeight = 10F;
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Width = 50;
            // 
            // CargaHoraria
            // 
            this.CargaHoraria.HeaderText = "Carga Horaria";
            this.CargaHoraria.Name = "CargaHoraria";
            this.CargaHoraria.ReadOnly = true;
            this.CargaHoraria.Width = 50;
            // 
            // Correlativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 337);
            this.Controls.Add(this.GrillaMatCorrelativas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLupaMat);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.btnLupaCar);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Correlativas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correlatividades";
            this.Load += new System.EventHandler(this.Correlativas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMatCorrelativas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Button btnLupaCar;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Button btnLupaMat;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView GrillaMatCorrelativas;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn CargaHoraria;
    }
}