using System;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var context = new ProtectedSpeciesContext())
            {

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var species1 = new Species
                {
                    SpeciesName = "Cougars"
                };

                species1.Animal = new List<Animal>
                {
                    new Animal { AnimalName = "Cougar Blancs", NumberOfIdentified = 3},
                 };

                context.Add(species1);


                var species2 = new Species
                {
                    SpeciesName = "Tigres"
                };

                species2.Animal = new List<Animal>
                {
                    new Animal { AnimalName = "Tigres Blancs", NumberOfIdentified = 100},
                };

                context.Add(species2);


                var species3 = new Species
                {
                    SpeciesName = "Tortue"
                };

                species3.Animal = new List<Animal>
                {
                    new Animal { AnimalName = "Tortue Albinos", NumberOfIdentified = 15},
                };

                context.Add(species3);

                context.SaveChanges();

                foreach (Species species in context.Species.Include(c => c.Animal))
                {
                    Console.WriteLine(species.SpeciesName);

                    foreach (Animal animal in species.Animal)
                    {
                        Console.WriteLine("\t" + animal.AnimalName + " " + animal.NumberOfIdentified);
                    }
                }
            }

            //static void Main(string[] args)
            //{
                //CreateDatabase();
                //ProtectedSpeciesContext context = new ProtectedSpeciesContext();
                //foreach (Species species in context.Species.Include(c => c.Animal))
                //{
                //    Console.WriteLine(species.SpeciesName);

                //    foreach (Animal animal in species.Animal)
                //    {
                //        Console.WriteLine("\t" + animal.AnimalName + " " + animal.NumberOfIdentified);
                //    }
                //}


                //private static void CreateDatabase()
                //{
                //    ProtectedSpeciesContext context = new ProtectedSpeciesContext();
                //    context.Database.EnsureDeleted();
                //    context.Database.EnsureCreated();

                //    ICollection<Animal> cougars = new List<Animal>
                //    {
                //        new Animal {AnimalName = "Cougar Blanc", NumberOfIdentified = 3},
                //    };

                //    ICollection<Animal> tigres = new List<Animal>
                //    {
                //        new Animal {AnimalName = "Tigre Blanc", NumberOfIdentified = 100},
                //    };

                //    ICollection<Animal> tortues = new List<Animal>
                //    {
                //        new Animal {AnimalName = "Tortue Albinos", NumberOfIdentified = 15},
                //    };

                //    Species cougarsSpecies = new Species { SpeciesName = "Cougar", Animal = cougars};
                //    Species tigresSpecies = new Species { SpeciesName = "Tigre", Animal = tigres };
                //    Species tortuesSpecies = new Species { SpeciesName = "Tortue", Animal = tortues };

                //    context.AddRange(cougarsSpecies, tigresSpecies, tortuesSpecies);
                //    context.SaveChanges();
                //}



            }
    }
}
