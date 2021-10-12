
namespace _201501003_Nurullah_Kucuk
{
    partial class frmOyunSayfasi
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
            this.lstSkorboard = new System.Windows.Forms.ListBox();
            this.btnCik = new System.Windows.Forms.Button();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.lblSayac = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblBaslikOyun = new System.Windows.Forms.Label();
            this.tmrSayac = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstSkorboard
            // 
            this.lstSkorboard.BackColor = System.Drawing.Color.White;
            this.lstSkorboard.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSkorboard.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstSkorboard.FormattingEnabled = true;
            this.lstSkorboard.ItemHeight = 23;
            this.lstSkorboard.Location = new System.Drawing.Point(422, 133);
            this.lstSkorboard.Name = "lstSkorboard";
            this.lstSkorboard.Size = new System.Drawing.Size(342, 257);
            this.lstSkorboard.TabIndex = 23;
            // 
            // btnCik
            // 
            this.btnCik.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCik.Location = new System.Drawing.Point(248, 223);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(135, 64);
            this.btnCik.TabIndex = 21;
            this.btnCik.Text = "Çıkış";
            this.btnCik.UseVisualStyleBackColor = true;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.Location = new System.Drawing.Point(248, 148);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(135, 64);
            this.btnYeniOyun.TabIndex = 20;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.ForeColor = System.Drawing.Color.Red;
            this.lblSayac.Location = new System.Drawing.Point(740, 22);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(24, 26);
            this.lblSayac.TabIndex = 19;
            this.lblSayac.Text = "0";
            this.lblSayac.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(661, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Süre : ";
            this.label4.Visible = false;
            // 
            // btnTahmin
            // 
            this.btnTahmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahmin.Location = new System.Drawing.Point(19, 223);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(135, 64);
            this.btnTahmin.TabIndex = 17;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Visible = false;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Location = new System.Drawing.Point(19, 148);
            this.txtTahmin.Multiline = true;
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(78, 45);
            this.txtTahmin.TabIndex = 16;
            this.txtTahmin.Visible = false;
            this.txtTahmin.TextChanged += new System.EventHandler(this.txtTahmin_TextChanged);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBilgi.Location = new System.Drawing.Point(14, 82);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(369, 27);
            this.lblBilgi.TabIndex = 15;
            this.lblBilgi.Text = "1\'den 100\'e kadar bir sayı tahmin et";
            this.lblBilgi.Visible = false;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.BackColor = System.Drawing.Color.Transparent;
            this.lblSkor.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.ForeColor = System.Drawing.Color.Red;
            this.lblSkor.Location = new System.Drawing.Point(451, 80);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(313, 29);
            this.lblSkor.TabIndex = 14;
            this.lblSkor.Text = "Önceki Skorlar - Skorboard";
            this.lblSkor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBaslikOyun
            // 
            this.lblBaslikOyun.AutoSize = true;
            this.lblBaslikOyun.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslikOyun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBaslikOyun.Location = new System.Drawing.Point(12, 9);
            this.lblBaslikOyun.Name = "lblBaslikOyun";
            this.lblBaslikOyun.Size = new System.Drawing.Size(274, 40);
            this.lblBaslikOyun.TabIndex = 13;
            this.lblBaslikOyun.Text = "Sayı Tahmin Oyunu";
            this.lblBaslikOyun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSayac
            // 
            this.tmrSayac.Interval = 1000;
            this.tmrSayac.Tick += new System.EventHandler(this.tmrSayac_Tick);
            // 
            // frmOyunSayfasi
            // 
            this.AcceptButton = this.btnTahmin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 473);
            this.Controls.Add(this.lstSkorboard);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblBaslikOyun);
            this.Name = "frmOyunSayfasi";
            this.Text = "201501003 - Nurullah Küçük";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOyunSayfasi_FormClosed);
            this.Load += new System.EventHandler(this.frmOyunSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSkorboard;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblBaslikOyun;
        private System.Windows.Forms.Timer tmrSayac;
    }
}