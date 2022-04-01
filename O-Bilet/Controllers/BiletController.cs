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
    public class BiletController : Controller
    {
        Servis<Bilet> servis;
        private readonly BLL _bLL;
        public BiletController()
        {
            _bLL = new BLL();
            Repository<Bilet> repository = new Repository<Bilet>();
            servis = new Servis<Bilet>(repository);
        }
        // GET: Bilet
       
        public ActionResult BiletAl(int koltukN,int seferId)
        {
            int id = Convert.ToInt32(Session["ID"]);
            _bLL.BiletAl(seferId, koltukN,id);
            return RedirectToAction("../Bilet/Biletlerim");
        }
        public ActionResult Biletlerim()
        {
            int id = Convert.ToInt32(Session["ID"]);
            return View(servis.Tumu().Where(b => b.UyeId == id).ToList()); 
        }
        public ActionResult BiletIptal(int id)
        {
            servis.Sil(id);
            return RedirectToAction("Biletlerim");
        }
    }
}