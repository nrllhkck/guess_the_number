using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201501003_Nurullah_Kucuk
{
    public partial class frmOyunSayfasi : Form
    {
        public frmOyunSayfasi()
        {
            InitializeComponent();
        }
        int hak = 0, sayi = 0;
        string dosyaOyun = @"c:\gorsel\oyun.txt";
        int sayac = 0;
        int tahmin = 0;
        Random rastgeleSayi = new Random();
        

        private void btnCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmOyunSayfasi_Load(object sender, EventArgs e)
        {
            if (File.Exists(dosyaOyun) == false)
            {
                using (File.Create(dosyaOyun))
                {
                }
            }
            string[] skorlar = File.ReadAllLines(dosyaOyun);
            foreach (string skor in skorlar)
            {
                string[] veriler = skor.Split(',');
                lstSkorboard.Items.Add(" Hak : " + veriler[0] + "--" + "Saniye" + veriler[1]);

            }

        }
        private void tmrSayac_Tick(object sender, EventArgs e)
        {
            sayac = Convert.ToInt32(lblSayac.Text);
            sayac++;
            lblSayac.Text = sayac.ToString();
        }
 
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            hak++;
            tahmin = Convert.ToInt32(txtTahmin.Text);
            txtTahmin.Clear();
            txtTahmin.Focus();
            if (tahmin == 0 || tahmin > 100)
            {
                lblBilgi.Text = " Lütfen 1-100 arasında bir sayı girin.";
            }
            else if (tahmin > sayi)
                lblBilgi.Text = tahmin + " 'den küçük sayı girin.";
            else if (tahmin < sayi)
                lblBilgi.Text = tahmin + " 'den büyük sayı girin.";
            
            else
            {
                lblBilgi.Visible = false;
                tmrSayac.Enabled = false;
                MessageBox.Show("KAZANDINIZ. Yeniden oynamak istiyorsanız 'Yeni Oyun' butonuna tıklayın.");
                using (StreamWriter dosya = new StreamWriter(dosyaOyun, true))
                {

                    string satir = hak + "," + lblSayac.Text + "," + DateTime.Now.ToString();
                    dosya.WriteLine(satir);

                }
            }
        }
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            sayi = rastgeleSayi.Next(1, 101);
            lblBilgi.Visible = true;
            txtTahmin.Visible = true;
            lblSayac.Visible = true;
            tmrSayac.Enabled = true;
            lblBilgi.Text = "1 ile 100 arası bir sayı tahmin edin.";
            lblSayac.Text = "0";
        }


        private void frmOyunSayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtTahmin_TextChanged(object sender, EventArgs e)
        {
            btnTahmin.Visible = true;
        }

        
    }
}
