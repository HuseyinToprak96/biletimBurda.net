using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace DataLayer
{
   public class Context:DbContext
    {
        public Context()
        {
                Database.SetInitializer(new initDB());
        }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Bilet> Biletler { get; set; }
        public DbSet<KoltukTipi> KoltukTipleri { get; set; }
        public DbSet<Otobus> Otobusler { get; set; }
        public DbSet<Durak> Duraklar { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Sefer> Seferler { get; set; }
    }
}
