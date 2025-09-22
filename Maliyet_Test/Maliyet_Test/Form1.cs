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

namespace Maliyet_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-5V6MJ7S;Initial Catalog=Test_Maliyet;Integrated Security=True");
        void malzemelistele()
        {
            SqlDataAdapter malzeme = new SqlDataAdapter("Select * from TBLMALZEMELER", baglantı);
            DataTable dt = new DataTable();
            malzeme.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }
        void kasa()
        {
            SqlDataAdapter malzeme = new SqlDataAdapter("Select * from TBLKASA", baglantı);
            DataTable dt = new DataTable();
            malzeme.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }
        
        void ürünlistele()
        {
            SqlDataAdapter malzeme = new SqlDataAdapter("Select * from TBLURUNLER", baglantı);
            DataTable dt = new DataTable();
            malzeme.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        void urunler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUNLER", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmburun.DataSource = dt;
            cmburun.DisplayMember = "AD";
            cmburun.ValueMember = "URUNID";
        }
        void malzemeler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMALZEMELER", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmalzeme.DataSource = dt;
            cmbmalzeme.DisplayMember = "AD";
            cmbmalzeme.ValueMember = "MALZEMEID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            malzemelistele();
            urunler();
            malzemeler();
        }

        private void btnurunlistesi_Click(object sender, EventArgs e)
        {
            ürünlistele();
        }

        private void btnkasa_Click(object sender, EventArgs e)
        {
            kasa();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmalzemelistesi_Click(object sender, EventArgs e)
        {
            malzemelistele();
        }

        private void btnmalzemeekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLMALZEMELER (AD,STOK,FIYAT,NOTLAR) values (@p1,@p2,@p3,@p4)", baglantı);
            ekle.Parameters.AddWithValue("@p1", txtmalzemead.Text);
            ekle.Parameters.AddWithValue("@p2", decimal.Parse(txtmalzemestok.Text));
            ekle.Parameters.AddWithValue("@p3", decimal.Parse(txtmalzemefiyat.Text));
            ekle.Parameters.AddWithValue("@p4", txtmalzemenot.Text);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Malzeme ekleme işlemi başarılı");
            malzemelistele();
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLURUNLER (AD,STOK,MFIYAT,SFIYAT) values (@p1,@p2,@p3,@p4)", baglantı);
            ekle.Parameters.AddWithValue("@p1", txturunad.Text);
            ekle.Parameters.AddWithValue("@p2", txturunstok.Text);
            ekle.Parameters.AddWithValue("@p3", decimal.Parse(txtmfiyat.Text));
            ekle.Parameters.AddWithValue("@p4", decimal.Parse(txtsfiyat.Text));
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ürün ekleme işlemi başarılı");
            ürünlistele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN (URUNID,MALZEMEID,MIKTAR,MALIYET) values (@p1,@p2,@p3,@p4)", baglantı);
            komut.Parameters.AddWithValue("@p1", cmburun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbmalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtmiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtmaliyet.Text));
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ekleme işlemi başarılı");

            listBox1.Items.Add(cmbmalzeme.Text + " " + txtmaliyet.Text);
        }

        private void txtmiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (txtmiktar.Text == "")
            {
                txtmiktar.Text = "0";
            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from tblmalzemeler where MALZEMEID=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1", cmbmalzeme.SelectedValue.ToString());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtmaliyet.Text = dr[3].ToString();
            }
            maliyet = Convert.ToDouble(txtmaliyet.Text) / 1000 * Convert.ToDouble(txtmiktar.Text);
            txtmaliyet.Text = maliyet.ToString();
            baglantı.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txturunid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txturunad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglantı.Open() ;
            SqlCommand komut = new SqlCommand("select sum(Malıyet) from tblfırın where urunıd=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1",txturunid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                txtmfiyat.Text = dr[0].ToString();
            }
            baglantı.Close() ;
        }
    }
}
