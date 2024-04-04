using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DresstoImpress.Data;
using DresstoImpressAPI2.Entities;

namespace DresstoImpress.Pages.ClothingBySeasonCRUD
{
    public class EditModel : PageModel
    {
        private readonly DresstoImpress.Data.ApplicationDbContext _context;

        public EditModel(DresstoImpress.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ClothingBySeason ClothingBySeason { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothingbyseason =  await _context.ClothingBySeason.FirstOrDefaultAsync(m => m.ClothingID == id);
            if (clothingbyseason == null)
            {
                return NotFound();
            }
            ClothingBySeason = clothingbyseason;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ClothingBySeason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClothingBySeasonExists(ClothingBySeason.ClothingID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClothingBySeasonExists(int id)
        {
            return _context.ClothingBySeason.Any(e => e.ClothingID == id);
        }
    }
}
