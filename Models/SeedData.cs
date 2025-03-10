using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EventEase.Data;
using System;
using System.Linq;

namespace EventEase.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new EventEaseContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<EventEaseContext>>()))
        {
            // Look for any venues.
            if (context.Venue.Any())
            {
                return;   // DB has been seeded
            }

            context.Venue.AddRange(
                new Venue
                {
                    VenueName = "Grand Ballroom",
                    Location = "Downtown City Center",
                    Capacity = 500,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2vDK9iRgnePgj-YQV1RtlXH1ksZx74LfB8w&s"
                },
                new Venue
                {
                    VenueName = "Oceanview Terrace",
                    Location = "Beachside Avenue",
                    Capacity = 200,
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/326678219.jpg?k=bb19f632ee19cbf58f70959e135d746bb1f96e6374ac3420c4c588f7a3b1b9d1&o=&hp=1"
                },
                new Venue
                {
                    VenueName = "Mountain Lodge",
                    Location = "Hillside Drive",
                    Capacity = 150,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ4oLfP8vHEdY1tkgyj8Y-Bsw7i-GsWdkYybQ&s"
                },
                new Venue
                {
                    VenueName = "City Park Pavilion",
                    Location = "Central Park",
                    Capacity = 300,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQu-EqRkr-rYb_IsZJV5X6BTt8Tg_X8d6Uqzg&s"
                }
            );

            context.SaveChanges();
        }
    }
}
