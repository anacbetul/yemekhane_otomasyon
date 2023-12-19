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
            var degerler=c.Ogrencis.Where(x=>x.Durum==true).ToList();
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
            if(!ModelState.IsValid)
            {
                return View("OgrenciEkle");
            }
            o.Durum = true;
            c.Ogrencis.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public  ActionResult OgrenciSil(int id)
        {
            var ogrenci = c.Ogrencis.Find(id);
            ogrenci.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult OgrenciGetir(int id)
        {
            var ogrenci = c.Ogrencis.Find(id);
            return View("OgrenciGetir",ogrenci);
        }
        
       public ActionResult OgrenciGuncelle(Ogrenci o)
        {
            if (!ModelState.IsValid)
            {
                return View("OgrenciGetir");
            }
            var ogr = c.Ogrencis.Find(o.OgrenciID);
            ogr.OgrenciAd = o.OgrenciAd;
            ogr.OgrenciSoyad = o.OgrenciSoyad;
            ogr.OgrenciTc = o.OgrenciTc;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}