using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
// using RazorPagesBike.Data;
using System;
using System.Linq;

namespace RazorPagesBike.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesBikeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesBikeContext>>()))
            {
                // Look for any Bike.
                if (context.Bike.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bike.AddRange(
                    new Bike
                    {
                        ModelName = "Ninja ZX10R",
                        CompanyName = "Kawasaki",
                        BikeType = "Super Sport",
                        EngineCC = 998,
                        DateOfLaunch = DateTime.Parse("2021-08-23"),
                    },
                    new Bike
                    {
                        ModelName = "Hayabusa",
                        CompanyName = "Suzuki",
                        BikeType = "Super Sport",
                        EngineCC = 1400,
                        DateOfLaunch = DateTime.Parse("2021-01-21"),
                    },
                    new Bike
                    {
                        ModelName = "Classic 350",
                        CompanyName = "Royal Enfield",
                        BikeType = "Tourer",
                        EngineCC = 349,
                        DateOfLaunch = DateTime.Parse("1909-06-03"),
                    },
                    new Bike
                    {
                        ModelName = "Ninja 400",
                        CompanyName = "Kawasaki",
                        BikeType = "Sport-Tourer",
                        EngineCC = 399,
                        DateOfLaunch = DateTime.Parse("2008-07-13"),
                    },
                    new Bike
                    {
                        ModelName = "R1M",
                        CompanyName = "Yamaha",
                        BikeType = "Hyper Sport",
                        EngineCC = 999,
                        DateOfLaunch = DateTime.Parse("2020-09-25"),
                    }
                );

                context.SaveChanges();
            }
        }
    }
}