using Microsoft.AspNetCore.Mvc;

namespace comp231_002__Team1_TeamUp_SportsBooking.Controllers
{
    public class GamesController : Controller
    {
        // /Games/Details/1
        public IActionResult Details(int id)
        {
            // then we'll substitute the real data from the database here
            return View();
        }
    }
}
