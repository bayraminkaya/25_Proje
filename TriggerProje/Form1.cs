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

namespace TriggerProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=Trigger;Integrated Security=True;");

        void verilistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLKITAP", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        void kitapadedi()
        {
            baglantı.Open();
            SqlCommand listele = new SqlCommand("select * from tbladet", baglantı);
            SqlDataReader dr = listele.ExecuteReader();
            while (dr.Read())
            {
                lblkitapadet.Text = dr[0].ToString();
            }
            baglantı.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verilistele();
            kitapadedi();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLKITAP (AD,YAZAR,SAYFA,YAYINEVI,TUR) values (@p1, @p2,@p3,@p4,@p5)",baglantı);
            ekle.Parameters.AddWithValue("@p1", txtad.Text);
            ekle.Parameters.AddWithValue("@p2", txtyazar.Text);
            ekle.Parameters.AddWithValue("@p3", txtsayfa.Text);
            ekle.Parameters.AddWithValue("@p4", txtyayınevı.Text);
            ekle.Parameters.AddWithValue("@p5", txttur.Text);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kitap Ekleme Başarılı","İŞLEM GERÇEKLEŞTİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtad.Text = "";
            txtyazar.Text = "";
            txtsayfa.Text = "";
            txtyayınevı.Text = "";
            txttur.Text = "";
            kitapadedi();
            verilistele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;  
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtyayınevı.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txttur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand sil = new SqlCommand("delete from TBLKITAP where ID=@p1", baglantı);
            sil.Parameters.AddWithValue("@p1", txtid.Text);
            sil.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kitap Silme Başarılı", "İŞLEM GERÇEKLEŞTİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kitapadedi();
            verilistele();
        }
    }
}
