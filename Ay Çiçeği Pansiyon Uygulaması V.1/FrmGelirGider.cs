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
using System.Data.SqlClient;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8ICRKKM\\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            int personel;

            personel = Convert.ToInt16(TxtPersonelSayisi.Text);
            LblPersonelMaas.Text = (personel * 17000).ToString();
            
            int sonuc = 0;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt32(LblPersonelMaas.Text) + Convert.ToInt32(LblAlınanUrunler.Text) + Convert.ToInt32(LblAlınanUrunler2.Text) + Convert.ToInt32(LblAlınanUrunler3.Text) + Convert.ToInt32(LblFaturalar1.Text) + Convert.ToInt32(LblFaturalar2.Text) + Convert.ToInt32(LblFaturalar3.Text));
            LblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            try
            {
                //Kasadaki Toplam Tutar
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
                SqlDataReader oku = komut.ExecuteReader(); // Girilen parametreler üzerinde değişiklik yapmak için kullanılır.
                while (oku.Read())
                {
                    LblKasaToplam.Text = oku["toplam"].ToString();
                }
                baglanti.Close();

                //Gıda Giderleri
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", baglanti);
                SqlDataReader oku2 = komut2.ExecuteReader(); // Girilen parametreler üzerinde değişiklik yapmak için kullanılır.
                while (oku2.Read())
                {
                    LblAlınanUrunler.Text = oku2["toplam1"].ToString();
                }
                baglanti.Close();

                //İçecekler
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("Select sum(İcecek) as toplam2 from Stoklar", baglanti);
                SqlDataReader oku3 = komut3.ExecuteReader(); // Girilen parametreler üzerinde değişiklik yapmak için kullanılır.
                while (oku3.Read())
                {
                    LblAlınanUrunler2.Text = oku3["toplam2"].ToString();
                }
                baglanti.Close();

                //Atıştırmalıklar
                baglanti.Open();
                SqlCommand komut4 = new SqlCommand("Select sum(Cerezler) as toplam3 from Stoklar", baglanti);
                SqlDataReader oku4 = komut4.ExecuteReader(); // Girilen parametreler üzerinde değişiklik yapmak için kullanılır.
                while (oku4.Read())
                {
                    LblAlınanUrunler3.Text = oku4["toplam3"].ToString();
                }
                baglanti.Close();

                //Elektrik
                baglanti.Open();
                SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam4 from Faturalar", baglanti);
                SqlDataReader oku5 = komut5.ExecuteReader(); // Girilen parametreler üzerinde değişiklik yapmak için kullanılır.
                while (oku5.Read())
                {
                    LblFaturalar1.Text = oku5["toplam4"].ToString();
                }
                baglanti.Close();

                //Su
                baglanti.Open();
                SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam5 from Faturalar", baglanti);
                SqlDataReader oku6 = komut6.ExecuteReader(); // Girilen parametreler üzerinde değişiklik yapmak için kullanılır.
                while (oku6.Read())
                {
                    LblFaturalar2.Text = oku6["toplam5"].ToString();
                }
                baglanti.Close();

                //İnternet
                baglanti.Open();
                SqlCommand komut7 = new SqlCommand("Select sum(internet) as toplam6 from Faturalar", baglanti);
                SqlDataReader oku7 = komut7.ExecuteReader(); // Girilen parametreler üzerinde değişiklik yapmak için kullanılır.
                while (oku7.Read())
                {
                    LblFaturalar3.Text = oku7["toplam6"].ToString();
                }
                baglanti.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı bağlantısında hata: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Genel bir hata oluştu: " + ex.Message);
            }
        }

        private void LblPersonelMaas_Click(object sender, EventArgs e)
        {

        }
    }
}
