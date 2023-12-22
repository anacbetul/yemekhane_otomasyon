using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using yemekhane_otomasyon.Models.Siniflar;

namespace yemekhane_otomasyon.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Ogrencilogin()
        {
            //view eklenecek
            return View();
        }

        [HttpPost]
        public ActionResult Ogrencilogin(Ogrenci og)
        {
            var bilgiler= c.Ogrencis.FirstOrDefault(x => x.OgrenciTc == og.OgrenciTc && x.Şifre == og.Şifre);
            if(bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.OgrenciTc, false);
                Session["OgrenciTc"] = bilgiler.OgrenciTc.ToString();
                return RedirectToAction("Index", "Satis");
            }
            else 
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
    }
}