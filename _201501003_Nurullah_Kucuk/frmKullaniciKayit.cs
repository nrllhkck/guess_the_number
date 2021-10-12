using _201501003_Nurullah_Kucuk.MernisDogrula;
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
    public partial class frmKullaniciKayit : Form
    {
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }
        string dosyaKayit = @"c:\gorsel\kayit.txt";
        string dosyaHata = @"c:\gorsel\hata.txt";
        

        bool sonuc;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // kaydete basıldığında dosya yoksa oluştur.
            if (File.Exists(dosyaKayit) == false)
            {
                using (File.Create(dosyaKayit))
                {
                }
            }
            if (File.Exists(dosyaHata) == false)
            {
                using (File.Create(dosyaHata))
                {
                }
            }
            //var olan dosya içerisinde girilen değerlerde bir kullanıcı varmı kontrol et.
            

            // kullanıcı doldurulması gereken alanları boş bırakırsa uyarı ver.
            if ((!mskdTc.MaskFull) || txtAd.Text == "" || txtSoyad.Text == "" || txtSifre.Text == "")
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
            //şifre uzunluğunu kontrol et.
            if (txtSifre.Text.Length < 6)
            {
                MessageBox.Show("En az 6 karakter olmalıdır.", "Uyarı", MessageBoxButtons.OK);
                return;
            }

            try
            {
                string Ad = txtAd.Text;
                string Soyad = txtSoyad.Text;
                int dogumYili = Convert.ToInt32(numDogum.Text);
                long TCNo = Convert.ToInt64(mskdTc.Text);

                KPSPublicSoapClient sorgu = new KPSPublicSoapClient();
                sonuc = sorgu.TCKimlikNoDogrula(TCNo, Ad, Soyad, dogumYili);
                MessageBox.Show(sonuc.ToString());
            }

            catch (Exception hata)
            {
                string hataSatir;
                MessageBox.Show(hata.ToString());
                using (StreamWriter dosya = new StreamWriter(dosyaHata, true))
                {
                    
                    hataSatir = hata.ToString();
                    dosya.WriteLine(hataSatir);
                    MessageBox.Show("Bir hata oluştu.Lütfen sistem yöneticinize başvurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            string[] satirlar = File.ReadAllLines(dosyaKayit);
            foreach (string satir in satirlar)
            {
                string[] veriler = satir.Split(',');
                if (veriler[4] == mskdTc.Text)
                {
                    MessageBox.Show("Bu TC No ile kayıt var!", "Tc No Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (sonuc != true)
            {
                MessageBox.Show("Böyle bir kişi Merniste kayıtlı değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            else
            {
                using (StreamWriter dosya = new StreamWriter(dosyaKayit, true))
                {
                    string ad, soyad, tcNo, sifre, dogum;
                    string satir;
                    ad = txtAd.Text;
                    soyad = txtSoyad.Text;
                    tcNo = mskdTc.Text;
                    sifre = txtSifre.Text;
                    dogum = numDogum.Text;
                    satir = Guid.NewGuid() + "," + ad + "," + soyad + "," + dogum + "," + tcNo + "," + sifre;
                    dosya.WriteLine(satir);
                    MessageBox.Show("Durum : Kayıt Başarılı");
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            // şifre uzunluğu altı karakter olunca kaydet butonunu aktif et.
            if (txtSifre.Text.Length >= 6)
                btnKaydet.Enabled = true;
        }
    }
}
