using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using EntityLayer;
namespace BusinessLogisLayer.ViewModels
{
   public class VMOtobusEkle
    {
        public SelectList KoltukTipleri { get; set; }
        public Otobus otobus { get; set; }
    }
}
