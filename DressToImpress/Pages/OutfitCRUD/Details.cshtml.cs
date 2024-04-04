using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DresstoImpress.Data;
using DresstoImpressAPI2.Entities;

namespace DresstoImpress.Pages.OutfitCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly DresstoImpress.Data.ApplicationDbContext _context;

        public DetailsModel(DresstoImpress.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Clothing Clothing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothing = await _context.Clothing.FirstOrDefaultAsync(m => m.ClothingID == id);
            if (clothing == null)
            {
                return NotFound();
            }
            else
            {
                Clothing = clothing;
            }
            return Page();
        }
    }
}
