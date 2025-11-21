using Microsoft.AspNetCore.Mvc;

namespace comp231_002__Team1_TeamUp_SportsBooking.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Bookings()
        {
            return View();
        }

         // NEW PROFILE SCREEN
        public IActionResult Profile()
        {
            // later, insert the real data from the database here
            return View();
        }
    }
}
