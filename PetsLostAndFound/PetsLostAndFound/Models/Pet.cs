using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsLostAndFound.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3), Required]
        public string Name { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$"), Required, StringLength(30)]
        public string Breed { get; set; }

        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool Microchipped { get; set; }
        public string Microchip { get; set; }
        public string RegisterId { get; set; }

        //did not manage to add line in db table
        //public bool Lost { get; set; }

        [Display(Name = "Adoption Date")]
        [DataType(DataType.Date)]
        public DateTime AdoptionDate { get; set; }
        //validation attributes
          
        public bool? Lost { get; set; }

        //making this field optional!
        //can use display format if you want the fields to look different
        [Display(Name = "Lost Date")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1966", "1/1/2021")]
        public DateTime? LastSeen { get; set; }
    }
}
