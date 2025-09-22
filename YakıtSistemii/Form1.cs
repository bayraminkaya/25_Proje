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

namespace YakıtSistemii
{
    public partial class Form1 : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=YakıtSistemi;Integrated Security=True;");

        void fiyatlistele()
        {
            //kursunsuz95
            baglantı.Open();
            SqlCommand fiyatlist= new SqlCommand("select * from TBLBENZIN where PETROLTUR='Kursunsuz95'",baglantı);
            SqlDataReader dr = fiyatlist.ExecuteReader();
            while (dr.Read())
            {
                lblkursunsuz95.Text = dr[3].ToString();
                progresskursunsuz95.Value = int.Parse(dr[4].ToString());
                lbldepokursunsuz95.Text = dr[4].ToString() + " L";
            }
            baglantı.Close();

            //kursunsuz97
            baglantı.Open();
            SqlCommand fiyatlist2 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='Kursunsuz97'", baglantı);
            SqlDataReader dr2 = fiyatlist2.ExecuteReader();
            while (dr2.Read())
            {
                lblkursunsuz97.Text = dr2[3].ToString();
                progresskursunsuz97.Value = int.Parse(dr2[4].ToString());
                lbldepokursunsuz97.Text = dr2[4].ToString() + " L";

            }
            baglantı.Close();

            //EuroDizel
            baglantı.Open();
            SqlCommand fiyatlist3 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='EuroDizel10'", baglantı);
            SqlDataReader dr3 = fiyatlist3.ExecuteReader();
            while (dr3.Read())
            {
                lbleurodizel.Text = dr3[3].ToString();
                progresseurodizel.Value = int.Parse(dr3[4].ToString());
                lbldepoeurodizel.Text = dr3[4].ToString() + " L";
            }
            baglantı.Close();

            //YeniProDizel
            baglantı.Open();
            SqlCommand fiyatlist4 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='YeniProDizel'", baglantı);
            SqlDataReader dr4 = fiyatlist4.ExecuteReader();
            while (dr4.Read())
            {
                lblyeniprodizel.Text = dr4[3].ToString();
                progressprodizel.Value = int.Parse(dr4[4].ToString());
                lbldepoyeniprodizel.Text = dr4[4].ToString() + " L";
            }
            baglantı.Close();


            //Gaz
            baglantı.Open();
            SqlCommand fiyatlist5 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='Gaz'", baglantı);
            SqlDataReader dr5 = fiyatlist5.ExecuteReader();
            while (dr5.Read())
            {
                lblgaz.Text = dr5[3].ToString();
                progressgaz.Value = int.Parse(dr5[4].ToString());
                lbldepogaz.Text = dr5[4].ToString() + " L";
            }
            baglantı.Close();
        }

        void Kasa()
        {
            baglantı.Open();
            SqlCommand göster = new SqlCommand("select * from TBLKASA", baglantı);
            SqlDataReader dr = göster.ExecuteReader();
            while (dr.Read())
            {
                lblkasa.Text = dr[0].ToString() + " TL";
            }
            baglantı.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fiyatlistele();
            Kasa();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(lblkursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            txtkursunsuz95.Text = tutar.ToString() + " TL";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(lblkursunsuz97.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = kursunsuz97 * litre;
            txtkursunsuz97.Text = tutar.ToString() + " TL";
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double eurodizel, litre, tutar;
            eurodizel = Convert.ToDouble(lbleurodizel.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = eurodizel * litre;
            txteurodizel.Text = tutar.ToString() + " TL";
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double prodizel, litre, tutar;
            prodizel = Convert.ToDouble(lblyeniprodizel.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = prodizel * litre;
            txtprodizel.Text = tutar.ToString() + " TL";
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(lblgaz.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = gaz * litre;
            txtgaz.Text = tutar.ToString() + " TL";
        }

        //Truncate Table TBLHAREKET DEMEK  TABLOYI SIFIRLAMAK DEMEK

        private void btndepodoldur_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value !=0)
            {
                //BİLGİLERİ GÖNDERME
                baglantı.Open();
                SqlCommand depodoldur = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglantı);
                depodoldur.Parameters.AddWithValue("@p1", txtplaka.Text);
                depodoldur.Parameters.AddWithValue("@p2", "Kursunsuz95");
                depodoldur.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                depodoldur.Parameters.AddWithValue("@p4", decimal.Parse(txtkursunsuz95.Text.Replace(" TL", "").Trim()));
                depodoldur.ExecuteNonQuery();
                baglantı.Close();


                //KASA Güncelleme
                baglantı.Open();
                SqlCommand kasa = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglantı);
                kasa.Parameters.AddWithValue("@p1", decimal.Parse(txtkursunsuz95.Text.Replace(" TL", "").Trim()));
                kasa.ExecuteNonQuery();
                baglantı.Close();

                //DEPO Miktarı GÜncelleme
                baglantı.Open();
                SqlCommand depo = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Kursunsuz95'", baglantı);
                depo.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                depo.ExecuteNonQuery();
                baglantı.Close();


                MessageBox.Show("İşlem Tamamlandı");
                fiyatlistele();
                Kasa();
            }
            if (numericUpDown2.Value != 0)
            {
                //BİLGİLERİ GÖNDERME
                baglantı.Open();
                SqlCommand depodoldur = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglantı);
                depodoldur.Parameters.AddWithValue("@p1", txtplaka.Text);
                depodoldur.Parameters.AddWithValue("@p2", "Kursunsuz97");
                depodoldur.Parameters.AddWithValue("@p3", numericUpDown2.Value);
                depodoldur.Parameters.AddWithValue("@p4", decimal.Parse(txtkursunsuz97.Text.Replace(" TL", "").Trim()));
                depodoldur.ExecuteNonQuery();
                baglantı.Close();


                //KASA Güncelleme
                baglantı.Open();
                SqlCommand kasa = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglantı);
                kasa.Parameters.AddWithValue("@p1", decimal.Parse(txtkursunsuz97.Text.Replace(" TL", "").Trim()));
                kasa.ExecuteNonQuery();
                baglantı.Close();

                //DEPO Miktarı GÜncelleme
                baglantı.Open();
                SqlCommand depo = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Kursunsuz97'", baglantı);
                depo.Parameters.AddWithValue("@p1", numericUpDown2.Value);
                depo.ExecuteNonQuery();
                baglantı.Close();


                MessageBox.Show("İşlem Tamamlandı");
                fiyatlistele();
                Kasa();
            }
            if (numericUpDown3.Value != 0)
            {
                //BİLGİLERİ GÖNDERME
                baglantı.Open();
                SqlCommand depodoldur = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglantı);
                depodoldur.Parameters.AddWithValue("@p1", txtplaka.Text);
                depodoldur.Parameters.AddWithValue("@p2", "EuroDizel10");
                depodoldur.Parameters.AddWithValue("@p3", numericUpDown3.Value);
                depodoldur.Parameters.AddWithValue("@p4", decimal.Parse(txteurodizel.Text.Replace(" TL", "").Trim()));
                depodoldur.ExecuteNonQuery();
                baglantı.Close();


                //KASA Güncelleme
                baglantı.Open();
                SqlCommand kasa = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglantı);
                kasa.Parameters.AddWithValue("@p1", decimal.Parse(txteurodizel.Text.Replace(" TL", "").Trim()));
                kasa.ExecuteNonQuery();
                baglantı.Close();

                //DEPO Miktarı GÜncelleme
                baglantı.Open();
                SqlCommand depo = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='EuroDizel10'", baglantı);
                depo.Parameters.AddWithValue("@p1", numericUpDown3.Value);
                depo.ExecuteNonQuery();
                baglantı.Close();


                MessageBox.Show("İşlem Tamamlandı");
                fiyatlistele();
                Kasa();
            }
            if (numericUpDown4.Value != 0)
            {
                //BİLGİLERİ GÖNDERME
                baglantı.Open();
                SqlCommand depodoldur = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglantı);
                depodoldur.Parameters.AddWithValue("@p1", txtplaka.Text);
                depodoldur.Parameters.AddWithValue("@p2", "YeniProDizel");
                depodoldur.Parameters.AddWithValue("@p3", numericUpDown4.Value);
                depodoldur.Parameters.AddWithValue("@p4", decimal.Parse(txtprodizel.Text.Replace(" TL", "").Trim()));
                depodoldur.ExecuteNonQuery();
                baglantı.Close();


                //KASA Güncelleme
                baglantı.Open();
                SqlCommand kasa = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglantı);
                kasa.Parameters.AddWithValue("@p1", decimal.Parse(txtprodizel.Text.Replace(" TL", "").Trim()));
                kasa.ExecuteNonQuery();
                baglantı.Close();

                //DEPO Miktarı GÜncelleme
                baglantı.Open();
                SqlCommand depo = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='YeniProDizel'", baglantı);
                depo.Parameters.AddWithValue("@p1", numericUpDown4.Value);
                depo.ExecuteNonQuery();
                baglantı.Close();


                MessageBox.Show("İşlem Tamamlandı");
                fiyatlistele();
                Kasa();
            }
            if (numericUpDown5.Value != 0)
            {
                //BİLGİLERİ GÖNDERME
                baglantı.Open();
                SqlCommand depodoldur = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglantı);
                depodoldur.Parameters.AddWithValue("@p1", txtplaka.Text);
                depodoldur.Parameters.AddWithValue("@p2", "Gaz");
                depodoldur.Parameters.AddWithValue("@p3", numericUpDown5.Value);
                depodoldur.Parameters.AddWithValue("@p4", decimal.Parse(txtgaz.Text.Replace(" TL", "").Trim()));
                depodoldur.ExecuteNonQuery();
                baglantı.Close();


                //KASA Güncelleme
                baglantı.Open();
                SqlCommand kasa = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglantı);
                kasa.Parameters.AddWithValue("@p1", decimal.Parse(txtgaz.Text.Replace(" TL", "").Trim()));
                kasa.ExecuteNonQuery();
                baglantı.Close();

                //DEPO Miktarı GÜncelleme
                baglantı.Open();
                SqlCommand depo = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Gaz'", baglantı);
                depo.Parameters.AddWithValue("@p1", numericUpDown5.Value);
                depo.ExecuteNonQuery();
                baglantı.Close();


                MessageBox.Show("İşlem Tamamlandı");
                fiyatlistele();
                Kasa();
            }
        }
    }
}
