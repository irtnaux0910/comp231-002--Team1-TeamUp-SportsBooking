namespace comp231_002__Team1_TeamUp_SportsBooking.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int CourtId { get; set; }
        public Court Court { get; set; } = null!;

        public string UserId { get; set; } = "";
        public ApplicationUser User { get; set; } = null!;

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int PlayersCount { get; set; }
        public string Status { get; set; } = "Confirmed";
    }
}
