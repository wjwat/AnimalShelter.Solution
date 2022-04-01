using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AnimalShelter.Api.Models
{
  public class AnimalShelterApiContext: DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
      // empty
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          SeedAnimalData()
        );
    }

    private List<Animal> SeedAnimalData()
    {
      var animals = new List<Animal>();
      using (StreamReader s = new StreamReader(@"Animals.json"))
      {
        string j = s.ReadToEnd();
        animals = JsonSerializer.Deserialize<List<Animal>>(j);
      }

      return animals;
    }
  }
}