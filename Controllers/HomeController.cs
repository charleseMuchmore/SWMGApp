using Microsoft.AspNetCore.Mvc;
using SWMGApp.Models;
using System.Diagnostics;

namespace SWMGApp.Controllers
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

        public IActionResult SWMG()
        {
            return View();
        }

        public IActionResult NewsLetter()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Help()
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