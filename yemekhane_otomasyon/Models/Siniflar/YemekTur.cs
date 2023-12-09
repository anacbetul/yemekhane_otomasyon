using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace yemekhane_otomasyon.Models.Siniflar
{
    public class YemekTur
    {
        [Key]
        public int YemekTurID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string YemekTurAd { get; set; }
        public ICollection<Yemekler> Yemeklers { get; set; }    
    }
}