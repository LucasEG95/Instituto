namespace Sistema.FE
{
    partial class PrimeraContraseña
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
            this.txtPreguntaSecret = new System.Windows.Forms.TextBox();
            this.txtRespuestaSecret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevaContra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepetirContraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta Secreta";
            // 
            // txtPreguntaSecret
            // 
            this.txtPreguntaSecret.Location = new System.Drawing.Point(141, 29);
            this.txtPreguntaSecret.Name = "txtPreguntaSecret";
            this.txtPreguntaSecret.Size = new System.Drawing.Size(195, 20);
            this.txtPreguntaSecret.TabIndex = 1;
            // 
            // txtRespuestaSecret
            // 
            this.txtRespuestaSecret.Location = new System.Drawing.Point(141, 67);
            this.txtRespuestaSecret.Name = "txtRespuestaSecret";
            this.txtRespuestaSecret.Size = new System.Drawing.Size(195, 20);
            this.txtRespuestaSecret.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Respuesta Secreta";
            // 
            // txtNuevaContra
            // 
            this.txtNuevaContra.Location = new System.Drawing.Point(141, 105);
            this.txtNuevaContra.Name = "txtNuevaContra";
            this.txtNuevaContra.Size = new System.Drawing.Size(195, 20);
            this.txtNuevaContra.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva Contraseña";
            // 
            // txtRepetirContraseña
            // 
            this.txtRepetirContraseña.Location = new System.Drawing.Point(141, 142);
            this.txtRepetirContraseña.Name = "txtRepetirContraseña";
            this.txtRepetirContraseña.Size = new System.Drawing.Size(195, 20);
            this.txtRepetirContraseña.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Repetir Contraseña";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(150, 198);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // PrimeraContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 247);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txtRepetirContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNuevaContra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRespuestaSecret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreguntaSecret);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrimeraContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimeraContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreguntaSecret;
        private System.Windows.Forms.TextBox txtRespuestaSecret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevaContra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRepetirContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAceptar;
    }
}