using Microsoft.EntityFrameworkCore;

namespace examenProg;

public class AppDbContext : DbContext
{
 public DbSet<Cancha> Canchas => Set<Cancha>();
 public DbSet<Socio> Socios => Set<Socio>();
 public DbSet<Reserva> Reservas => Set<Reserva>();

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
 optionsBuilder.UseSqlServer("Server=BOSCA\\SQLEXPRESS;Database=ProgFinal1;Trusted_Connection=True;TrustServerCertificate=True;");
 }

 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
 modelBuilder.Entity<Cancha>().Property(c => c.Nombre).IsRequired();
 modelBuilder.Entity<Socio>().Property(s => s.Nombre).IsRequired();
 modelBuilder.Entity<Socio>().Property(s => s.Documento).IsRequired();
 modelBuilder.Entity<Socio>().Property(s => s.CorreoElectronico).IsRequired();
 modelBuilder.Entity<Reserva>().HasKey(r => r.Id);
 }
}