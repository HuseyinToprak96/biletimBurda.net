using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public class Uye
    {
        public int UyeId { get; set; }
        public bool Yetki { get; set; }
        public string UyeAdi { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public int Telefon { get; set; }
        public int? SehirId { get; set; }
        public int? IlceId { get; set; }
        public virtual List<Bilet> Biletler { get; set; }
        public virtual Sehir sehir { get; set; }
        public virtual Ilce ilce { get; set; }

    }
}
