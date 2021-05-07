using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConstructWedDb.Data;
using ConstructWedDb.Models;

namespace ConstructWedDb.Pages.Brigades
{
    public class DeleteModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;

        public DeleteModel(ConstructWedDb.Data.ConstructWedDbContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Brigade = await _context.Brigade.FindAsync(id);

            if (Brigade != null)
            {
                _context.Brigade.Remove(Brigade);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
