using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yemekhane_otomasyon.Models.ViewModels;
using yemekhane_otomasyon.Models.Siniflar;

namespace yemekhane_otomasyon.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        Context c=new Context();
        public ActionResult Index()
        {
            var gunler = new List<string> { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            var ViewModelList = new List<YemekViewModel>();

            foreach (var gun in gunler)
            {
                var yemeklerListesi = c.Yemeklers.Where(x=>x.Durum==true).ToList(); // Yemekler tablosundan tüm yemekleri alabilirsiniz
                var menuViewModel = new YemekViewModel { GunAdi = gun, YemeklerListesi = yemeklerListesi };

                ViewModelList.Add(menuViewModel);
            }

            return View(ViewModelList);


            //var menuItems = c.Yemeklers.Where(x => x.Durum == true).ToList();
            //return View(menuItems);
        }
    }
}