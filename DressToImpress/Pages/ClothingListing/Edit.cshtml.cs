﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DresstoImpress.Data;
using DresstoImpressAPI2.Entities;

namespace DresstoImpress.Pages.ClothingCRUD
{
    public class EditModel : PageModel
    {
        private readonly DresstoImpress.Data.ApplicationDbContext _context;

        public EditModel(DresstoImpress.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Clothing Clothing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothing =  await _context.Clothing.FirstOrDefaultAsync(m => m.ClothingID == id);
            if (clothing == null)
            {
                return NotFound();
            }
            Clothing = clothing;
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

            _context.Attach(Clothing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClothingExists(Clothing.ClothingID))
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

        private bool ClothingExists(int id)
        {
            return _context.Clothing.Any(e => e.ClothingID == id);
        }
    }
}
