using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TalentForge.UI.Models;

namespace TalentForge.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CreateAccounts()
        {
            return View();
        }

        public IActionResult CreateRegAccount()
        {
            return View();
        }

        public IActionResult CreateCompAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            // Here you would typically validate the username and password
            // and perform authentication logic (e.g., check against a database)
            // For the sake of this example, I'll assume a simple check

            if (Username == "example" && Password == "password")
            {
                // Successful login
                return RedirectToAction("RUHome", "RegUser");
            }
            else
            {
                // Failed login
                ViewData["ErrorMessage"] = "Invalid username or password";
                return View("Login");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}