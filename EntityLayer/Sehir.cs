using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class Sehir
    {
        public int SehirId { get; set; }
        public string SehirAdi { get; set; }
        public virtual List<Ilce> Ilceler { get; set; }
        public virtual List<Uye> Uyeler { get; set; }
    }
}
