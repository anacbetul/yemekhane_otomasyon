﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using yemekhane_otomasyon.Models.Siniflar;

namespace yemekhane_otomasyon.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.SatisHarekets.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            List<SelectListItem> deger1 = (from x in c.Yemeklers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.YemekAd,
                                               Value = x.YemekId.ToString(),

                                           }).ToList();
            ViewBag.dgr1 = deger1;

            List<SelectListItem> deger2 = (from x in c.Ogrencis.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.OgrenciAd + " " + x.OgrenciSoyad,
                                               Value = x.OgrenciID.ToString(),

                                           }).ToList();
            ViewBag.dgr2 = deger2;

            //List<SelectListItem> deger3 = (from x in c.Admins.ToList()
            //                               select new SelectListItem
            //                               {
            //                                   Text = x.KullaniciAd,
            //                                   Value = x.AdminId.ToString(),

            //                               }).ToList();

            //ViewBag.dgr3 = deger3;
            return View();
        }

        [HttpPost]
        public ActionResult YeniSatis(SatisHareket s)
        {
            s.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.SatisHarekets.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
