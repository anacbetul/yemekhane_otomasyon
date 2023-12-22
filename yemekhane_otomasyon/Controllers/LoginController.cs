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
                return RedirectToAction("Index", "Yemekler");
            }
            else 
            {
                return RedirectToAction("Index", "Login");
            }
            
        }

        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(Admin a)
        {
            var bilgiler=c.Admins.FirstOrDefault(x => x.AdminTC == a.AdminTC && x.AdminSifre == a.AdminSifre);
            if(bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.AdminTC.ToString(), false);
                Session["AdminTC"] = bilgiler.AdminTC.ToString();
                return RedirectToAction("Index", "Ogrenci");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}