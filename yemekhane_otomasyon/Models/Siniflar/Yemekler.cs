using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace yemekhane_otomasyon.Models.Siniflar
{
    public class Yemekler
    {
        [Key]
        public int YemekId { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength(30)]
        public string YemekAd { get; set; }

        public short YemekStok { get; set; }
        public decimal Fiyat { get; set; }
        public bool Durum { get; set; }
        public YemekTur YemekTur { get; set; }
        public SatisHareket SatisHareket { get; set; }

    }
}