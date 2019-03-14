using Microsoft.EntityFrameworkCore;

namespace FilRougeApi.Models
{
    public class FilRougeContext : DbContext

    {
        public FilRougeContext(DbContextOptions<FilRougeContext> options)
            : base(options)
        {
        }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Formation> Formations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personne>().ToTable("Personne");
            modelBuilder.Entity<Formation>().ToTable("Formation");
            
        }
    }
}
