using Microsoft.AspNetCore.Mvc;

namespace comp231_002__Team1_TeamUp_SportsBooking.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Stubs for future pages
        public IActionResult Users() => View();
        public IActionResult Courts() => View();

        public IActionResult EditCourt(int id)
        {
            return View();
        }
    }
}
