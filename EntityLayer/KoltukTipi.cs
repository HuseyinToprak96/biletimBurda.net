using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class KoltukTipi
    {
        public int KoltukTipiId { get; set; }
        public string KoltukTipiAdi { get; set; }
        public int SolKoltuk { get; set; }
        public int SagKoltuk { get; set; }
        public virtual List<Otobus> otobusler { get; set; }
    }
}
