using BusinessLogisLayer;
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
    public class RotaController : Controller
    {
        Servis<Rota> servis;
        private readonly BLL _bLL;
        public RotaController()
        {
            _bLL = new BLL();
            Repository<Rota> repository = new Repository<Rota>();
            servis = new Servis<Rota>(repository);
        }
        // GET: Rota
        public ActionResult Rotalar()=> View(servis.Tumu());
        public ActionResult RotaSil(int id)
        {
            servis.Sil(id);
            return RedirectToAction("Rotalar");
        }
        public ActionResult RotaEkle() => View(_bLL.RotaEkle());
        [HttpPost]
        public ActionResult RotaEkle(Rota rota)
        {
            servis.Ekle(rota);
            return RedirectToAction("Rotalar");
        }
    }
}