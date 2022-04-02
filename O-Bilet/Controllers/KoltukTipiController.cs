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
    public class KoltukTipiController : Controller
    {
        Servis<KoltukTipi> servis;
        public KoltukTipiController()
        {
            Repository<KoltukTipi> repository = new Repository<KoltukTipi>();
            servis = new Servis<KoltukTipi>(repository);
        }
        // GET: KoltukTipi
        public ActionResult KoltukTipleri()=>  View(servis.Tumu());
        public ActionResult Ekle()=>View();
        [HttpPost]
        public ActionResult Ekle(KoltukTipi Tipi)
        {
            Tipi.KoltukTipiAdi = Tipi.SolKoltuk + "+" + Tipi.SagKoltuk;
            servis.Ekle(Tipi);
            return RedirectToAction("KoltukTipleri");
        }
        public ActionResult Sil(int id)
        {
            servis.Sil(id);
            return RedirectToAction("KoltukTipleri");
        }
    }
}