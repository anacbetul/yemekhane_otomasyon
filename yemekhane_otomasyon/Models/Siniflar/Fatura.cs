using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace yemekhane_otomasyon.Models.Siniflar
{
    public class Fatura
    {
        [Key]
        public int FaturaID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string FaturaSeriNo { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(600)]
        public string FaturaSiraNo { get; set; }

        public DateTime Tarih { get; set; }

        public decimal Toplam { get; set; }

        //public SatisHareket SatisHareket { get; set; }
    }
    
}