using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConstructWedDb.Data;
using ConstructWedDb.Models;

namespace ConstructWedDb.Pages.Brigades
{
    public class CreateModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;

        public CreateModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Staff1ID"] = new SelectList(_context.Staff, "ID", "FullName");
        ViewData["Staff2ID"] = new SelectList(_context.Staff, "ID", "FullName");
        ViewData["Staff3ID"] = new SelectList(_context.Staff, "ID", "FullName");
            return Page();
        }

        [BindProperty]
        public Brigade Brigade { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Brigade.Add(Brigade);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
