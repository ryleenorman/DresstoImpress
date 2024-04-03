using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DresstoImpress.Data;
using DresstoImpressAPI2.Entities;

namespace DresstoImpress.Pages.FashionCRUD
{
    public class IndexModel : PageModel
    {
        private readonly DresstoImpress.Data.ApplicationDbContext _context;

        public IndexModel(DresstoImpress.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Clothing> Clothing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Clothing = await _context.Clothing.ToListAsync();
        }
    }
}
