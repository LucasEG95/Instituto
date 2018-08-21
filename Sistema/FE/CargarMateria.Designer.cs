namespace Sistema.FE
{
    partial class CargarMateria
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
            this.components = new System.ComponentModel.Container();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPromocional = new System.Windows.Forms.CheckBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.btnLupaProf = new System.Windows.Forms.Button();
            this.btnLupaMat = new System.Windows.Forms.Button();
            this.btnLupaCar = new System.Windows.Forms.Button();
            this.dSCarrera = new Sistema.DS.DSCarrera();
            this.dSCarreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCarreraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(172, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(47, 175);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 19;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Horas";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(107, 117);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(156, 20);
            this.txtHoras.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Año";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(107, 91);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(156, 20);
            this.txtAño.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Materia";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(107, 39);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(156, 20);
            this.txtMateria.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Carrera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Promocional";
            // 
            // chkPromocional
            // 
            this.chkPromocional.AutoSize = true;
            this.chkPromocional.Location = new System.Drawing.Point(107, 148);
            this.chkPromocional.Name = "chkPromocional";
            this.chkPromocional.Size = new System.Drawing.Size(15, 14);
            this.chkPromocional.TabIndex = 23;
            this.chkPromocional.UseVisualStyleBackColor = true;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carreraBindingSource, "Carrera", true));
            this.cmbCarrera.DataSource = this.carreraBindingSource;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(107, 12);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(156, 21);
            this.cmbCarrera.TabIndex = 24;
            this.cmbCarrera.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Profesor";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(107, 65);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(156, 20);
            this.txtProfesor.TabIndex = 26;
            // 
            // btnLupaProf
            // 
            this.btnLupaProf.Location = new System.Drawing.Point(269, 63);
            this.btnLupaProf.Name = "btnLupaProf";
            this.btnLupaProf.Size = new System.Drawing.Size(28, 23);
            this.btnLupaProf.TabIndex = 28;
            this.btnLupaProf.Text = "Cargar";
            this.btnLupaProf.UseVisualStyleBackColor = true;
            // 
            // btnLupaMat
            // 
            this.btnLupaMat.Location = new System.Drawing.Point(269, 37);
            this.btnLupaMat.Name = "btnLupaMat";
            this.btnLupaMat.Size = new System.Drawing.Size(28, 23);
            this.btnLupaMat.TabIndex = 29;
            this.btnLupaMat.Text = "Cargar";
            this.btnLupaMat.UseVisualStyleBackColor = true;
            // 
            // btnLupaCar
            // 
            this.btnLupaCar.Location = new System.Drawing.Point(270, 12);
            this.btnLupaCar.Name = "btnLupaCar";
            this.btnLupaCar.Size = new System.Drawing.Size(28, 23);
            this.btnLupaCar.TabIndex = 30;
            this.btnLupaCar.Text = "Cargar";
            this.btnLupaCar.UseVisualStyleBackColor = true;
            // 
            // dSCarrera
            // 
            this.dSCarrera.DataSetName = "DSCarrera";
            this.dSCarrera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSCarreraBindingSource
            // 
            this.dSCarreraBindingSource.DataSource = this.dSCarrera;
            this.dSCarreraBindingSource.Position = 0;
            // 
            // carreraBindingSource
            // 
            this.carreraBindingSource.DataMember = "Carrera";
            this.carreraBindingSource.DataSource = this.dSCarreraBindingSource;
            // 
            // CargarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 214);
            this.Controls.Add(this.btnLupaCar);
            this.Controls.Add(this.btnLupaMat);
            this.Controls.Add(this.btnLupaProf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.chkPromocional);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.label1);
            this.Name = "CargarMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargarMateria";
            this.Load += new System.EventHandler(this.CargarMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCarreraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPromocional;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.Button btnLupaProf;
        private System.Windows.Forms.Button btnLupaMat;
        private System.Windows.Forms.Button btnLupaCar;
        private System.Windows.Forms.BindingSource dSCarreraBindingSource;
        private DS.DSCarrera dSCarrera;
        private System.Windows.Forms.BindingSource carreraBindingSource;
    }
}