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
        [ForeignKey("nereden")]
        public int? neredenId { get; set; }
        [ForeignKey("nereye")]
        public int? nereyeId { get; set; }
        public string Saat { get; set; }
        public string Tarih { get; set; }
        [ForeignKey("otobus")]
        public int? OtobusId { get; set; }
        public virtual Durak nereden { get; set; }
        public virtual Durak nereye { get; set; }
        public virtual Otobus otobus { get; set; }
        public virtual List<Bilet> Biletler { get; set; }
    }
}
