using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class Ilce
    {
        public int IlceId { get; set; }
        public string IlceAdi { get; set; }
        public int? SehirId { get; set; }
        public virtual Sehir sehir { get; set; }
        public virtual List<Uye> Uyeler { get; set; }
    }
}
