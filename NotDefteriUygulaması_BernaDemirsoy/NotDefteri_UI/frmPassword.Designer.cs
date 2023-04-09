namespace NotDefteri_UI
{
    partial class frmPassword
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yeni Şifre Tekrar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yeni Şifre:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eski Şifre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(168, 33);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(217, 24);
            this.txtEskiSifre.TabIndex = 8;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(168, 85);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(217, 24);
            this.txtYeniSifre.TabIndex = 9;
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(168, 134);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(217, 24);
            this.txtYeniSifreTekrar.TabIndex = 10;
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.Location = new System.Drawing.Point(70, 190);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(315, 37);
            this.btnSifreDegistir.TabIndex = 11;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = true;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 252);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.txtYeniSifreTekrar);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtEskiSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmPassword";
            this.Text = "frmPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPassword_FormClosing);
            this.Load += new System.EventHandler(this.frmPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.Button btnSifreDegistir;
    }
}