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
       
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamFiyat { get; set; }
        public Yemekler Yemekler { get; set; }
        public Ogrenci Ogrenci { get; set; }
      
        public ICollection<Fatura> Faturas { get; set; }

        public Admin Admin { get; set; }


    }
}