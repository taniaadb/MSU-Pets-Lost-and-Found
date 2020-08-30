﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetsLostAndFound.Data;
using PetsLostAndFound.Models;

namespace PetsLostAndFound.Pages.Pets
{
    public class DetailsModel : PageModel
    {
        private readonly PetsLostAndFound.Data.PetsLostAndFoundContext _context;

        public DetailsModel(PetsLostAndFound.Data.PetsLostAndFoundContext context)
        {
            _context = context;
        }

        public Pet Pet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pet = await _context.Pet.FirstOrDefaultAsync(m => m.ID == id);

            if (Pet == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
