using Microsoft.AspNetCore.Mvc;

namespace comp231_002__Team1_TeamUp_SportsBooking.Controllers
{
    public class TeamOwnerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Stubs for future action games
        public IActionResult CreateMatch() => View();
        public IActionResult ManageRoster() => View();
    }
}
