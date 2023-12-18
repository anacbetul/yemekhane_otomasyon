using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace yemekhane_otomasyon.Models.Siniflar
{
   
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        
        public DbSet<Fatura> Faturas { get; set; }
       
        public DbSet<Ogrenci> Ogrencis { get; set; }
       
        public DbSet<SatisHareket> SatisHarekets { get; set; }
        public DbSet<Yemekler> Yemeklers { get; set; }
        public DbSet<YemekTur> YemekTurs { get; set; }
    }
}