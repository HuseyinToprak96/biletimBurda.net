﻿using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BusinessLogisLayer.ViewModels
{
   public class VMseferEkle
    {
        public Sefer sefer { get; set; }
        public SelectList Rotalar { get; set; }
        public SelectList Otobusler { get; set; }
    }
}
