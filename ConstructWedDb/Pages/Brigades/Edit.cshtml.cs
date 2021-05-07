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

namespace ConstructWedDb.Pages.Brigades
{
    public class EditModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;

        public EditModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Brigade Brigade { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Brigade = await _context.Brigade
                .Include(b => b.Staff1)
                .Include(b => b.Staff2)
                .Include(b => b.Staff3).FirstOrDefaultAsync(m => m.ID == id);

            if (Brigade == null)
            {
                return NotFound();
            }
           ViewData["Staff1ID"] = new SelectList(_context.Staff, "ID", "ID");
           ViewData["Staff2ID"] = new SelectList(_context.Staff, "ID", "ID");
           ViewData["Staff3ID"] = new SelectList(_context.Staff, "ID", "ID");
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

            _context.Attach(Brigade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrigadeExists(Brigade.ID))
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

        private bool BrigadeExists(long id)
        {
            return _context.Brigade.Any(e => e.ID == id);
        }
    }
}
