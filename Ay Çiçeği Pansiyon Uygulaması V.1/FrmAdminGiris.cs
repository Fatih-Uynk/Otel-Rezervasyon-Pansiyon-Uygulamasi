using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sql ile bağlantı sağlamak için kütüphaneler.
using System.Data.Sql;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8ICRKKM\\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True;Encrypt=False");


        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string Sql = "Select * From AdminGiris where Kullanici = @KullaniciAdi and Sifre = @Sifresi";
                SqlParameter prm1 = new SqlParameter("@KullaniciAdi", TxtKullaniciAdi.Text.Trim());//Veri Tabanının ilgili alanına tablo adına geçici bir isim oluşturdum
                SqlParameter prm2 = new SqlParameter("@Sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(Sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(komut);

                data.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
                
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
            //Bu kodda finally bloğu, kodun ne olursa olsun çalışmasını sağlar ve bağlantıyı kapatır.
        }
    }
}
