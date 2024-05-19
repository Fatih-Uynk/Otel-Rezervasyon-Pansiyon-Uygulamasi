using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;
using System.IO;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmRadyoDinle : Form
    {
        public FrmRadyoDinle()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80/";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://b01c02nl.mediatriple.net/videoonlylive/mtsxxkzwwuqtglive/broadcast_5fead000e2128.smil/playlist.m3u8";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.204/;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        // Formun içerisinde tanımlı bir Windows Media Player nesnesi
        private WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();

        private void BtnCal_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text != "")
            {
                string filePath = txtFilePath.Text;

                if (File.Exists(filePath))
                {
                    mediaPlayer.URL = filePath;
                    mediaPlayer.controls.play();
                }
                else
                {
                    MessageBox.Show("Belirtilen dosya bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir dosya seçin.");
            }
        }

        private void Btndurdur_Click(object sender, EventArgs e)
        {
            mediaPlayer.controls.stop();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            mediaPlayer = null;
            Application.Exit(); // Uygulamayı kapat
        }
    }
}
