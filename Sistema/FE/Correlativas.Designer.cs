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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.btnLupaCar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLupaMat = new System.Windows.Forms.Button();
            this.ltxtCorrela = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 5;
            // 
            // cmbAño
            // 
            this.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(84, 55);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(186, 21);
            this.cmbAño.TabIndex = 7;
            // 
            // btnLupaCar
            // 
            this.btnLupaCar.Location = new System.Drawing.Point(289, 21);
            this.btnLupaCar.Name = "btnLupaCar";
            this.btnLupaCar.Size = new System.Drawing.Size(24, 23);
            this.btnLupaCar.TabIndex = 8;
            this.btnLupaCar.Text = "button1";
            this.btnLupaCar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 9;
            // 
            // btnLupaMat
            // 
            this.btnLupaMat.Location = new System.Drawing.Point(289, 87);
            this.btnLupaMat.Name = "btnLupaMat";
            this.btnLupaMat.Size = new System.Drawing.Size(24, 23);
            this.btnLupaMat.TabIndex = 10;
            this.btnLupaMat.Text = "button2";
            this.btnLupaMat.UseVisualStyleBackColor = true;
            // 
            // ltxtCorrela
            // 
            this.ltxtCorrela.Enabled = false;
            this.ltxtCorrela.FormattingEnabled = true;
            this.ltxtCorrela.Location = new System.Drawing.Point(25, 147);
            this.ltxtCorrela.Name = "ltxtCorrela";
            this.ltxtCorrela.Size = new System.Drawing.Size(246, 147);
            this.ltxtCorrela.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Correlativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ltxtCorrela);
            this.Controls.Add(this.btnLupaMat);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnLupaCar);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Correlativas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correlatividades";
            this.Load += new System.EventHandler(this.Correlativas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Button btnLupaCar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnLupaMat;
        private System.Windows.Forms.ListBox ltxtCorrela;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}