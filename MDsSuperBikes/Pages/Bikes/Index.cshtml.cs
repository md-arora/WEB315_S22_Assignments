using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesBike.Models;

namespace MDsSuperBikes.Pages_Bikes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBikeContext _context;

        public IndexModel(RazorPagesBikeContext context)
        {
            _context = context;
        }

        public IList<Bike> Bike { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList CompanyName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BikeCompanyName { get; set; }

        public async Task OnGetAsync()
        {
            var bikes = from b in _context.Bike
                 select b;
            if (!string.IsNullOrEmpty(SearchString))
            {
                bikes = bikes.Where(s => s.ModelName.Contains(SearchString));
            }

            Bike = await bikes.ToListAsync();
        }
    }
}
