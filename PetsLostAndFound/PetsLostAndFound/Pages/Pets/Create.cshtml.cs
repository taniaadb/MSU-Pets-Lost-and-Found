using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetsLostAndFound.Data;
using PetsLostAndFound.Models;

namespace PetsLostAndFound.Pages.Pets
{
    public class CreateModel : PageModel
    {
        private readonly PetsLostAndFound.Data.PetsLostAndFoundContext _context;

        public CreateModel(PetsLostAndFound.Data.PetsLostAndFoundContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pet Pet { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pet.Add(Pet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
