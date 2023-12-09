using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace yemekhane_otomasyon.Models.Siniflar
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string OgrenciAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string OgrenciSoyad{ get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string OgrenciGorsel{ get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string OgrenciMail{ get; set; }
       
        public SatisHareket SatisHareket { get; set; }
    }
}