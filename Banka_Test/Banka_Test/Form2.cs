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

namespace Banka_Test
{
    public partial class Form2 : Form
    {
        public string hesap;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5V6MJ7S;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            lblhesapno.Text = hesap;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKISILER where HESAPNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[1].ToString() + " " + dr[2].ToString();
                lbltelefon.Text = dr[3].ToString();
                lbltc.Text = dr[4].ToString();
            }
            baglanti.Close();

            
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand paratransfer = new SqlCommand("update tblHesap set BAKIYE=BAKIYE+@p1 where HESAPNO=@p2", baglanti);
            paratransfer.Parameters.AddWithValue("@p2", mskhesapno.Text);
            paratransfer.Parameters.AddWithValue("@p1", decimal.Parse(txttutar.Text));
            paratransfer.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para Transferi Başarılı");

            //Para Transferi2
            baglanti.Open();
            SqlCommand paratransfer2 = new SqlCommand("update tblhesap set BAKIYE=BAKIYE-@p1 where HESAPNO=@p2", baglanti);
            paratransfer2.Parameters.AddWithValue("@p1", decimal.Parse(txttutar.Text));
            paratransfer2.Parameters.AddWithValue("@p2", lblhesapno.Text);
            paratransfer2.ExecuteNonQuery();
            baglanti.Close();
            
        }
    }
}
