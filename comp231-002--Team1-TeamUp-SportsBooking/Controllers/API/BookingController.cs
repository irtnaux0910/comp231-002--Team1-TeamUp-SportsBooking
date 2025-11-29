using comp231_002__Team1_TeamUp_SportsBooking.Data;
using comp231_002__Team1_TeamUp_SportsBooking.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace comp231_002__Team1_TeamUp_SportsBooking.Controllers.Api
{
    [ApiController]
    // [Route("api/bookings")]
    [Route("api/bookings")]
    // [Authorize]   // add login to use
    public class BookingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public BookingsController(ApplicationDbContext context,
                                  UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // POST: api/bookings
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookingRequest request)
        {
            if (request.EndTime <= request.StartTime)
                return BadRequest("End time must be after start time.");

            var court = await _context.Courts.FindAsync(request.CourtId);
            if (court == null)
                return NotFound("Court not found.");

            bool overlap = await _context.Bookings
                .AnyAsync(b => b.CourtId == request.CourtId
                            && b.Status == "Confirmed"
                            && request.StartTime < b.EndTime
                            && request.EndTime > b.StartTime);

            if (overlap)
                return Conflict("This court is already booked in that time range.");

            var userId = _userManager.GetUserId(User);

            var booking = new Booking
            {
                CourtId = request.CourtId,
                StartTime = request.StartTime,
                EndTime = request.EndTime,
                PlayersCount = request.PlayersCount,
                Status = "Confirmed",
                UserId = userId!
            };

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return Ok(booking.Id);
        }

        // GET: api/bookings/my
        [HttpGet("my")]
        public async Task<IActionResult> GetMyBookings()
        {
            var userId = _userManager.GetUserId(User);

            var bookings = await _context.Bookings
                .Where(b => b.UserId == userId)
                .OrderByDescending(b => b.StartTime)
                .ToListAsync();

            return Ok(bookings);
        }

        // DELETE: api/bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Cancel(int id)
        {
            var userId = _userManager.GetUserId(User);

            var booking = await _context.Bookings
                .FirstOrDefaultAsync(b => b.Id == id && b.UserId == userId);

            if (booking == null)
                return NotFound();

            booking.Status = "Cancelled";
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
