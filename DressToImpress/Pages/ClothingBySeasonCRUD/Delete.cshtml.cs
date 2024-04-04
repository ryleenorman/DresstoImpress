using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DresstoImpress.Data;
using DresstoImpressAPI2.Entities;

namespace DresstoImpress.Pages.ClothingBySeasonCRUD
{
    public class DeleteModel : PageModel
    {
        private readonly DresstoImpress.Data.ApplicationDbContext _context;

        public DeleteModel(DresstoImpress.Data.ApplicationDbContext context)
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

            var clothingbyseason = await _context.ClothingBySeason.FirstOrDefaultAsync(m => m.ClothingID == id);

            if (clothingbyseason == null)
            {
                return NotFound();
            }
            else
            {
                ClothingBySeason = clothingbyseason;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothingbyseason = await _context.ClothingBySeason.FindAsync(id);
            if (clothingbyseason != null)
            {
                ClothingBySeason = clothingbyseason;
                _context.ClothingBySeason.Remove(ClothingBySeason);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
