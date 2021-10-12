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
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplam=0;
        string dosyaKayit = @"c:\gorsel\kayit.txt";
        
        private void frmKullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {
            SayiUret();
            bool dosyaVarMi = File.Exists(dosyaKayit);
            if (dosyaVarMi)
                lblDosyaBilgi.Text = "Kayıt Dosyası Var";
            else
            {
                using (File.Create(dosyaKayit))
                {
                }
                lblDosyaBilgi.Text = "Kayıt Dosyası Oluşturuldu";
            }
        }
        public void SayiUret()
        {
            int sayi1 = rastgele.Next(0, 100);
            int sayi2 = rastgele.Next(0, 100);
            lblsayi1.Text = (sayi1 + " + " + sayi2 + " = ").ToString();
            toplam = sayi1 + sayi2;
        }

        private void lblKayitol_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit frmKayit = new frmKullaniciKayit();
            frmKayit.ShowDialog();
        }

        public void btnGirisYap_Click(object sender, EventArgs e)
        {
            
            if ((!mskTcNo.MaskFull) || txtSifre.Text == "" || txtSonuc.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                SayiUret();
                return;
            }
                
            if (txtSifre.Text.Length < 6)
            {
                errorProvider1.SetError(txtSifre, "Şifre en az 6 karakter olmalıdır.");
                SayiUret();
                return;
            }
            if (txtSonuc.Text != toplam.ToString())
            {
                DialogResult sonuc = new DialogResult();
                sonuc = MessageBox.Show("Yanlış Topladın..", "Uyarı!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.Retry)
                {
                    SayiUret();
                    txtSifre.Text = null;
                    txtSonuc.Text = null;
                    txtSifre.Focus();
                }
                else
                    Application.Exit();
            }
            else
            {
                string[] satirlar = File.ReadAllLines(dosyaKayit);
                foreach (string satir in satirlar)
                {
                    string[] veriler = satir.Split(',');
                    if (veriler[4] == mskTcNo.Text && veriler[5] == txtSifre.Text)
                    {
                        MessageBox.Show("Giriş Başarılı");
                        frmOyunSayfasi frm = new frmOyunSayfasi();
                        frm.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı TC No veya şifre hatalı!");
                        SayiUret();
                        txtSifre.Text = null;
                        txtSonuc.Text = null;
                        txtSifre.Focus();
                    }
                }
            }
            


        }
    }
}
