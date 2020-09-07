using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetsLostAndFound.Models
{
    public class AnimalTypeViewModel
    {
        public List<Animal> Animal { get; set; }
        public SelectList Type { get; set; }
        public string AnimalType { get; set; }
        public string SearchString { get; set; }
    }
}
