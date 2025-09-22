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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5V6MJ7S;Initial Catalog=DbBankaTest;Integrated Security=True");


        private void lnkkayıtol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand select = new SqlCommand("select * from TBLKISILER where HESAPNO=@p1 and SIFRE=@p2", baglanti);
            select.Parameters.AddWithValue("@p1", mskhesapno.Text);
            select.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = select.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.hesap = mskhesapno.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            baglanti.Close();
        }
    }
}
