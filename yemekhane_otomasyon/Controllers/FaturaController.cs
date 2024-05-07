using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yemekhane_otomasyon.Models.Siniflar;

namespace yemekhane_otomasyon.Controllers
{
    public class FaturaController : Controller
    {
        // GET: Fatura  
        Context c = new Context();
        public ActionResult Index()
        {
            var liste = c.Faturas.ToList();
            return View(liste);
        }

        [HttpGet]
        public ActionResult FaturaEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FaturaEkle(Fatura f)
        {
            c.Faturas.Add(f);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FaturaGetir(int id)
        {
            var ftr = c.Faturas.Find(id);
            return View("FaturaGetir", ftr);
        }

        public ActionResult FaturaGuncelle(Fatura f)
        {
            var ftr = c.Faturas.Find(f.FaturaID);
            ftr.FaturaSeriNo = f.FaturaSeriNo;
            ftr.FaturaSiraNo = f.FaturaSiraNo;     
            ftr.Tarih = f.Tarih;
            ftr.Toplam = f.Toplam;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}