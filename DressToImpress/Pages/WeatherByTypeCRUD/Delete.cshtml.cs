using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DresstoImpress.Data;
using DresstoImpressAPI2.Entities;

namespace DresstoImpress.Pages.WeatherByTypeCRUD
{
    public class DeleteModel : PageModel
    {
        private readonly DresstoImpress.Data.ApplicationDbContext _context;

        public DeleteModel(DresstoImpress.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WeatherByType WeatherByType { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weatherbytype = await _context.WeatherByType.FirstOrDefaultAsync(m => m.WeatherID == id);

            if (weatherbytype == null)
            {
                return NotFound();
            }
            else
            {
                WeatherByType = weatherbytype;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weatherbytype = await _context.WeatherByType.FindAsync(id);
            if (weatherbytype != null)
            {
                WeatherByType = weatherbytype;
                _context.WeatherByType.Remove(WeatherByType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
