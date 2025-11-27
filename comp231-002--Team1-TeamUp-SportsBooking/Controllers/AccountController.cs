using Microsoft.AspNetCore.Mvc;
using comp231_002__Team1_TeamUp_SportsBooking.Models;

namespace comp231_002__Team1_TeamUp_SportsBooking.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            // Pass an empty model to the view
            var model = new LoginViewModel();
            return View(model);
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // 1) Check model validation (Email + Password required)
            if (!ModelState.IsValid)
            {
                // Stay on the same page and show validation errors
                return View(model);
            }

            // 2) TEMPORARY: simple hard-coded login check
            //    TODO: Replace this with real database/user lookup
            var isValidUser =
                model.Email == "test@example.com" &&
                model.Password == "Password123";

            if (!isValidUser)
            {
                // Wrong email or password => do NOT log in
                ModelState.AddModelError(string.Empty, "Invalid email or password.");
                return View(model);
            }

            // 3) If valid, redirect to home (or dashboard)
            // Later we can add real authentication/cookie sign-in here
            return RedirectToAction("Index", "Home");
        }

        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            var model = new RegisterViewModel();
            return View(model);
        }

        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            // 1) Validate the form (FirstName, LastName, Email, Password, etc.)
            if (!ModelState.IsValid)
            {
                // Show validation messages in the view
                return View(model);
            }

            // 2) TODO: Save the user to the database here
            //    For now we don't actually create a user in storage.
            //    Your backend team can plug in EF Core or another persistence layer.

            // 3) After successful registration, go to Login page
            return RedirectToAction("Login");
        }
    }
}
