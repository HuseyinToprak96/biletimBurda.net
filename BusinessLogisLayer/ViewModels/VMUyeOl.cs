using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BusinessLogisLayer.ViewModels
{
   public class VMUyeOl
    {
        public SelectList Sehirler { get; set; }
        public Uye uye { get; set; }
    }
}
