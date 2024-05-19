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
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.AbsolutePath != "about:blank" && webBrowser1.DocumentTitle == "Sayfa Bulunamadı")
            {
                MessageBox.Show("Hedef URL'ye ulaşılamıyor.");
            }
        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.hurriyet.com.tr");
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.milliyet.com.tr");

        }

        private void btnSozcu_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.sozcu.com.tr");
        }

        private void btnHaberturk_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.haberturk.com.tr");
        }

        private void btnFanatik_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.fanatik.com.tr");
        }

        private void btnOnedio_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.onedio.com");
        }
        //Bu kod, tarayıcının DocumentCompleted etkinliğini
        //kullanarak sayfanın yüklenip yüklenmediğini kontrol eder.
    }
}
