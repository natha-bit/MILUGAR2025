using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PMILUGAR2025.web.Data.Entities;

namespace PMILUGAR2025.web.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Entities.Apartamento> Apartamentos { get; set; }
        public DbSet<Entities.Reserva> Reservas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entities.Apartamento>()
                .HasOne(a => a.Propietario)
                .WithMany(u => u.Apartamentos)
                .HasForeignKey(a => a.PropietarioId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Entities.Reserva>()
                .HasOne(r => r.Usuario)
                .WithMany(u => u.Reservas)
                .HasForeignKey(r => r.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
