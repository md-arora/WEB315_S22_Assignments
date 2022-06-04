using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public async Task OnGetAsync()
        {
            Bike = await _context.Bike.ToListAsync();
        }
    }
}
