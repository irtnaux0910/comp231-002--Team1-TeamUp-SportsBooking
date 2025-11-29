using System.ComponentModel.DataAnnotations;

namespace comp231_002__Team1_TeamUp_SportsBooking.Models
{
    public class CreateBookingRequest
    {
        [Required]
        public int CourtId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Range(1, 100)]
        public int PlayersCount { get; set; }
    }
}
