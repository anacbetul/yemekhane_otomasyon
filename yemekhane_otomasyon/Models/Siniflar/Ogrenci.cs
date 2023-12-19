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
        //testaSs
        [Key]
        public int OgrenciID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string OgrenciAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string OgrenciSoyad{ get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Şifre { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string OgrenciTc{ get; set; }

        public bool YemekDurum { get; set; }

        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}