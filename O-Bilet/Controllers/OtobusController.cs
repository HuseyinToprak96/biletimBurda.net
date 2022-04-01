using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer;
using DataLayer;
using BusinessLogisLayer;

namespace O_Bilet.Controllers
{
    public class OtobusController : Controller
    {
        Servis<Otobus> servis;
        private readonly BLL _bLL;
        public OtobusController()
        {
            _bLL = new BLL();
            Repository<Otobus> repository = new Repository<Otobus>();
            servis = new Servis<Otobus>(repository);
        }
        // GET: Otobüs
        public ActionResult OtobusListesi(int? id)
        {
            return View(servis.Tumu());
        }
        public ActionResult OtobusEkle()
        {
            return View(_bLL.OtobusEkleme());
        }
        [HttpPost]
        public ActionResult OtobusEkle(Otobus otobus)
        {
            servis.Ekle(otobus);
            return RedirectToAction("OtobusListesi");
        }
        public ActionResult OtobusSil(int id)
        {
            servis.Sil(id);
            return RedirectToAction("OtobusListesi");
        }
        public ActionResult OtobusGuncelle(int id)
        {
            var otobusGuncelle = _bLL.OtobusEkleme();
            otobusGuncelle.otobus = servis.Bul(id);
            return View(otobusGuncelle);
        }
        [HttpPost]
        public ActionResult OtobusGuncelle(Otobus otobus)
        {
            servis.Guncelle(otobus);
            return View();
        }
        public ActionResult OtobusDetay(int id)
        {
            return View(servis.Bul(id));
        }
    }
}