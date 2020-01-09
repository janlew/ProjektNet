using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProjektoNeto.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Samochod> Samochody { get; set; }

        public DbSet<Opinia> Opinie { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Opinia>()
                .HasOne(p => p.Samochod)
                .WithMany(b => b.Opinie)
                .HasForeignKey(p => p.SamochodId);
      }


    }
}
