using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yemekhane_otomasyon.Models.Siniflar;

namespace yemekhane_otomasyon.Controllers
{
    public class YemekTurController : Controller
    {
        // GET: YemekTur
        Context c= new Context();
        public ActionResult Index()
        {
            var degerler=c.YemekTurs.ToList();

            return View(degerler);
        }
    }
}