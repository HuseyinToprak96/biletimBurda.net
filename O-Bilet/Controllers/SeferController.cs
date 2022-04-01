using DataLayer;
using EntityLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogisLayer;
using BusinessLogisLayer.ViewModels;

namespace O_Bilet.Controllers
{
    public class SeferController : Controller
    {
        Servis<Sefer> servis;
        private readonly BLL _bLL;
        public SeferController()
        {
            _bLL = new BLL();
            Repository<Sefer> repository = new Repository<Sefer>();
            servis = new Servis<Sefer>(repository);
        }
        // GET: Sefer
        public ActionResult SeferBul() => View(_bLL.seferAra());
        public ActionResult SeferAra(VMseferAra vMseferAra)
        {
           return View(_bLL.seferBul(vMseferAra));
        }
        public ActionResult Seferler()=>View(servis.Tumu().OrderBy(o=>o.OtobusId));
        public ActionResult SeferEkle()=> View(_bLL.seferEkle());
        [HttpPost]
        public ActionResult SeferEkle(Sefer sefer)
        {
            servis.Ekle(sefer);
            _bLL.BiletEkle(sefer);
            return RedirectToAction("Seferler");
        }
        public ActionResult SeferSil(int id)
        {
            servis.Sil(id);
            return RedirectToAction("Seferler");
        }
        public ActionResult SeferGuncelle(int id) {
            var seferAyar = _bLL.seferEkle();
            seferAyar.sefer = servis.Bul(id);
            return View(seferAyar); 
        }
        [HttpPost]
        public ActionResult SeferGuncelle(Sefer sefer)
        {
            servis.Guncelle(sefer);
            return RedirectToAction("Seferler");
        }
    }
}