using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace yemekhane_otomasyon.Models.Siniflar
{
    public class Admin
    {

        [Key]
        public int AdminId { get; set; }
     
        public int AdminTC { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string KullaniciAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]

        public string AdminSifre { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1)]

        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}