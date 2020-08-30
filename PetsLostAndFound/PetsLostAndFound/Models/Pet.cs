using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PetsLostAndFound.Models
{
    public class Pet // use partial keyword
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3), Required]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$"), Required, StringLength(30)]
        public string Breed { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool Microchipped { get; set; }
        public string Microchip { get; set; }
        public string RegisterId { get; set; }

        [Display(Name = "Adoption Date")]
        [DataType(DataType.Date)]
        public DateTime AdoptionDate { get; set; }

        public bool? Lost { get; set; }
        [Display(Name = "Lost Date")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1966", "1/1/2021")]
        public DateTime? LostDate { get; set; }



    }
}
