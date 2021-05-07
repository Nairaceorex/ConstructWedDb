using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConstructWedDb.Data;
using ConstructWedDb.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ConstructWedDb.Pages.Staffs
{
    public class DetailsModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;

        public DetailsModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            ViewData["PositionID"] = new SelectList(_context.Position, "ID", "Name");
            return Page();
        }

        public Staff Staff { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Staff = await _context.Staff
                .Include(s => s.Position).FirstOrDefaultAsync(m => m.ID == id);

            if (Staff == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
