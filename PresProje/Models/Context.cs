using Microsoft.EntityFrameworkCore;

namespace PresProje.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=10.240.240.25;Persist Security Info=True;User ID=rpo;Password=Sms*Rp16!0;TrustServerCertificate=True");
        }

        public DbSet<PRES_PROD> PRES_PROD { get; set; }
        public DbSet<deneme_pres> deneme_pres { get; set; }
        public DbSet<Deneme> Deneme { get; set; }
        public DbSet<PARCA_LISTESI> PARCA_LISTESI { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<HAT_PRES> HAT_PRES { get; set; }
        public DbSet<Hata_Listesi> Hata_Listesi { get; set; }

    }
}

