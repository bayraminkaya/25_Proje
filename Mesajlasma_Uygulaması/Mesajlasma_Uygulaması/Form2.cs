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

namespace Mesajlasma_Uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-5V6MJ7S;Initial Catalog=Mesajlasma;Integrated Security=True");
        public string numara;

        void gelenkutusu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMESAJLAR where ALICI=" + numara, baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;

        }
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TBLMESAJLAR where GONDEREN=" + numara, baglantı);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            dataGridView2.RowHeadersVisible = false;

        }

        void adsoyad()
        {
            baglantı.Open();
            SqlCommand isim = new SqlCommand("select AD,SOYAD from TBLKISILER where NUMARA=" + numara, baglantı);
            SqlDataReader dr = isim.ExecuteReader();
            if (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            baglantı.Close();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;
            gelenkutusu();
            gidenkutusu();
            adsoyad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) values (@P1,@P2,@P3,@P4)", baglantı);
            komut.Parameters.AddWithValue("@P1", numara);
            komut.Parameters.AddWithValue("@P2", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@P3", textBox1.Text);
            komut.Parameters.AddWithValue("@P4", richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Mesajınız Gönderildi");
            gidenkutusu();
        }
    }
}
