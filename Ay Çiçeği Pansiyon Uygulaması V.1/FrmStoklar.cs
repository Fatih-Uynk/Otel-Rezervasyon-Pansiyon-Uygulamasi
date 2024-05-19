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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8ICRKKM\\SQLEXPRESS01;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Stoklar",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Burada ki kodların avantajı bellek yönetiminde "PERFORMANS" olarak  hızlı olmasıdır.
            //Dezavantajı ise Güvenlikli değildir.
            //Güvenlik SQL ile bağlantı sağlandığı için önemlidir,verilerin çalınması açısından düşünülürse.
            listView1.Items.Clear();// Verilerin tekrar etmemesi için kullanılır.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("İnsert into Stoklar(Gida,İcecek,Cerezler) values('" + TxtGidaTutarı.Text + "','" + TxtİcecekTutarı.Text + "','" + TxtAtistirmaliklar.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            veriler() ;
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            //Burada ki kodların avantajı daha "GÜVENLİKLİ"olmasıdır.
            //Dezavantajı ise bellek yönetimi konusunda performans olarak daha yavaştır.
            listView2.Items.Clear();// Verilerin tekrar etmemesi için kullanılır.
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("INSERT INTO Faturalar(Elektrik,Su,internet) values(@elektrik, @su, @internet)", baglanti);
            komut2.Parameters.AddWithValue("@elektrik", TxtElektrik.Text);
            komut2.Parameters.AddWithValue("@su", TxtSu.Text);
            komut2.Parameters.AddWithValue("@internet", TxtInternet.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
