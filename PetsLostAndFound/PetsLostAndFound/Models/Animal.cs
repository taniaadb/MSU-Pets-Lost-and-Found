using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsLostAndFound.Models
{
    public class Animal // use partial keyword
    {
        public int Id { get; set; }
        public string PetName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool Microchipped { get; set; }
        public string Microchip { get; set; }
        public string RegisterId { get; set; }



    }

    public enum BaseType
    {
        Dog, 
        Cat,
        Bird,
        Other
    }
}
