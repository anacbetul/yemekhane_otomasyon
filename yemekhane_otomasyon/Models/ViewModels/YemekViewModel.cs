using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using yemekhane_otomasyon.Models.Siniflar;

namespace yemekhane_otomasyon.Models.ViewModels
{
    public class YemekViewModel
    {
        public string GunAdi { get; set; }
        public List<YemekTur> YemekTurListesi { get; set; }
        public List<Yemekler> YemeklerListesi { get; set; }

    }
}