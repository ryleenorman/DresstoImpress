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
    public class DetailsModel : PageModel
    {
        private readonly DresstoImpress.Data.ApplicationDbContext _context;

        public DetailsModel(DresstoImpress.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
