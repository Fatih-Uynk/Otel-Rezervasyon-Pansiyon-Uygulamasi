using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Son iki kütüphaneyi ben ekledim sql ile bağlantı sağlamak için. 
using System.Data.Sql;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-8ICRKKM\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True;Encrypt=False");

        private void verilergoster(SqlConnection baglanti)
        {
            listView1.Items.Clear();//Her defasında listview'deki ögeleri temizleyip bana getir,alt alta aynı şeyleri sıralamasın.
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();

                    ekle.Text = oku["Musteriid"].ToString();
                    ekle.SubItems.Add(oku["Adi"].ToString());
                    ekle.SubItems.Add(oku["Soyadi"].ToString());
                    ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                    ekle.SubItems.Add(oku["Telefon"].ToString());
                    ekle.SubItems.Add(oku["Mail"].ToString());
                    ekle.SubItems.Add(oku["TC"].ToString());
                    ekle.SubItems.Add(oku["OdaNo"].ToString());
                    ekle.SubItems.Add(oku["Ucret"].ToString());
                    ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                    ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                    listView1.Items.Add(ekle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri getirme sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster(baglanti);
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CmbxCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCıkısTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                DateTime girisTarihi = DtpGirisTarihi.Value;
                DateTime cikisTarihi = DtpCıkısTarihi.Value;

                if (cikisTarihi <= girisTarihi)
                {
                    MessageBox.Show("Çıkış tarihi, giriş tarihinden önce olamaz.");
                    return;
                }

                SqlCommand komut = new SqlCommand("update MusteriEkle set Adi = @Adi, Soyadi = @Soyadi, Cinsiyet = @Cinsiyet, Telefon = @Telefon, Mail = @Mail, TC = @TC, OdaNo = @OdaNo, Ucret = @Ucret, GirisTarihi = @GirisTarihi, CikisTarihi = @CikisTarihi where Musteriid = @id", baglanti);

                komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
                komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", CmbxCinsiyet.Text);
                komut.Parameters.AddWithValue("@Telefon", MskTxtTelefon.Text);
                komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
                komut.Parameters.AddWithValue("@TC", TxtTC.Text);
                komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
                komut.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
                komut.Parameters.AddWithValue("@GirisTarihi", DtpGirisTarihi.Value);
                komut.Parameters.AddWithValue("@CikisTarihi", DtpCıkısTarihi.Value);
                komut.Parameters.AddWithValue("@id", id);

                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster(baglanti);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message);
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    int musteriId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                    string odaNo = listView1.SelectedItems[0].SubItems[7].Text;

                    baglanti.Open();

                    // SQL tablosundan müşteriyi sil
                    SqlCommand komut1 = new SqlCommand("DELETE FROM MusteriEkle WHERE Musteriid = @id", baglanti);
                    komut1.Parameters.AddWithValue("@id", musteriId);
                    komut1.ExecuteNonQuery();

                    // Oda tablosundan da müşteriyi sil (örneğin Oda101)
                    SqlCommand komut2 = new SqlCommand($"DELETE FROM Oda{odaNo} WHERE Musteriid = @id", baglanti);
                    komut2.Parameters.AddWithValue("@id", musteriId);
                    komut2.ExecuteNonQuery();

                    baglanti.Close();

                    // listView1'den seçilen öğeyi kaldır
                    listView1.SelectedItems[0].Remove();
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek bir öğe seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            /*
             TxtAdi.Clear();
             TxtSoyadi.Clear();
             CmbxCinsiyet.Text = "";
             MskTxtTelefon.Clear();
             TxtMail.Clear();
             TxtTC.Clear();
             TxtOdaNo.Clear();
             TxtUcret.Clear();
             DtpGirisTarihi.Text = "";
             DtpCıkısTarihi.Text = "";
             */
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();//Her defasında listview'deki ögeleri temizleyip bana getir,alt alta aynı şeyleri sıralamasın.
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%" + textİsim.Text + "%'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();

                    ekle.Text = oku["Musteriid"].ToString();
                    ekle.SubItems.Add(oku["Adi"].ToString());
                    ekle.SubItems.Add(oku["Soyadi"].ToString());
                    ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                    ekle.SubItems.Add(oku["Telefon"].ToString());
                    ekle.SubItems.Add(oku["Mail"].ToString());
                    ekle.SubItems.Add(oku["TC"].ToString());
                    ekle.SubItems.Add(oku["OdaNo"].ToString());
                    ekle.SubItems.Add(oku["Ucret"].ToString());
                    ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                    ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                    listView1.Items.Add(ekle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri getirme sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }
    }
}
//Data Source=DESKTOP-8ICRKKM\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True;Encrypt=False