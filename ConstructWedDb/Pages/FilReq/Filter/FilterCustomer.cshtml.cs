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
    public class FilterCustomerModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;
        public FilterCustomerModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }
        public Customer Customer { get; set; }
        public IList<Order> Order { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.ID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            Order = await _context.Order.Where(m => m.CustomerID == Customer.ID).ToListAsync();
            return Page();
        }
    }
}
