using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VeritabanıKitap vkitap = new VeritabanıKitap();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vkitap.listele();
            dataGridView1.RowHeadersVisible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap ktpsınıf = new Kitap();
            ktpsınıf.Kitapadd = textBox1.Text;
            ktpsınıf.Yazarr = textBox2.Text;
            vkitap.kitapekle(ktpsınıf);
            dataGridView1.DataSource = vkitap.listele();

        }
    }
}
