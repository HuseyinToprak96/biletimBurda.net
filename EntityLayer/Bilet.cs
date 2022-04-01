using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class Bilet
    {
        public int BiletId { get; set; }
        public int? SeferId { get; set; }
        public int? UyeId { get; set; }
        public int KoltukNumarasi { get; set; }
        public virtual Uye uye { get; set; }
        public virtual Sefer sefer { get; set; }
    }
}
