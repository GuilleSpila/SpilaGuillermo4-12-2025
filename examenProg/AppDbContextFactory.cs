using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace examenProg;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
 public AppDbContext CreateDbContext(string[] args)
 {
 var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
 optionsBuilder.UseSqlServer("Server=GUILLOTEX\\SQLEXPRESS;Database=ProgFinal1;Trusted_Connection=True;TrustServerCertificate=True;");
 return new AppDbContext();
 }
}