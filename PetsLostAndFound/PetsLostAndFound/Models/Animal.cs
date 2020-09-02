using System;
using System.ComponentModel.DataAnnotations;


namespace PetsLostAndFound.Models
{
    //cannot scaffold if abstract
    public class Animal 
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3), Required]
        public string PetName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$"), Required, StringLength(30)]
        public int? Age { get; set; }
        public string Breed { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public BaseType Type { get; set; }
        public string Description { get; set; }
        [Required]
        public bool Microchipped { get; set; }
        public string RFID { get; set; }

        //did not manage to add line in db table
        //public bool Lost { get; set; }
          
        public bool? Lost { get; set; }

        //making this field optional!
        //can use display format if you want the fields to look different
        [Display(Name = "Lost Date"), DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1966", "1/1/2021")]
        public DateTime? LastSeen { get; set; }
    }

    public enum BaseType
    {
        Dog,
        Cat,
        Bird,
        Other
    }
}
