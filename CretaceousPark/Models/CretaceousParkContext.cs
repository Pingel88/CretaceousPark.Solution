using Microsoft.EntityFrameworkCore;

namespace CretaceousPark.Models
{
  public class CretaceousParkContext : DbContext
  {
    public CretaceousParkContext(DbContextOptions<CretaceousParkContext> options)
      : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Matilda", Species = "Woolly Mammoth", Age = 7, Gender = "Female" },
          new Animal { AnimalId = 2, Name = "Rexie", Species = "Stegosaurus", Age = 10, Gender = "Female" },
          new Animal { AnimalId = 3, Name = "Saffron", Species = "Pachycephalosaurus", Age = 2, Gender = "Female" },
          new Animal { AnimalId = 4, Name = "Pip", Species = "Megalodon", Age = 4, Gender = "Male" },
          new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Therizinosaurus", Age = 22, Gender = "Male" }
        );
    }
  }
}