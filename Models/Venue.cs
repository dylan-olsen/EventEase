﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventEase.Models;

namespace EventEase.Models
{
    public class Venue
    {
        public int VenueId { get; set; }

        [Display(Name = "Venue Name")]
        [DataType(DataType.Date)]
        public string VenueName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }

        [Display(Name = "Image Link")]
        [DataType(DataType.Date)]
        public string ImageUrl { get; set; }

        public ICollection<Event> Events { get; set; } // Navigation property

    }
}
