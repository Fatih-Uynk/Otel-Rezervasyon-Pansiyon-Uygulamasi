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
using System.Data.SqlClient;//Son iki kütüphaneyi ben ekledim

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmSifreGüncelle : Form
    {
        public FrmSifreGüncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-8ICRKKM\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True;Encrypt=False");


        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("update AdminGiris set Sifre = @Sifre where Kullanici = @Kullanici", baglanti);

                komut.Parameters.AddWithValue("@Kullanici", TxtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@Sifre", TxtSifre.Text);

                int affectedRows = komut.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Şifre başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Şifre güncelleme işlemi gerçekleştirilemedi.");
                }

                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }
    }
}
