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
            //here we are using the data from database!
            using (var context = new PetsLostAndFoundContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PetsLostAndFoundContext>>()))
            {
                // Look for any pets.
                if (context.Animal.Any())
                {
                    return;   // DB has been seeded
                }

                context.Animal.AddRange(
                            new Dog()
                            {
                                //Id = 1,
                                PetName = "Rambo",
                                Breed = "Border Collie",
                                Age = 10,
                                Type = BaseType.Dog,
                                ImageUrl = "",
                                Description = "Old doggo",
                                Microchipped = true,
                                RFID = "QS125",
                                Lost = false

                            },

                            new Cat()
                            {
                                //Id = 2,
                                PetName = "Munchkin",
                                Breed = "Persian",
                                Age = 3,
                                ImageUrl = "",
                                Description = "Old cat munch",
                                Microchipped = true,
                                RFID = "JU188",
                                Lost = true,
                                LastSeen = DateTime.Parse("2010-2-23")
                            },

                            new Bird()
                            {
                                //Id = 3,
                                PetName = "Bird Pet name",
                                ImageUrl = "",
                                Age = 4,
                                Type = BaseType.Bird,
                                Breed = "",
                                Description = "",
                                Microchipped = false,
                                RFID = ""
                            },

                            new Other()
                            {
                                //Id = 1,
                                PetName = "Other Pet name",
                                ImageUrl = "",
                                Age = 9,
                                Type = BaseType.Other,
                                Breed = "",
                                Description = "",
                                Microchipped = false,
                                RFID = ""
                            }
                        ); ;
                context.SaveChanges();
            }
        }
    }
}
