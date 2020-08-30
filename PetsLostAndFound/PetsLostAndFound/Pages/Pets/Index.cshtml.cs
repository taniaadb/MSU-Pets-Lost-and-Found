using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetsLostAndFound.Data;
using PetsLostAndFound.Models;

namespace PetsLostAndFound.Pages.Pets
{
    //this is the default page 
    public class IndexModel : PageModel
    {
        private readonly PetsLostAndFound.Data.PetsLostAndFoundContext _context;

        public IndexModel(PetsLostAndFound.Data.PetsLostAndFoundContext context)
        {
            _context = context;
        }

        public IList<Pet> Pet { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Breeds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PetBreed { get; set; }


        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Pet
                                            orderby m.Breed
                                            select m.Breed;

            var pets = from p in _context.Pet
                         select p;
            if (!string.IsNullOrEmpty(SearchString))
            {
                pets = pets.Where(s => s.RegisterId.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(PetBreed))
            {
                pets = pets.Where(x => x.Breed == PetBreed);
            }
            Breeds = new SelectList(await genreQuery.Distinct().ToListAsync());

            Pet = await pets.ToListAsync();
        }
    }
}
