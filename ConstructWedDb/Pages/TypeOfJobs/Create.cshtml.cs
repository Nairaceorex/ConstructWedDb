using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConstructWedDb.Data;
using ConstructWedDb.Models;

namespace ConstructWedDb.Pages.TypeOfJobs
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
        ViewData["Material1ID"] = new SelectList(_context.Material, "ID", "Name");
        ViewData["Material2ID"] = new SelectList(_context.Material, "ID", "Name");
        ViewData["Material3ID"] = new SelectList(_context.Material, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public TypeOfJob TypeOfJob { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TypeOfJob.Add(TypeOfJob);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
