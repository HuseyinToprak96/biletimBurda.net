using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using EntityLayer;
using EntityLayer.Interfaces;
using ServiceLayer;
using BusinessLogisLayer;
using BusinessLogisLayer.ViewModels;

namespace O_Bilet.Controllers
{
    public class UyeController : Controller
    {
        Servis<Uye> servis;
        private readonly BLL _bLL;
        public UyeController()
        {
            _bLL = new BLL();
            Repository<Uye> repository = new Repository<Uye>();
            servis = new Servis<Uye>(repository);
        } 
        // GET: User
        public ActionResult UyeListesi()
        { //Kullanıcının yetkisi tutulur.Admin ise ulaşılır.
            return View(servis.Tumu());
        }
        public ActionResult UyeOl()
        {
            return View(_bLL.UyeOl());
        }
        [HttpPost]
        public ActionResult UyeOl(VMUyeOl vM)
        {
            servis.Ekle(vM.uye);
            return RedirectToAction("Giris");
        }
        public ActionResult UyeBilgileri(int id)
        {
            return View(servis.Bul(id));
        }
        [HttpPost]
        public ActionResult UyeBilgileri(Uye uye)
        {
            servis.Ekle(uye);
            return RedirectToAction("../Page/Index");
        }
        public ActionResult UyeKontrol(int id)
        {
            return View(servis.Bul(id));
        }
        [HttpPost]
        public ActionResult UyeKontrol(Uye uye)
        {
            servis.Guncelle(uye);
            return RedirectToAction("UyeListesi");
        }
        public ActionResult Profilim()
        {
            int id = Convert.ToInt32(Session["ID"]);
            return View(servis.Bul(id));
        }
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(string mail, string sifre)
        {
            var uye = _bLL.Giris(mail, sifre);
            if (uye == null) { 
            TempData["Hata"] = "Hatalı Mail veya Sifre";
                return RedirectToAction("Giris");
            }
            else
            {
                Session["ID"] = uye.UyeId;
                Session["Yetki"] = uye.Yetki;
                Session.Timeout=2;
            }
            return RedirectToAction("../Sefer/SeferBul");
        }
        public ActionResult Cikis()
        {
            Session.Abandon();
            return RedirectToAction("../Sefer/SeferBul");
        }
        [AllowAnonymous]
        public ActionResult SifremiUnuttum() => View();
       

    }
}