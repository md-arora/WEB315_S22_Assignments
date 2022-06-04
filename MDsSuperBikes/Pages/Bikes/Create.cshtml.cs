using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesBike.Models;

namespace MDsSuperBikes.Pages_Bikes
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesBikeContext _context;

        public CreateModel(RazorPagesBikeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Bike Bike { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bike.Add(Bike);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
