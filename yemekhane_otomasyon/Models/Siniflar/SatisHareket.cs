using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace yemekhane_otomasyon.Models.Siniflar
{
    public class SatisHareket
    {
        [Key]
        public int SatisID { get; set; }
        //yemek
        //ogrenci
        //personel
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamFiyat { get; set; }
        public ICollection<Yemekler> Yemeklers { get; set; }
        public ICollection<Ogrenci> Ogrencis { get; set; }
        public ICollection<Personel> Personels { get; set; }

    }
}