using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimÜzerineYazı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim;
        private void btnresimsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }
        Color renk;
        private void btnrenksec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }
        Bitmap bitmap;
        private void btnyazdır_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(resim);
            Graphics grp = Graphics.FromImage(bitmap);
            grp.DrawString(txtmetin.Text, new Font("Corbel", Convert.ToInt16(txtboyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
            pictureBox1.Image= bitmap;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "Resim |.jpg";
            bitmap.Save(saveFileDialog1.FileName);
        }
    }
}
