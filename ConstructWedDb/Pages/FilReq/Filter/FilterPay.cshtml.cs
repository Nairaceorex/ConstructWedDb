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
    public class FilterPayModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;
        public FilterPayModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get; set; }
        public IList<Staff> Staff { get; set; }
        public IList<Brigade> Brigade { get; set; }
        public IList<TypeOfJob> TypeOfJob { get; set; }
        public IList<Customer> Customer { get; set; }
        public async Task<IActionResult> OnGetAsync(bool? pay)
        {
            if (pay == null)
            {
                return NotFound();
            }


            Order = await _context.Order.Where(m => m.AboutPayment == pay).ToListAsync();
            Staff = await _context.Staff.ToListAsync();
            Brigade = await _context.Brigade.ToListAsync();
            TypeOfJob = await _context.TypeOfJob.ToListAsync();
            Customer = await _context.Customer.ToListAsync();

            return Page();
        }
    }
}
