using Microsoft.AspNetCore.Mvc;

namespace comp231_002__Team1_TeamUp_SportsBooking.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
