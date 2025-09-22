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

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-5V6MJ7S;Initial Catalog=Rehber;Integrated Security=True");
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from KISILER", baglantı);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void temizle()
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTel.Text = "";
            TxtMail.Text = "";
            TxtAd.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into KISILER (Ad,Soyad,Telefon,MAIl) values (@p1,@p2,@p3,@p4)", baglantı);
            ekle.Parameters.AddWithValue("@p1", TxtAd.Text);
            ekle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            ekle.Parameters.AddWithValue("@p3", MskTel.Text);
            ekle.Parameters.AddWithValue("@p4", TxtMail.Text);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kişi Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Delete from KISILER where ID=" + TxtId.Text, baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kişi başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand guncelle = new SqlCommand("update KISILER set Ad=@p1,Soyad=@p2,Telefon=@p3,MAIl=@p4 where ID=@p5", baglantı);
            guncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            guncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", MskTel.Text);
            guncelle.Parameters.AddWithValue("@p4", TxtMail.Text);
            guncelle.Parameters.AddWithValue("@p5", TxtId.Text);
            guncelle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kişi başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
