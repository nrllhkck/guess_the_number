
namespace _201501003_Nurullah_Kucuk
{
    partial class frmKullaniciKayit
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
            this.lblKayitBaslik = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDogum = new System.Windows.Forms.NumericUpDown();
            this.lblDogum = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mskdTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDogum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKayitBaslik
            // 
            this.lblKayitBaslik.AutoSize = true;
            this.lblKayitBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitBaslik.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblKayitBaslik.Location = new System.Drawing.Point(178, 9);
            this.lblKayitBaslik.Name = "lblKayitBaslik";
            this.lblKayitBaslik.Size = new System.Drawing.Size(273, 44);
            this.lblKayitBaslik.TabIndex = 0;
            this.lblKayitBaslik.Text = "Kullanıcı Kayıt";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(43, 227);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(86, 25);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "TC No : ";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(76, 84);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(53, 25);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(61, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre : ";
            // 
            // numDogum
            // 
            this.numDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDogum.Location = new System.Drawing.Point(135, 176);
            this.numDogum.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numDogum.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numDogum.Name = "numDogum";
            this.numDogum.Size = new System.Drawing.Size(150, 26);
            this.numDogum.TabIndex = 2;
            this.numDogum.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // lblDogum
            // 
            this.lblDogum.AutoSize = true;
            this.lblDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogum.Location = new System.Drawing.Point(8, 177);
            this.lblDogum.Name = "lblDogum";
            this.lblDogum.Size = new System.Drawing.Size(121, 25);
            this.lblDogum.TabIndex = 6;
            this.lblDogum.Text = "Doğum Yılı : ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(135, 76);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(243, 33);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(135, 122);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(243, 33);
            this.txtSoyad.TabIndex = 1;
            // 
            // mskdTc
            // 
            this.mskdTc.Location = new System.Drawing.Point(135, 230);
            this.mskdTc.Mask = "00000000000";
            this.mskdTc.Name = "mskdTc";
            this.mskdTc.Size = new System.Drawing.Size(150, 22);
            this.mskdTc.TabIndex = 3;
            this.mskdTc.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(135, 269);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(243, 33);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(425, 76);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(184, 79);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "K A Y D E T";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(13, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dikkat! TC-Kimlik doğrulaması yapılacaktır.";
            // 
            // frmKullaniciKayit
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskdTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblDogum);
            this.Controls.Add(this.numDogum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblKayitBaslik);
            this.Name = "frmKullaniciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "201501003 - Nurullah Küçük";
            ((System.ComponentModel.ISupportInitialize)(this.numDogum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKayitBaslik;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDogum;
        private System.Windows.Forms.Label lblDogum;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mskdTc;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
    }
}