using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructWedDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ConstructWedDb.Pages.FilReq.Request
{
    public class LiOrModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;

        public LiOrModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }
        public IList<Order> Order { get; set; }
        public IList<TypeOfJob> TypeOfJob { get; set; }
        public IList<Brigade> Brigade { get; set; }
        public IList<Staff> Staff { get; set; }


        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
            TypeOfJob = await _context.TypeOfJob.ToListAsync();
            Brigade = await _context.Brigade.ToListAsync();
            Staff = await _context.Staff.ToListAsync();

        }
    }
}
