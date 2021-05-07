using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructWedDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ConstructWedDb.Pages.FilReq.Filter
{
    public class FilterPositionModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;
        public FilterPositionModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }
        public Position Position { get; set; }
        public IList<Staff> Staff { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = await _context.Position.FirstOrDefaultAsync(m => m.ID == id);

            if (Position == null)
            {
               return NotFound();
            }
            Staff = await _context.Staff.Where(m => m.PositionID == Position.ID).ToListAsync();
            return Page();
        }
    }
}
