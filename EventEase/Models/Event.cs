using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public int EventName { get; set; }
        public int EventDate { get; set; }
        public int Description { get; set; }
        public int VenueID { get; set; }

    }
}
