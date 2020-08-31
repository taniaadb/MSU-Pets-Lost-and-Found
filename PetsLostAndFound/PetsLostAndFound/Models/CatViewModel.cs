using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsLostAndFound.Models
{
    public class CatViewModel
    {
        public string PetName { get; set; }
        public int Age { get; set; }
        public BaseType Type { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public bool Microchipped { get; set; }
        public string Microchip { get; set; }
        public string RFID { get; set; }

        // TO DO: Link the cat list to a database
        public List<Cat> CatList { get; set; }
    }
}
