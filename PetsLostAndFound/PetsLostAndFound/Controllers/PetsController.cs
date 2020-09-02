using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetsLostAndFound.Data;
using PetsLostAndFound.Models;

namespace PetsLostAndFound.Controllers
{
    public class PetsController : Controller
    {
        private readonly PetsLostAndFoundContext _context;

        public PetsController(PetsLostAndFoundContext context)
        {
            _context = context;
        }

        // GET: Pets
        public async Task<IActionResult> Index(string petBreed, string searchString)
        {
            //OBS: we could search by type and breed as well when we have the database and classes
            //info about this in the tutorial
            //defined linq query
            IQueryable<string> breedQuery = from p in _context.Pet
                                            orderby p.Breed
                                            select p.Breed;

            var pets = from pet in _context.Pet
                       select pet;
            if (!String.IsNullOrEmpty(searchString))
            {
                pets = pets.Where(p => p.RegisterId.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(petBreed))
            {
                pets = pets.Where(x => x.Breed == petBreed);
            }

            var petBreedVM = new PetBreedViewModel
            {
                Breeds = new SelectList(await breedQuery.Distinct().ToListAsync()),
                Pets = await pets.ToListAsync()
            };

            return View(petBreedVM);
        }

 

        // GET: Pets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // GET: Pets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,ImageUrl,Description,Microchipped,Microchip,RegisterId,AdoptionDate,Breed,Lost,LastSeen")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pet);
        }

        // GET: Pets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }
            return View(pet);
        }

        // POST: Pets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //only include fields you want to change - can make other fields invisible
        public async Task<IActionResult> Edit(int id, [Bind("ImageUrl,Description,Microchipped,Microchip,RegisterId,Lost,LastSeen")] Pet pet)
        {
            if (id != pet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetExists(pet.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pet);
        }

        // GET: Pets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // POST: Pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pet = await _context.Pet.FindAsync(id);
            _context.Pet.Remove(pet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetExists(int id)
        {
            return _context.Pet.Any(e => e.Id == id);
        }
    }
}
