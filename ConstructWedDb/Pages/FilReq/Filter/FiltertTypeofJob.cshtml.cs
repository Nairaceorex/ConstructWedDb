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
    public class FiltertTypeofJobModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;
        public FiltertTypeofJobModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }
        public IList<Material> Material { get; set; }
        public IList<TypeOfJob> TypeOfJob { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypeOfJob = await _context.TypeOfJob.Where(m => m.ID == id).ToListAsync();

            if (TypeOfJob == null)
            {
                return NotFound();
            }
            Material = await _context.Material.ToListAsync();

            return Page();
        }
    }
}
