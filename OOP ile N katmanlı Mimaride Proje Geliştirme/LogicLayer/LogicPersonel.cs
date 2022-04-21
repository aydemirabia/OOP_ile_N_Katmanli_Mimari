using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DAL_Personel.PersonelListesi();
        }
        public static int LLPersonel(EntityPersonel p)
        {
            if(p.Ad!="" && p.Soyad!="" && p.Maas>3500 && p.Ad.Length >= 3)
            {
                return DAL_Personel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLPersonelSil(int per)
        {
            if (per >= 1)
            {
                return DAL_Personel.PersonelSil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LLPersonelGuncelle(EntityPersonel ent)
        {
            if(ent.Ad.Length>=3 && ent.Ad!="" && ent.Maas >= 4500)
            {
                return DAL_Personel.PersonelGuncelle(ent);
            }
            else 
            {
                return false;            
            }
        }
    }
}
