using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using yemekhane_otomasyon.Models.Siniflar;

namespace yemekhane_otomasyon.Controllers
{
    public class YemeklerController : Controller
    {
        // GET: Yemekler

        Context c = new Context();
        public ActionResult Index()
        {
            var urunler = c.Yemeklers.Where(x => x.Durum == true).ToList();
            return View(urunler);
        }
        [HttpGet]
        public ActionResult YeniYemek()
        {
            List<SelectListItem> deger1 = (from x in c.YemekTurs.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.YemekTurAd,
                                               Value = x.YemekTurID.ToString(),

                                           }).ToList();
            ViewBag.dgr1 = deger1;

            return View();
        }
        [HttpPost]
        public ActionResult YeniYemek(Yemekler y)
        {
            c.Yemeklers.Add(y);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YemekSil(int id)
        {
            var deger = c.Yemeklers.Find(id);
            deger.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YemekGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.YemekTurs.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.YemekTurAd,
                                               Value = x.YemekTurID.ToString(),

                                           }).ToList();
            ViewBag.dgr1 = deger1;

            var yemekdeger = c.Yemeklers.Find(id);
            return View("YemekGetir", yemekdeger);
        }
    }
}