namespace WindowsLoginForm
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
            this.girisButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisKullaniciAdi = new System.Windows.Forms.TextBox();
            this.girisSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // girisButon
            // 
            this.girisButon.Location = new System.Drawing.Point(341, 175);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(211, 23);
            this.girisButon.TabIndex = 0;
            this.girisButon.Text = "Giriş Yap";
            this.girisButon.UseVisualStyleBackColor = true;
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // girisKullaniciAdi
            // 
            this.girisKullaniciAdi.Location = new System.Drawing.Point(341, 104);
            this.girisKullaniciAdi.Multiline = true;
            this.girisKullaniciAdi.Name = "girisKullaniciAdi";
            this.girisKullaniciAdi.Size = new System.Drawing.Size(211, 20);
            this.girisKullaniciAdi.TabIndex = 3;
            // 
            // girisSifre
            // 
            this.girisSifre.Location = new System.Drawing.Point(341, 139);
            this.girisSifre.Multiline = true;
            this.girisSifre.Name = "girisSifre";
            this.girisSifre.PasswordChar = '*';
            this.girisSifre.Size = new System.Drawing.Size(211, 20);
            this.girisSifre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(342, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Students On Cloud";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(898, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.girisSifre);
            this.Controls.Add(this.girisKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girisButon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox girisKullaniciAdi;
        private System.Windows.Forms.TextBox girisSifre;
        private System.Windows.Forms.Label label3;
    }
}

