namespace Sistema.FE
{
    partial class CambiarContraseña1
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
            this.bAceptarCambiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraRepet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContraAnt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAceptarCambiar
            // 
            this.bAceptarCambiar.Location = new System.Drawing.Point(123, 104);
            this.bAceptarCambiar.Name = "bAceptarCambiar";
            this.bAceptarCambiar.Size = new System.Drawing.Size(75, 23);
            this.bAceptarCambiar.TabIndex = 5;
            this.bAceptarCambiar.Text = "Aceptar";
            this.bAceptarCambiar.UseVisualStyleBackColor = true;
            this.bAceptarCambiar.Click += new System.EventHandler(this.bAceptarCambiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nueva Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(112, 39);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(197, 20);
            this.txtContra.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Repetir Contraseña";
            // 
            // txtContraRepet
            // 
            this.txtContraRepet.Location = new System.Drawing.Point(112, 65);
            this.txtContraRepet.Name = "txtContraRepet";
            this.txtContraRepet.Size = new System.Drawing.Size(197, 20);
            this.txtContraRepet.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contraseña Anterior";
            // 
            // txtContraAnt
            // 
            this.txtContraAnt.Location = new System.Drawing.Point(112, 12);
            this.txtContraAnt.Name = "txtContraAnt";
            this.txtContraAnt.Size = new System.Drawing.Size(197, 20);
            this.txtContraAnt.TabIndex = 7;
            // 
            // CambiarContraseña1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 134);
            this.Controls.Add(this.txtContraRepet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContraAnt);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAceptarCambiar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambiarContraseña1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarContraseña1";
            this.Load += new System.EventHandler(this.CambiarContraseña1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAceptarCambiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraRepet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContraAnt;
    }
}