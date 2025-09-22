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

namespace SorguTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-5V6MJ7S;Initial Catalog=DbOgrenciNot;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu;
            sorgu = richTextBox1.Text;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglantı);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("sorgunuzu kontrol edin!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;
            try
            {
                baglantı.Open();
                
                SqlCommand komut = new SqlCommand(sorgu, baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TBLOGRENCILER", baglantı);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("sorgunuzu kontrol edin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
