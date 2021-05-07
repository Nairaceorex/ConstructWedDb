using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConstructWedDb.Data;
using ConstructWedDb.Models;

namespace ConstructWedDb.Pages.TypeOfJobs
{
    public class DetailsModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;

        public DetailsModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }

        public TypeOfJob TypeOfJob { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypeOfJob = await _context.TypeOfJob
                .Include(t => t.Material1)
                .Include(t => t.Material2)
                .Include(t => t.Material3).FirstOrDefaultAsync(m => m.ID == id);

            if (TypeOfJob == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
