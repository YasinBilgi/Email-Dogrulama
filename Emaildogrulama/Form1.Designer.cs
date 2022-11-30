namespace Emaildogrulama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btngırısyap = new System.Windows.Forms.Button();
            this.lblEmailDogrulama = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngırısyap
            // 
            this.btngırısyap.Location = new System.Drawing.Point(83, 263);
            this.btngırısyap.Name = "btngırısyap";
            this.btngırısyap.Size = new System.Drawing.Size(111, 38);
            this.btngırısyap.TabIndex = 0;
            this.btngırısyap.Text = "Giriş Yap";
            this.btngırısyap.UseVisualStyleBackColor = true;
            this.btngırısyap.Click += new System.EventHandler(this.btngırısyap_Click);
            // 
            // lblEmailDogrulama
            // 
            this.lblEmailDogrulama.AutoSize = true;
            this.lblEmailDogrulama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmailDogrulama.Location = new System.Drawing.Point(272, 132);
            this.lblEmailDogrulama.Name = "lblEmailDogrulama";
            this.lblEmailDogrulama.Size = new System.Drawing.Size(39, 20);
            this.lblEmailDogrulama.TabIndex = 1;
            this.lblEmailDogrulama.Text = "lbl1";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(272, 202);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(39, 20);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "lbl2";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(83, 126);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(111, 34);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(83, 196);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(111, 35);
            this.txtSifre.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblEmailDogrulama);
            this.Controls.Add(this.btngırısyap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngırısyap;
        private System.Windows.Forms.Label lblEmailDogrulama;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifre;
    }
}

