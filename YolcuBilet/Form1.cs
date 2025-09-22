using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YolcuBilet
{
    public partial class Form1 : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=YolcuBılet;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        void koltukrenkleriniguncelle()
        {
            List<Button> butonlar = new List<Button>
            {
                button2, button3, button4, button5, button9, button8, button7, button6,
                button13, button12, button11, button10, button17, button16,
                button15, button14, button21, button20, button19, button18,
            };

            // 🟢 Önce tüm butonları varsayılan (boş) rengine döndür (Yeşil)
            foreach (var buton in butonlar)
            {
                buton.BackColor = Color.Green;
            }

            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT KOLTUK FROM TBLSEFERDETAY WHERE SEFERNO = @seferno", baglantı);
            komut.Parameters.AddWithValue("@seferno", lblseferno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                // 🟢 Koltuk numarasına göre buton rengini değiştir (Kırmızı)
                foreach (var buton in butonlar)
                {
                    if (buton.Text == dr[0].ToString())
                    {
                        buton.BackColor = Color.Red;
                    }
                    
                }
            }
            baglantı.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            seferlistesi();
            yolculistesi();
            yolcusay();
            sefersay();
        }
        void seferlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLSEFERBILGI", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;

        }
        void yolculistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select SEFERNO,YOLCUTC,KOLTUK from tblseferdetay", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.RowHeadersVisible = false;

        }
        void yolcusay()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select count(*) from TBLSEFERDETAY", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblyolcu.Text = dr[0].ToString();
            }
            baglantı.Close();
        }
        void sefersay()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select count(*) from TBLSEFERBILGI", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblsefer.Text = dr[0].ToString();
            }
            baglantı.Close();
        }

        private void btnyolcuolustur_Click(object sender, EventArgs e)
        {
            baglantı.Open();    
            SqlCommand komut = new SqlCommand("insert into TBLYOLCUBILGI (AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglantı);
            komut.Parameters.AddWithValue("@p1", txtyolcuad.Text);
            komut.Parameters.AddWithValue("@p2", txtyolcusoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtxtyolcutelefon.Text);
            komut.Parameters.AddWithValue("@p4", mtxtyolcutc.Text);
            komut.Parameters.AddWithValue("@p5", cmbcinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", txtyolcumail.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Yolcu Bilgileri Başarıyla Kaydedildi");
            txtyolcuad.Text = "";
            txtyolcusoyad.Text = "";
            mtxtyolcutelefon.Text = "";
            mtxtyolcutc.Text = "";
            cmbcinsiyet.Text = "";
            txtyolcumail.Text = "";
        }

        private void btnseferolustur_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut= new SqlCommand("insert into TBLSEFERBILGI (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) values (@p2,@p3,@p4,@p5,@p6,@p7)", baglantı);
            komut.Parameters.AddWithValue("@p2", txtkalkıs.Text);
            komut.Parameters.AddWithValue("@p3", txtvarıs.Text);
            komut.Parameters.AddWithValue("@p4", mtxtsefertarih.Text);
            komut.Parameters.AddWithValue("@p5", mtxtsefersaat.Text);
            komut.Parameters.AddWithValue("@p6",mtxtkaptansefer.Text);
            komut.Parameters.AddWithValue("@p7",txtseferfiyat.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Sefer Bilgileri Başarıyla Kaydedildi");
            txtseferno.Text = "";
            txtkalkıs.Text = "";
            txtvarıs.Text = "";
            mtxtsefertarih.Text = "";
            mtxtsefersaat.Text = "";
            mtxtkaptansefer.Text = "";
            txtseferfiyat.Text = "";
            seferlistesi();
            sefersay();                
        }

        private void btnkaptanolustur_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into tblkaptan (KAPTANNO,ADSOYAD,TELEFON) values (@p1,@p2,@p3)", baglantı);
            komut.Parameters.AddWithValue("@p1", txtkaptanno.Text);
            komut.Parameters.AddWithValue("@p2", txtkaptanadsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtxttelefon.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kaptan Bilgileri Başarıyla Kaydedildi");
            txtkaptanno.Text = "";
            txtkaptanadsoyad.Text = "";
            mtxttelefon.Text = "";
        }

        private void btnrezarvasyonolustur_Click(object sender, EventArgs e)
        {
            baglantı.Open();    
            SqlCommand komut = new SqlCommand("insert into TBLSEFERDETAY (SEFERNO,YOLCUTC,KOLTUK) values (@p1,@p2,@p3)", baglantı);
            komut.Parameters.AddWithValue("@p1", txtrezarvasyonseferno.Text);
            komut.Parameters.AddWithValue("@p2", mtxtrezarvasyontc.Text);
            komut.Parameters.AddWithValue("@p3", txtkoltukno.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Rezarvasyon Bilgileri Başarıyla Kaydedildi");
            txtseferno.Text = "";
            txtyolcuad.Text = "";
            txtkoltukno.Text = "";
            yolculistesi();
            yolcusay();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "1";
            button3.Tag = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "2";
            button4.Tag = "2";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "3";
            button5.Tag = "3";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "4";
            button9.Tag = "4";


        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "5";
            button8.Tag = "5";


        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "6";
            button7.Tag = "6";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "7";
            button6.Tag = "7";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "8";
            button13.Tag = "8";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "9";
            button12.Tag = "9";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "10";
            button11.Tag = "10";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "11";
            button10.Tag = "11";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "12";
            button17.Tag = "12";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "13";
            button16.Tag = "13";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "14";
            button15.Tag = "14";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "15";
            button14.Tag = "15";

        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "16";
            button21.Tag = "16";


        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "17";
            button20.Tag = "17";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "18";
            button19.Tag = "18";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "19";
            button18.Tag = "19";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "20";
            button2.Tag = "20";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtrezarvasyonseferno.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Geçerli bir satır indeksi olduğundan emin olun
            {
                lblseferno.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                koltukrenkleriniguncelle(); // 🟢 Yeni seçili satıra göre koltukları güncelle
            }

        }
    }
}
