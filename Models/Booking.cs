using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventEase.Models;

namespace EventEase.Models;
        public class Booking
        {
            public int BookingId { get; set; }

            // Foreign keys
            public int EventId { get; set; }
            public int VenueId { get; set; }

            // Additional fields
            public DateTime BookingDate { get; set; }

            // Navigation properties
            public Event Event { get; set; }
            public Venue Venue { get; set; }
        }

    


