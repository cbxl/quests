using Microsoft.EntityFrameworkCore;

namespace LinQ
{
    class ProtectedSpeciesContext : DbContext
    {
        public virtual DbSet<Species>Species { get; set; }
        public virtual DbSet<Animal> Animal { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LOCALHOST\SQLEXPRESS;Database=ProtectedSpecies;Integrated Security=True;MultipleActiveResultSets=True");
        }
    }
}
