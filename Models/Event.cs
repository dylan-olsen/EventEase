using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventEase.Models;

namespace EventEase.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }

        // connection to bookings table 
        public ICollection<Booking> Bookings { get; set; } // Navigation property for Bookings
    }




}

