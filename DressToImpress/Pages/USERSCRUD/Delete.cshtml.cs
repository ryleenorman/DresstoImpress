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
    public class DeleteModel : PageModel
    {
        private readonly DresstoImpress.Data.ApplicationDbContext _context;

        public DeleteModel(DresstoImpress.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.USERS.FindAsync(id);
            if (users != null)
            {
                USERS = users;
                _context.USERS.Remove(USERS);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
