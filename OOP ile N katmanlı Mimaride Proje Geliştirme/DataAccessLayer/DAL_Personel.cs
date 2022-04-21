using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DAL_Personel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("select * from tbl_personel",Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel entP = new EntityPersonel();
                entP.Id = int.Parse(dr["id"].ToString());
                entP.Ad = dr["ad"].ToString();
                entP.Soyad = dr["soyad"].ToString();
                entP.Sehir = dr["sehir"].ToString();
                entP.Gorev = dr["gorev"].ToString();
                entP.Maas = short.Parse(dr["maas"].ToString());
                degerler.Add(entP);
            }
            dr.Close();
            return degerler;
        }
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into tbl_personel (ad,soyad,gorev,sehir,maas) values(@p1,@p2,@p3,@p4,@p5", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Ad);
            komut2.Parameters.AddWithValue("@p2", p.Soyad);
            komut2.Parameters.AddWithValue("@p3", p.Gorev);
            komut2.Parameters.AddWithValue("@p4", p.Sehir);
            komut2.Parameters.AddWithValue("@p5", p.Maas);
            return komut2.ExecuteNonQuery();
        }
        public static bool PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("delete from tbl_personel where id=@p1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool PersonelGuncelle(EntityPersonel entG)
        {
            SqlCommand komut4 = new SqlCommand("update tbl_personel set ad=@p1,soyad=@p2,sehir=@p3,gorev=@p4,maas=@p5 where id=@p6", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p6", entG.Id);
            komut4.Parameters.AddWithValue("@p1", entG.Ad);
            komut4.Parameters.AddWithValue("@p2", entG.Soyad);
            komut4.Parameters.AddWithValue("@p3", entG.Sehir);
            komut4.Parameters.AddWithValue("@p4", entG.Gorev);
            komut4.Parameters.AddWithValue("@p5", entG.Maas);
            return komut4.ExecuteNonQuery() > 0;
        }

    }
}
