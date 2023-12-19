using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yemekhane_otomasyon.Models.Siniflar;

namespace yemekhane_otomasyon.Controllers
{
    public class YemeklerController : Controller
    {
        // GET: Yemekler

        Context c = new Context();
        public ActionResult Index()
        {
            var urunler = c.Yemeklers.ToList();
            return View(urunler);
        }
        [HttpGet]
        public ActionResult YeniYemek()
        {

            return View();
        }
        [HttpPost]
        public ActionResult YeniYemek(Yemekler y)
        {  
            c.Yemeklers.Add(y);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}