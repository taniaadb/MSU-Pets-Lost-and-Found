using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsLostAndFound.Models
{
    public class OtherViewModel
    {
        public string PetName { get; set; }
        public int Age { get; set; }
        public BaseType Type { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public bool Microchipped { get; set; }
        public string Microchip { get; set; }
        public string RFID { get; set; }
        public bool? Lost { get; set; }

        public DateTime? LastSeen { get; set; }

        // TO DO: Link the bird list to a database
        public List<Other> OtherList { get; set; }
    }
}
