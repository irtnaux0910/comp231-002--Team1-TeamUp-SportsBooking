using Microsoft.AspNetCore.Mvc;

namespace comp231_002__Team1_TeamUp_SportsBooking.Controllers
{
    public class TeamsController : Controller
    {
        // /Teams/Details/1
        public IActionResult Details(int id)
        {
            // later you will take the team data from the database by id
            return View();
        }
    }
}
