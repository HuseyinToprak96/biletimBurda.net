using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public class Sefer
    {
        public int SeferId { get; set; }
        public int RotaId { get; set; }
        public string Saat { get; set; }
        public string Tarih { get; set; }
        [ForeignKey("otobus")]
        public int? OtobusId { get; set; }
        public virtual Otobus otobus { get; set; }
        public virtual Rota rota { get; set; }
        public virtual List<Bilet> Biletler { get; set; }
    }
}
