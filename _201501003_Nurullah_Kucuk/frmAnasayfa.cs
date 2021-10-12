using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201501003_Nurullah_Kucuk
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            timer10Sec.Enabled = true;
        }
        public void timer10Sec_Tick(object sender, EventArgs e)
        {
            this.Hide();
            frmKullaniciGiris frm1 = new frmKullaniciGiris();
            frm1.Visible = true;
            timer10Sec.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKullaniciGiris frm1 = new frmKullaniciGiris();
            frm1.Visible = true;
            timer10Sec.Enabled = false;
        }
    }
}
