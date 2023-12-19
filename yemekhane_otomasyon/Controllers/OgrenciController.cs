using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yemekhane_otomasyon.Models.Siniflar;

namespace yemekhane_otomasyon.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        Context c= new Context();
        public ActionResult Index()
        {
            var degerler=c.Ogrencis.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult OgrenciEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OgrenciEkle(Ogrenci o)
        {
            c.Ogrencis.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        //public ActionResult OgrenciSil(int id)
        //{
        //    var ogrenci = c.Ogrencis.Find(id);
        //    c.Ogrencis.Remove(ogrenci);
        //    c.SaveChanges();
        //    return RedirectToAction("Index");
        //}   
    }
}