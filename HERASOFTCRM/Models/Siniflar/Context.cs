using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HERASOFTCRM.Models.Siniflar
{
    public class Context:DbContext
    {

        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Kontak> Kontaks { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }

    }
}