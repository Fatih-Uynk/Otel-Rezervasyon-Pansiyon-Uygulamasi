using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;       //Sql ile bağlantıyı sağlamak için
using System.Data.SqlClient; //Son iki kütüphaneyi ben ekledim

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8ICRKKM\\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void button10_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";

            baglanti.Open(); //baglanti adlı bir SQL bağlantısını açar.
            
            SqlCommand komut = new SqlCommand("insert into Oda101(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            //Bu komut, Oda101 adlı bir tabloya, TxtAdi ve TxtSoyadi adlı iki metin kutusundan alınan değerleri ekler.
           
            komut.ExecuteNonQuery(); //satırı, SQL komutunu veritabanına gönderir ve etkilenen satır sayısını döndürür. 
            //Bu durumda, yeni bir kayıt eklenir, bu nedenle etkilenen satır sayısı 1 olur.

            baglanti.Close(); //satırı, SQL bağlantısını kapatır.
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void DtpCıkısTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCıkısTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            LblGunSayısı.Text = Sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(LblGunSayısı.Text) * 500;
            TxtUcret.Text = ucret.ToString();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            // Müşteri ID değerini belirle
            //int musteriId = 123; // Örnek bir değer

            SqlCommand komut = new SqlCommand("INSERT INTO MusteriEkle (Adi, Soyadi, Cinsiyet, Telefon, Mail, TC, OdaNo, Ucret, GirisTarihi, CikisTarihi) VALUES (@Adi, @Soyadi, @Cinsiyet, @Telefon, @Mail, @TC, @OdaNo, @Ucret, @GirisTarihi, @CikisTarihi)", baglanti);

            try
            {
                DateTime girisTarihi = DtpGirisTarihi.Value;
                DateTime cikisTarihi = DtpCıkısTarihi.Value;

                if (cikisTarihi <= girisTarihi)
                {
                    MessageBox.Show("Çıkış tarihi, giriş tarihinden önce olamaz.");
                    return;
                }

                // Müşteri bilgilerini veritabanına kaydetme işlemi...
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme işlemi sırasında bir hata oluştu: " + ex.Message);
            }

            // Parametrelerin değerlerini atanıyor
            //komut.Parameters.AddWithValue("@Musteriid", musteriId);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", CmbxCinsiyet.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@Telefon", MskTxtTelefon.Text);
            komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
            komut.Parameters.AddWithValue("@TC", TxtTC.Text);
            komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
            komut.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
            komut.Parameters.AddWithValue("@GirisTarihi", DtpGirisTarihi.Value);
            komut.Parameters.AddWithValue("@CikisTarihi", DtpCıkısTarihi.Value);

            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
        }

        private void BtnOda110_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "110";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda110(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda111_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "111";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda111(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda112_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "112";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda112(Adi, Soyadi) Values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnDoluOda_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void BtnBosOda_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void BtnDoluOda_MouseLeave(object sender, EventArgs e)
        {
            // Fare imleci dolu oda butonundan ayrıldığında herhangi bir işlem yapmaya gerek yok.
        }

        private void BtnBosOda_MouseLeave(object sender, EventArgs e)
        {
            // Fare imleci boş oda butonundan ayrıldığında herhangi bir işlem yapmaya gerek yok.
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
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
                BtnOda101.Enabled = false;  //Eğer ki oda doluysa yani kırmızı ise oda seçilemesin
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
                BtnOda102.Enabled = false;
            }
            //-------------------------------------------------------------------------------------------

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
                BtnOda103.Enabled = false;
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
                BtnOda104.Enabled = false;
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
                BtnOda105.Enabled = false;
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
                BtnOda106.Enabled = false;
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
                BtnOda107.Enabled = false;
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
                BtnOda108.Enabled = false;
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
                BtnOda109.Enabled = false;
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
                BtnOda110.Enabled = false;
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
                BtnOda111.Enabled = false;
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
                BtnOda112.Enabled = false;
            }
        }
    }

}
//Data Source=DESKTOP-8ICRKKM\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True;Encrypt=False
