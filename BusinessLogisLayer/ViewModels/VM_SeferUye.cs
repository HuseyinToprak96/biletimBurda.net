using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogisLayer.ViewModels
{
   public class VM_SeferUye
    {
        public List<Sefer> Seferler { get; set; }
        public Bilet bilet { get; set; }
        public List<Bilet> biletler { get; set; }
    }
}
