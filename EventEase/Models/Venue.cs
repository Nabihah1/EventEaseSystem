using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Venue
    {
        [Key]

        public int VenueID { get; set; }
        public int VenueName { get; set; }
        public int Location { get; set; }
        public int Capacity { get; set; }
        public int ImageUrl { get; set; }
    }
}
