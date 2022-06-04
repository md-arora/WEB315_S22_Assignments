using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesBike.Models;

    public class RazorPagesBikeContext : DbContext
    {
        public RazorPagesBikeContext (DbContextOptions<RazorPagesBikeContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesBike.Models.Bike> Bike { get; set; }
    }
