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
                        Torque = "113.50 Nm @ 11600 RPM",
                        EngineCC = 998,
                        TopSpeed = 299,
                        DateOfLaunch = DateTime.Parse("2021-08-23"),
                    },
                    new Bike
                    {
                        ModelName = "Hayabusa",
                        CompanyName = "Suzuki",
                        BikeType = "Super Sport",
                        Torque = "155.00 Nm @ 7200 RPM",
                        EngineCC = 1400,
                        TopSpeed = 310,
                        DateOfLaunch = DateTime.Parse("2021-01-21"),
                    },
                    new Bike
                    {
                        ModelName = "Classic 350",
                        CompanyName = "Royal Enfield",
                        BikeType = "Tourer",
                        Torque = "27 Nm @ 4000 rpm",
                        EngineCC = 349,
                        TopSpeed = 120,
                        DateOfLaunch = DateTime.Parse("1909-06-03"),
                    },
                    new Bike
                    {
                        ModelName = "Ninja 400",
                        CompanyName = "Kawasaki",
                        BikeType = "Sport-Tourer",
                        Torque = "38.00 Nm @ 8000 RPM",
                        EngineCC = 399,
                        TopSpeed = 185,
                        DateOfLaunch = DateTime.Parse("2008-07-13"),
                    },
                    new Bike
                    {
                        ModelName = "R1M",
                        CompanyName = "Yamaha",
                        BikeType = "Hyper Sport",
                        Torque = "113.30 Nm @ 11500 RPM",
                        EngineCC = 999,
                        TopSpeed = 318,
                        DateOfLaunch = DateTime.Parse("2020-09-25"),
                    }
                );

                context.SaveChanges();
            }
        }
    }
}