using Microsoft.EntityFrameworkCore;

namespace Teknokent2.Models
{
    public class Context:DbContext
    {

        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=Teknokent2; integrated security=true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
