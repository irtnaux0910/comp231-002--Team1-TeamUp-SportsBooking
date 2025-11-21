using Microsoft.AspNetCore.Mvc;

namespace comp231_002__Team1_TeamUp_SportsBooking.Controllers
{
    public class CourtsController : Controller
    {
        public IActionResult Index()
        {
            // then you can insert data from the database here
            return View();
        }

        public IActionResult Book(int id)
        {
            // Later, the court data will be uploaded here by ID
            return View();
        }
    }
}
