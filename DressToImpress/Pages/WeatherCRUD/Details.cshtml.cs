using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DresstoImpress.Data;
using DresstoImpressAPI2.Entities;

namespace DresstoImpress.Pages.WeatherCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly DresstoImpress.Data.ApplicationDbContext _context;

        public DetailsModel(DresstoImpress.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Weather Weather { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weather = await _context.Weather.FirstOrDefaultAsync(m => m.WeatherID == id);
            if (weather == null)
            {
                return NotFound();
            }
            else
            {
                Weather = weather;
            }
            return Page();
        }
    }
}
