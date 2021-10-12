
namespace _201501003_Nurullah_Kucuk
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblBaslik4 = new System.Windows.Forms.Label();
            this.lblBaslik3 = new System.Windows.Forms.Label();
            this.lblBaslik2 = new System.Windows.Forms.Label();
            this.lblBaslik1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer10Sec = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.BackColor = System.Drawing.Color.Transparent;
            this.lblOgrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrNo.ForeColor = System.Drawing.Color.White;
            this.lblOgrNo.Location = new System.Drawing.Point(294, 449);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(111, 25);
            this.lblOgrNo.TabIndex = 15;
            this.lblOgrNo.Text = "201501003";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.White;
            this.lblAdSoyad.Location = new System.Drawing.Point(271, 404);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(160, 25);
            this.lblAdSoyad.TabIndex = 14;
            this.lblAdSoyad.Text = "Nurullah KÜÇÜK";
            // 
            // lblBaslik4
            // 
            this.lblBaslik4.AutoSize = true;
            this.lblBaslik4.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslik4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslik4.Location = new System.Drawing.Point(158, 350);
            this.lblBaslik4.Name = "lblBaslik4";
            this.lblBaslik4.Size = new System.Drawing.Size(358, 24);
            this.lblBaslik4.TabIndex = 12;
            this.lblBaslik4.Text = "Görsel Programlama 1 - Final Proje Ödevi";
            // 
            // lblBaslik3
            // 
            this.lblBaslik3.AutoSize = true;
            this.lblBaslik3.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslik3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslik3.Location = new System.Drawing.Point(133, 291);
            this.lblBaslik3.Name = "lblBaslik3";
            this.lblBaslik3.Size = new System.Drawing.Size(403, 31);
            this.lblBaslik3.TabIndex = 11;
            this.lblBaslik3.Text = "BİLGİSAYAR PROGRAMCILIĞI";
            // 
            // lblBaslik2
            // 
            this.lblBaslik2.AutoSize = true;
            this.lblBaslik2.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslik2.Location = new System.Drawing.Point(87, 246);
            this.lblBaslik2.Name = "lblBaslik2";
            this.lblBaslik2.Size = new System.Drawing.Size(492, 31);
            this.lblBaslik2.TabIndex = 10;
            this.lblBaslik2.Text = "AKÇAKOCA MESLEK YÜKSEKOKULU";
            // 
            // lblBaslik1
            // 
            this.lblBaslik1.AutoSize = true;
            this.lblBaslik1.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslik1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslik1.Location = new System.Drawing.Point(185, 205);
            this.lblBaslik1.Name = "lblBaslik1";
            this.lblBaslik1.Size = new System.Drawing.Size(307, 31);
            this.lblBaslik1.TabIndex = 9;
            this.lblBaslik1.Text = "DÜZCE ÜNİVERSİTESİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer10Sec
            // 
            this.timer10Sec.Interval = 10000;
            this.timer10Sec.Tick += new System.EventHandler(this.timer10Sec_Tick);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(682, 713);
            this.Controls.Add(this.lblOgrNo);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblBaslik4);
            this.Controls.Add(this.lblBaslik3);
            this.Controls.Add(this.lblBaslik2);
            this.Controls.Add(this.lblBaslik1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAnasayfa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "201501003 - Nurullah Küçük";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrNo;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblBaslik4;
        private System.Windows.Forms.Label lblBaslik3;
        private System.Windows.Forms.Label lblBaslik2;
        private System.Windows.Forms.Label lblBaslik1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer10Sec;
    }
}

