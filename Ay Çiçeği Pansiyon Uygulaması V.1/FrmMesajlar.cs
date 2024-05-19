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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
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
                SqlCommand komut = new SqlCommand("select * from Mesajlar", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();

                    ekle.Text = oku["Mesajid"].ToString();
                    ekle.SubItems.Add(oku["AdSoyad"].ToString());
                    ekle.SubItems.Add(oku["Mesaj"].ToString());
                    

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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Mesajlar (AdSoyad, Mesaj) VALUES ('" + textBox1.Text + "','" + richTextBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Mesajınız başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri kaydederken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
                verilergoster(baglanti);
            }
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilergoster(baglanti);
        }
        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
