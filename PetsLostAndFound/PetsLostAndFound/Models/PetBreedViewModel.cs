using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetsLostAndFound.Models
{
    public class PetBreedViewModel
    {
        public List<Pet> Pets { get; set; }
        public SelectList Breeds { get; set; }
        public string PetBreed { get; set; }
        public string SearchString { get; set; }
    }
}
