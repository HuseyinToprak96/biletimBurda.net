using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BusinessLogisLayer.ViewModels
{
  public class VMRotaEkle
    {
        public Rota rota { get; set; }
        public SelectList Duraklar { get; set; }
    }
}
