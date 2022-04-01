using DataLayer;
using EntityLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogisLayer;
namespace O_Bilet.Controllers
{
    public class DurakController : Controller
    {
        // GET: Durak
        Servis<Durak> servis;
       private readonly BLL _bLL;
        public DurakController()
        {
            _bLL = new BLL();
            Repository<Durak> repository = new Repository<Durak>();
            servis = new Servis<Durak>(repository);
        }
        public ActionResult Duraklar()
        {
            return View(servis.Tumu());
        }
        public ActionResult YeniDurakEkle()
        {
            return View(_bLL.durakEkle());
        }
        [HttpPost]
        public ActionResult YeniDurakEkle(Durak durak)
        {
            servis.Ekle(durak);
            return RedirectToAction("Duraklar");
        }
        public ActionResult DurakSil(int id)
        {
            servis.Sil(id);
            return RedirectToAction("Duraklar");
        }
        public ActionResult DurakGuncelle(int id)
        {
            var durak = _bLL.durakEkle().durak = servis.Bul(id);
            return View(durak);
        }
        [HttpPost]
        public ActionResult DurakGuncelle(Durak durak)
        {
            servis.Guncelle(durak);
            return RedirectToAction("Duraklar");
        }
    }
}