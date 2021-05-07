using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConstructWedDb.Data;
using ConstructWedDb.Models;

namespace ConstructWedDb.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;

        public IndexModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff
                .Include(s => s.Position).ToListAsync();
        }
    }
}
