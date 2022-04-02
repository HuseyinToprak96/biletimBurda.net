using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public class Rota
    {
        public int RotaId { get; set; }
        [ForeignKey("nereden")]
        public int? NeredenId { get; set; }
        [ForeignKey("nereye")]
        public int? NereyeId { get; set; }
        public decimal Ucret { get; set; }
        public virtual Durak nereden { get; set; }
        public virtual Durak nereye { get; set; }
        public virtual List<Sefer> Seferler { get; set; }
    }
}
