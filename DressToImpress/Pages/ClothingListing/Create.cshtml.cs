﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DresstoImpress.Data;
using DresstoImpressAPI2.Entities;

namespace DresstoImpress.Pages.ClothingCRUD
{
    public class CreateModel : PageModel
    {
        private readonly DresstoImpress.Data.ApplicationDbContext _context;

        public CreateModel(DresstoImpress.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Clothing Clothing { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Clothing.Add(Clothing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
