using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventEase.Models;

namespace EventEase.Models
{
    public class Venue
    {
        public int VenueId { get; set; }

        [Display(Name = "Venue Name")]
        public string VenueName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }

        [Display(Name = "Image Link")]
        public string ImageUrl { get; set; }

        // connection to hte booking table 
        public ICollection<Booking> Bookings { get; set; } // Navigation property for Bookings
    }
}
