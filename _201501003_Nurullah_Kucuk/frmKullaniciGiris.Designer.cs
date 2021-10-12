
namespace _201501003_Nurullah_Kucuk
{
    partial class frmKullaniciGiris
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
            this.lblTc = new System.Windows.Forms.Label();
            this.lblsfr = new System.Windows.Forms.Label();
            this.mskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblsayi1 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKayitol = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDosyaBilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTc.Location = new System.Drawing.Point(12, 111);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(81, 25);
            this.lblTc.TabIndex = 0;
            this.lblTc.Text = "TC No :";
            // 
            // lblsfr
            // 
            this.lblsfr.AutoSize = true;
            this.lblsfr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsfr.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblsfr.Location = new System.Drawing.Point(30, 153);
            this.lblsfr.Name = "lblsfr";
            this.lblsfr.Size = new System.Drawing.Size(63, 25);
            this.lblsfr.TabIndex = 1;
            this.lblsfr.Text = "Şifre :";
            // 
            // mskTcNo
            // 
            this.mskTcNo.Location = new System.Drawing.Point(104, 113);
            this.mskTcNo.Mask = "00000000000";
            this.mskTcNo.Name = "mskTcNo";
            this.mskTcNo.Size = new System.Drawing.Size(226, 22);
            this.mskTcNo.TabIndex = 2;
            this.mskTcNo.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(104, 153);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(226, 25);
            this.txtSifre.TabIndex = 3;
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisBaslik.ForeColor = System.Drawing.Color.Sienna;
            this.lblGirisBaslik.Location = new System.Drawing.Point(97, 35);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(233, 39);
            this.lblGirisBaslik.TabIndex = 4;
            this.lblGirisBaslik.Text = "Kullanıcı Girişi";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(273, 195);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(56, 39);
            this.txtSonuc.TabIndex = 5;
            // 
            // lblsayi1
            // 
            this.lblsayi1.AutoSize = true;
            this.lblsayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsayi1.Location = new System.Drawing.Point(168, 209);
            this.lblsayi1.Name = "lblsayi1";
            this.lblsayi1.Size = new System.Drawing.Size(72, 25);
            this.lblsayi1.TabIndex = 6;
            this.lblsayi1.Text = "Sayılar";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGirisYap.Location = new System.Drawing.Point(104, 253);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(225, 40);
            this.btnGirisYap.TabIndex = 10;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(101, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hesabınız Yok mu?";
            // 
            // lblKayitol
            // 
            this.lblKayitol.AutoSize = true;
            this.lblKayitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitol.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblKayitol.Location = new System.Drawing.Point(273, 305);
            this.lblKayitol.Name = "lblKayitol";
            this.lblKayitol.Size = new System.Drawing.Size(57, 17);
            this.lblKayitol.TabIndex = 12;
            this.lblKayitol.Text = "Kayıt Ol";
            this.lblKayitol.Click += new System.EventHandler(this.lblKayitol_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblDosyaBilgi
            // 
            this.lblDosyaBilgi.AutoSize = true;
            this.lblDosyaBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDosyaBilgi.Location = new System.Drawing.Point(17, 354);
            this.lblDosyaBilgi.Name = "lblDosyaBilgi";
            this.lblDosyaBilgi.Size = new System.Drawing.Size(21, 20);
            this.lblDosyaBilgi.TabIndex = 13;
            this.lblDosyaBilgi.Text = "...";
            // 
            // frmKullaniciGiris
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 383);
            this.Controls.Add(this.lblDosyaBilgi);
            this.Controls.Add(this.lblKayitol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lblsayi1);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.lblGirisBaslik);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskTcNo);
            this.Controls.Add(this.lblsfr);
            this.Controls.Add(this.lblTc);
            this.Name = "frmKullaniciGiris";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 201501003 - Nurullah Küçük";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKullaniciGiris_FormClosed);
            this.Load += new System.EventHandler(this.frmKullaniciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblsfr;
        private System.Windows.Forms.MaskedTextBox mskTcNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblGirisBaslik;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lblsayi1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKayitol;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblDosyaBilgi;
    }
}