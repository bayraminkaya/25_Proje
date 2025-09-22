using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_List_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> kişiler = new List<string>();
            kişiler.Add("Mazhar");
            kişiler.Add("Rushar");
            kişiler.Add("Menkıbe");
            kişiler.Add("Münfit");
            kişiler.Add("Reyhan");
            kişiler.Add("Firdevs");

            foreach (var k in kişiler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> numara = new List<int>();
            numara.Add(1);
            numara.Add(2);
            numara.Add(3);
            numara.Add(4);
            numara.Add(5);
            numara.Add(6);
            numara.Add(7);
            numara.Add(8);
            numara.Add(9);
            numara.Add(10);
            foreach (int i in numara)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kisiler> list = new List<Kisiler>();
            list.Add(new Kisiler() { ADI="Bayram",SOYAD="İnkaya",Meslek="Yazılımcı"} );
            foreach (var item in list)
            {
                listBox3.Items.Add(item.ADI + " " + item.SOYAD + " " + item.Meslek);
            }
        }
    }
}
