using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConstructWedDb.Data;
using ConstructWedDb.Models;

namespace ConstructWedDb.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly ConstructWedDb.Data.ConstructWedDbContext _context;

        public CreateModel(ConstructWedDb.Data.ConstructWedDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BrigadeID"] = new SelectList(_context.Brigade, "ID", "ID");
        ViewData["CustomerID"] = new SelectList(_context.Customer, "ID", "FullName");
        ViewData["StaffID"] = new SelectList(_context.Staff, "ID", "FullName");
        ViewData["TypeOfJobID"] = new SelectList(_context.TypeOfJob, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Order.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
