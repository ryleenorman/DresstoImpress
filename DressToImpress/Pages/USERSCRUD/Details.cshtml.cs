using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DresstoImpress.Data;
using DresstoImpressAPI2.Entities;

namespace DresstoImpress.Pages.USERSCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly DresstoImpress.Data.ApplicationDbContext _context;

        public DetailsModel(DresstoImpress.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public USERS USERS { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.USERS.FirstOrDefaultAsync(m => m.UserID == id);
            if (users == null)
            {
                return NotFound();
            }
            else
            {
                USERS = users;
            }
            return Page();
        }
    }
}
