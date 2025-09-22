using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifreli_Veriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-5V6MJ7S;Initial Catalog=DbOgrenciNot;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = TxtAd.Text;
            byte[] addizi = Encoding.UTF8.GetBytes(ad);
            string adsifre = Convert.ToBase64String(addizi);

            string soyad = TxtSoyad.Text;
            byte[] soyaddizi = Encoding.UTF8.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizi);

            string mail = TxtMail.Text;
            byte[] maildizi = Encoding.UTF8.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizi);

            string sifre = TxtSifre.Text;
            byte[] sifredizi = Encoding.UTF8.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizi);

            string hesapno = TxtHesapNo.Text;
            byte[] hesapnodizi = Encoding.UTF8.GetBytes(hesapno);
            string hesapnosifre = Convert.ToBase64String(hesapnodizi);

            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", baglantı);
            ekle.Parameters.AddWithValue("@p1", adsifre);
            ekle.Parameters.AddWithValue("@p2", soyadsifre);
            ekle.Parameters.AddWithValue("@p3", mailsifre);
            ekle.Parameters.AddWithValue("@p4", sifresifre);
            ekle.Parameters.AddWithValue("@p5", hesapnosifre);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Başarılı", "İşlem Tamamlandır", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            SqlCommand listele = new SqlCommand("select * from TBLVERILER", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLVERILER", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    row["AD"] = sifrecozumle(row["AD"].ToString());
                    row["SOYAD"] = sifrecozumle(row["SOYAD"].ToString());
                    row["MAIL"] = sifrecozumle(row["MAIL"].ToString());
                    row["SIFRE"] = sifrecozumle(row["SIFRE"].ToString());
                    row["HESAPNO"] = sifrecozumle(row["HESAPNO"].ToString());
                }
                catch
                {
                    MessageBox.Show("ShowŞifre Çözme İşlemi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            dataGridView2.DataSource = dt;
        }

        string sifrecozumle(string v1)
        {
            byte[] cozumdizisi = Convert.FromBase64String(v1);
            string sonuc = Encoding.UTF8.GetString(cozumdizisi);
            return sonuc;
        }
    }
}
