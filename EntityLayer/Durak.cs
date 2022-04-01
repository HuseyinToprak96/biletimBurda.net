using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class Durak
    {
        public int DurakId { get; set; }
        public string DurakAdi { get; set; }
        public int IlceId { get; set; }
        public virtual Ilce ilce  { get; set; }
        public virtual List<Sefer> seferler { get; set; }
    }
}
