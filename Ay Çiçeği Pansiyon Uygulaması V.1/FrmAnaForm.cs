using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frm = new FrmYeniMusteri();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             FrmOdalar fr = new FrmOdalar();    
             fr.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayçiçeği Otel Rezervasyon Uygulaması / 2024 - Ankara");
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();//Timer başlangıçta pasif olarak gelir.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();

            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();//Exit bir metod olduğu için parantez aç-kapa yaptık çıkış yapıldı.
        }

        private void BtnGelirGiderFrm_Click(object sender, EventArgs e)
        {
            FrmGelirGider frm = new FrmGelirGider();
            frm.Show();
        }

        private void BtnStoklar_Click(object sender, EventArgs e)
        {
            FrmStoklar frm = new FrmStoklar();
            frm.Show();
        }

        private void BtnRadyoDinle_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle fr = new FrmRadyoDinle();
            fr.Show();
        }

        private void BtnGazeteler_Click(object sender, EventArgs e)
        {
            FrmGazeteler frm = new FrmGazeteler();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmSifreGüncelle frm = new FrmSifreGüncelle();
            frm.Show();
        }

        private void BtnMüsteriMsjlar_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.Show();
        }
    }
}
