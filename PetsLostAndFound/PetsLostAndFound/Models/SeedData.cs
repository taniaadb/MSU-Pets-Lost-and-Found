using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PetsLostAndFound.Data;

namespace PetsLostAndFound.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PetsLostAndFoundContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PetsLostAndFoundContext>>()))
            {
                // Look for any pets.
                if (context.Pet.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pet.AddRange(
                            new Pet
                            {
                                Name = "Rambo",
                                Breed = "Border Collie",
                                ImageUrl = "",
                                Description = "Old doggo",
                                Microchipped = false,
                                Microchip = "",
                                RegisterId = "QS125",
                                AdoptionDate = DateTime.Parse("2000-3-13"),
                                Lost = false,
                                LastSeen = DateTime.Parse("2020-3-1")

                            },

                            new Pet
                            {
                                Name = "Munchkin",
                                Breed = "Persian",
                                ImageUrl = "",
                                Description = "Old cat munch",
                                Microchipped = false,
                                Microchip = "",
                                RegisterId = "JU188",
                                Lost = false,
                                AdoptionDate = DateTime.Parse("2002-2-2"),
                                LastSeen = DateTime.Parse("2020-5-5")

                            }
                        ); ;
                context.SaveChanges();
            }
        }
    }
}
