using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsLostAndFound.Models
{
    public abstract class Animal // use partial keyword ?
    {
        // TO DO: Should add a [Required] field
        public int Id { get; set; }
        public string PetName { get; set; }
        public string ImageUrl { get; set; }
        public BaseType Type { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public bool Microchipped { get; set; }
        public string Microchip { get; set; }
        public string RFID { get; set; }

    }

    public enum BaseType
    {
        Dog, 
        Cat,
        Bird,
        Other
    }
}
