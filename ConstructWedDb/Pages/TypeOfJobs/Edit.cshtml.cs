using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConstructWedDb.Data;
using ConstructWedDb.Models;

namespace ConstructWedDb.Pages.TypeOfJobs
{
    public class EditModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;

        public EditModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TypeOfJob TypeOfJob { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypeOfJob = await _context.TypeOfJob
                .Include(t => t.Material1)
                .Include(t => t.Material2)
                .Include(t => t.Material3).FirstOrDefaultAsync(m => m.ID == id);

            if (TypeOfJob == null)
            {
                return NotFound();
            }
           ViewData["Material1ID"] = new SelectList(_context.Material, "ID", "Name");
           ViewData["Material2ID"] = new SelectList(_context.Material, "ID", "Name");
           ViewData["Material3ID"] = new SelectList(_context.Material, "ID", "Name");
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

            _context.Attach(TypeOfJob).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeOfJobExists(TypeOfJob.ID))
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

        private bool TypeOfJobExists(long id)
        {
            return _context.TypeOfJob.Any(e => e.ID == id);
        }
    }
}
