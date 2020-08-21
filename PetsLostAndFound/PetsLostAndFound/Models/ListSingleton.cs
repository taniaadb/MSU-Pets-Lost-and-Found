using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PetsLostAndFound.Models
{
    // Singleton to contain data for display
    public class ListSingleton
    {
        private List<Animal> _allAnimals;

        private static ListSingleton _instance = null;

        public static ListSingleton Instance 
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new ListSingleton();
                }
                return _instance;
            }
             }

        private ListSingleton()
        {
            _allAnimals = new List<Animal>()
            {
                new Dog()
                {
                    Id = 1,
                    PetName = "Dog Pet name",
                    ImageUrl = "",
                    Type = BaseType.Dog,
                    Breed = "",
                    Description = "",
                    Microchipped = false,
                    Microchip = "",
                    RegisterId = ""
                },

                new Cat()
                {
                    Id = 2,
                    PetName = "Cat Pet name",
                    ImageUrl = "",
                    Type = BaseType.Cat,
                    Breed = "",
                    Description = "",
                    Microchipped = false,
                    Microchip = "",
                    RegisterId = ""
                },

                new Bird()
                {
                    Id = 3,
                    PetName = "Bird Pet name",
                    ImageUrl = "",
                    Type = BaseType.Bird,
                    Breed = "",
                    Description = "",
                    Microchipped = false,
                    Microchip = "",
                    RegisterId = ""
                },

                new Other()
                {
                    Id = 1,
                    PetName = "Other Pet name",
                    ImageUrl = "",
                    Type = BaseType.Other,
                    Breed = "",
                    Description = "",
                    Microchipped = false,
                    Microchip = "",
                    RegisterId = ""
                }
            };
        }

        public List<Animal> GetAllAnimals()
        {
            return _allAnimals;
        }




       
    }
}
