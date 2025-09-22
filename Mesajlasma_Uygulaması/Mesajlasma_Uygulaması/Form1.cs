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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-5V6MJ7S;Initial Catalog=Mesajlasma;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select * from TBLKISILER where NUMARA=@P1 and SIFRE=@P2", baglantı);
            komut1.Parameters.AddWithValue("@P1", maskedTextBox1.Text);
            komut1.Parameters.AddWithValue("@P2", textBox1.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.numara = maskedTextBox1.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız,Lütfen Tekrar Deneyiniz");
            }
            baglantı.Close();
        }
    }
}
