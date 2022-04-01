using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BusinessLogisLayer.ViewModels
{
   public class VMseferAra
    {
        public Sefer sefer { get; set; }
        public SelectList Nereden { get; set; }
        public SelectList Nereye { get; set; }

    }
}
