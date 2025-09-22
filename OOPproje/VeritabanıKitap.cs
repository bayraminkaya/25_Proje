using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOPproje
{
    public class VeritabanıKitap
    {
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=ListYapısı;Integrated Security=True;");

        //List<Kitap> → Metot, Kitap türünden nesneler içeren bir liste döndürecek şekilde tasarlanmış.
        public List<Kitap> listele()
        {
            List<Kitap> ktp = new List<Kitap>();
            baglantı.Open();
            SqlCommand listele = new SqlCommand("select * from TBLKITAP", baglantı);
            SqlDataReader dr = listele.ExecuteReader();
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.IDD = Convert.ToInt32(dr[0].ToString());
                k.Kitapadd = dr[1].ToString();
                k.Yazarr = dr[2].ToString();

                ktp.Add(k);
            }
            baglantı.Close();
            return ktp;
        }


        public void kitapekle(Kitap x)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKITAP (KITAPAD,KITAPYAZAR) values (@p1,@p2)", baglantı);
            komut.Parameters.AddWithValue("@p1",x.Kitapadd);
            komut.Parameters.AddWithValue("@p2", x.Yazarr);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("İşlem Başarılı");
        }
    }
}
