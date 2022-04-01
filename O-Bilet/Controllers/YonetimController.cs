using DataLayer;
using EntityLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace O_Bilet.Controllers
{
    public class YonetimController : Controller
    {
        // GET: Yonetim
        Servis<Otobus> servis;
        public YonetimController()
        {
            
            Repository<Otobus> repository = new Repository<Otobus>();
            servis = new Servis<Otobus>(repository);
        }
        public ActionResult YonetimPaneli()
        {
            return View(servis.Tumu().Where(o=>o.SuanKiDurumu=="Yolda"));
        }
    }
}