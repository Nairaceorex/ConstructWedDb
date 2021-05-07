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
    public class FilterOrderModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;
        public FilterOrderModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }
        public TypeOfJob TypeOfJob { get; set; }
        public IList<Order> Order { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypeOfJob = await _context.TypeOfJob.FirstOrDefaultAsync(m => m.ID == id);

            if (TypeOfJob == null)
            {
                return NotFound();
            }
            Order = await _context.Order.Where(m => m.TypeOfJobID == TypeOfJob.ID).ToListAsync();
            return Page();
        }
    }
}
