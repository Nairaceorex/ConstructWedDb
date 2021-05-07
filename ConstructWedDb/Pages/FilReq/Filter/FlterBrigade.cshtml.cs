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
    public class FlterBrigadeModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;
        public FlterBrigadeModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }
        public Brigade Brigade { get; set; }
        public IList<Order> Order { get; set; }
        public IList<Staff> Staff { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Brigade = await _context.Brigade.FirstOrDefaultAsync(m => m.ID == id);

            if (Brigade == null)
            {
                return NotFound();
            }
            Order = await _context.Order.Where(m => m.BrigadeID == Brigade.ID).ToListAsync();
            Staff = await _context.Staff.ToListAsync();
            return Page();
        }
    }
}
