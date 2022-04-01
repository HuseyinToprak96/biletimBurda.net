using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace O_Bilet.Controllers
{
    public class SayfaController : Controller
    {
        // GET: Page
        //Statik Sayfalar
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult OtobusKiralama()
        {
            return View();
        }
    }
}