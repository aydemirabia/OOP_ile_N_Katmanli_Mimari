using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class EntityPersonel
    {
        private int id;
        private string ad;
        private string soyad;
        private string sehir;
        private string gorev;
        private short maas;

        //Kapsülle-property:::: get ile okunur set ile değer atanır.
        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string Gorev { get => gorev; set => gorev = value; }
        public short Maas { get => maas; set => maas = value; }
        public string Soyad { get => soyad; set => soyad = value; }
    }
}
