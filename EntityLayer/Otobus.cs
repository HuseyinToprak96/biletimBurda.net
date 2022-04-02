using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class Otobus
    {
        public int OtobusId { get; set; }
        public string OtobusResmi { get; set; }
        [StringLength(30)]
        public string Marka { get; set; }
        [StringLength(30)]
        public string Model { get; set; }
        public string Plaka { get; set; }
        public int KoltukSayisi { get; set; }
        public int? KoltukTipiId { get; set; }
        public string SuanKiDurumu { get; set; }//(Yolda veya Son gittiği durağın olduğu ilde)
        public virtual KoltukTipi koltukTipi { get; set; }
        public virtual List<Sefer> Seferler { get; set; }
    }
}
