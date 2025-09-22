using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void haber(string link)
        {
            listBox1.Items.Clear();
            XmlTextReader okuyucu = new XmlTextReader(link);
            while (okuyucu.Read())
            {
                if (okuyucu.Name == "title")
                {
                    listBox1.Items.Add(okuyucu.ReadString());
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            haber("http://www.hurriyet.com.tr/rss/anasayfa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            haber("http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml");   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            haber("https://www.fotomac.com.tr/rss/english.xml");
        }
    }
}
