using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient; //Son iki kütüphaneyi ben ekledim sql ile bağlantı sağlamak için. 

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8ICRKKM\\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True;Encrypt=False");
        //SqlConnection sınıfı, SQL Server veritabanına bağlanmak için kullanılan sınıftır.
        //Bu sınıf, SqlConnection nesnesi oluşturarak veritabanına bağlantı sağlar.

        //new SqlConnection("Data Source=DESKTOP-8ICRKKM\\SQLEXPRESS01;
        //SqlConnection sınıfının kurucu metodunu çağırır ve bir bağlantı dizesi sağlar.

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
            }
            //------------------------------------------------------------------------------------------

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
            }
            //-----------------------------------------------------------------------------------------

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
            }
            //------------------------------------------------------------------------------------------

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
            }
            //-------------------------------------------------------------------------------------------

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
            }
            //---------------------------------------------------------------------------------------------

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
            }
            //---------------------------------------------------------------------------------------------

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
            }
            //--------------------------------------------------------------------------------------------

            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
            }
            //---------------------------------------------------------------------------------------------

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
            }

            //---------------------------------------------------------------------------------------------

            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("select * from Oda110", baglanti);
            SqlDataReader oku10 = komut10.ExecuteReader();

            while (oku10.Read())
            {
                BtnOda110.Text = oku10["Adi"].ToString() + " " + oku10["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda110.Text != "110")
            {
                BtnOda110.BackColor = Color.Red;
            }

            //----------------------------------------------------------------------------------------------

            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("select * from Oda111", baglanti);
            SqlDataReader oku11 = komut11.ExecuteReader();

            while (oku11.Read())
            {
                BtnOda111.Text = oku11["Adi"].ToString() + " " + oku11["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda111.Text != "111")
            {
                BtnOda111.BackColor = Color.Red;
            }

            //----------------------------------------------------------------------------------------------

            baglanti.Open();
            SqlCommand komut12 = new SqlCommand("select * from Oda112", baglanti);
            SqlDataReader oku12 = komut12.ExecuteReader();

            while (oku12.Read())
            {
                BtnOda112.Text = oku12["Adi"].ToString() + " " + oku12["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda112.Text != "112")
            {
                BtnOda112.BackColor = Color.Red;
            }
        }
        private void FiltreleVeRenklendir()
        {
            DateTime girisTarihi = dtpGirisTarihi.Value.Date;
            DateTime cikisTarihi = dtpCikisTarihi.Value.Date;

            // Giriş tarihinin çıkış tarihinden önce olup olmadığını kontrol et
            if (girisTarihi>cikisTarihi)
            {
                MessageBox.Show("Çıkış tarihi giriş tarihinden önce olamaz!", "Tarih Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // İşlemi sonlandır
            }


            // Seçilen kişi sayısını al
            int kisiSayisi = 0;
            if (rb1Kisilik.Checked)
                kisiSayisi = 1;
            else if (rb2Kisilik.Checked)
                kisiSayisi = 2;
            else if (rb3Kisilik.Checked)
                kisiSayisi = 3;

            // Odaları tekrar varsayılan renge döndür
            RenkleriVarsayilanaDon();

            // Bağlantıyı aç
            baglanti.Open();
            

            // Tüm odaları kontrol et
            for (int i = 101; i <= 112; i++)
            {
                string odaNumarasi = i.ToString("D3"); // Oda numarasını 3 haneli stringe çevir

                // Odada kimse yoksa
                SqlCommand komut = new SqlCommand($"SELECT COUNT(*) FROM MusteriEkle WHERE OdaNo = @OdaNo AND (@GirisTarihi <= CikisTarihi AND @CikisTarihi >= GirisTarihi)", baglanti);
                komut.Parameters.AddWithValue("@OdaNo", odaNumarasi);
                komut.Parameters.AddWithValue("@GirisTarihi", girisTarihi);
                komut.Parameters.AddWithValue("@CikisTarihi", cikisTarihi);
                komut.Parameters.AddWithValue("@KisiSayisi", kisiSayisi);
                int doluOdaSayisi = (int)komut.ExecuteScalar();

                if (doluOdaSayisi == 0)
                {
                    // Odanın rengini değiştir
                    Controls[$"BtnOda{odaNumarasi}"].BackColor = Color.Gray;
                }
                else
                {
                    // Dolu oda, rengini değiştirme
                    Controls[$"BtnOda{odaNumarasi}"].BackColor = Color.Red;
                }
            }

            // Bağlantıyı kapat
            baglanti.Close();
        }
        private void RenkleriVarsayilanaDon()
        {
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    if (control.Name.StartsWith("BtnOda"))
                    {
                        control.BackColor = Control.DefaultBackColor;
                    }
                }
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            // RadioButton'ların seçili olup olmadığını kontrol et
            if (!rb1Kisilik.Checked && !rb2Kisilik.Checked && !rb3Kisilik.Checked)
            {
                MessageBox.Show("Lütfen kişi sayısını seçin!", "Seçim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi sonlandır
            }


            // Giriş ve çıkış tarihlerini kontrol et ve uygun değilse işlemi sonlandır
            DateTime girisTarihi = dtpGirisTarihi.Value.Date;
            DateTime cikisTarihi = dtpCikisTarihi.Value.Date;

            if (girisTarihi > cikisTarihi)
            {
                MessageBox.Show("Çıkış tarihi giriş tarihinden önce olamaz!", "Tarih Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FiltreleVeRenklendir();
        }
    }
}
