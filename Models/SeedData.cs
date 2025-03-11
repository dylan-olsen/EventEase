using EventEase.Data;
using EventEase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace EventEase.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EventEaseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EventEaseContext>>()))
            {
                // Seed Venues
                if (!context.Venue.Any())
                {
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

                // Seed Events
                if (!context.Event.Any())
                {
                    context.Event.AddRange(
                        new Event
                        {
                            EventName = "Summer Concert",
                            EventDate = new DateTime(2025, 6, 15),
                            Description = "An unforgettable evening of live music at the Grand Ballroom."
                        },
                        new Event
                        {
                            EventName = "Beachside Music Festival",
                            EventDate = new DateTime(2025, 7, 20),
                            Description = "Join us for a weekend of music and fun at Oceanview Terrace."
                        },
                        new Event
                        {
                            EventName = "Mountain Adventure Hike",
                            EventDate = new DateTime(2025, 5, 10),
                            Description = "Experience the beauty of the mountains with a guided hike."
                        },
                        new Event
                        {
                            EventName = "City Park Annual Picnic",
                            EventDate = new DateTime(2025, 8, 5),
                            Description = "A fun-filled day with food, games, and live entertainment at City Park Pavilion."
                        }
                    );
                    context.SaveChanges();
                }

                // Seed Bookings (bridging Event and Venue)
                if (!context.Booking.Any())
                {
                    context.Booking.AddRange(
                        new Booking
                        {
                            EventId = context.Event.First(e => e.EventName == "Summer Concert").EventId,
                            VenueId = context.Venue.First(v => v.VenueName == "Grand Ballroom").VenueId,
                            BookingDate = new DateTime(2025, 6, 15)
                        },
                        new Booking
                        {
                            EventId = context.Event.First(e => e.EventName == "Beachside Music Festival").EventId,
                            VenueId = context.Venue.First(v => v.VenueName == "Oceanview Terrace").VenueId,
                            BookingDate = new DateTime(2025, 7, 20)
                        },
                        new Booking
                        {
                            EventId = context.Event.First(e => e.EventName == "Mountain Adventure Hike").EventId,
                            VenueId = context.Venue.First(v => v.VenueName == "Mountain Lodge").VenueId,
                            BookingDate = new DateTime(2025, 5, 10)
                        },
                        new Booking
                        {
                            EventId = context.Event.First(e => e.EventName == "City Park Annual Picnic").EventId,
                            VenueId = context.Venue.First(v => v.VenueName == "City Park Pavilion").VenueId,
                            BookingDate = new DateTime(2025, 8, 5)
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
