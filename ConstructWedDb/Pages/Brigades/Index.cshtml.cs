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
    public class IndexModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;

        public IndexModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }

        public IList<Brigade> Brigade { get;set; }

        public async Task OnGetAsync()
        {
            Brigade = await _context.Brigade
                .Include(b => b.Staff1)
                .Include(b => b.Staff2)
                .Include(b => b.Staff3).ToListAsync();
        }
    }
}
