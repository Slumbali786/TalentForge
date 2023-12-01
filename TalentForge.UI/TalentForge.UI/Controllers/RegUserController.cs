using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TalentForge.UI.Models;

namespace TalentForge.UI.Controllers
{
    public class RegUserController : Controller
    {
        private readonly ILogger<RegUserController> _logger;

        public RegUserController(ILogger<RegUserController> logger)
        {
            _logger = logger;
        }

        public IActionResult RUHome()
        {
            return View();
        }

        public IActionResult RUCreateCVs()
        {
            return View();
        }

        public IActionResult RUMyAccount()
        {
            return View();
        }

        public IActionResult RUViewJobs()
        {
            return View();
        }

        public IActionResult RUMyCVs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
