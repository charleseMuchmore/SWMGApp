using SWMGApp.Data;
using SWMGApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SWMGApp.Controllers
{
    public class HomeController : Controller
    {
        IWebsiteRepo repo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IWebsiteRepo r)
        {
            _logger = logger;
            repo = r;
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

        [HttpPost]
        public IActionResult Index(string email)
        {
            Newsletter model = new Newsletter();
            model.Email = email;
            repo.StoreNewsletter(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Newsletter(string email)
        {
            Newsletter model = new Newsletter();
            model.Email = email;
            repo.StoreNewsletter(model);
            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Help(string name, string email, string msg)
        {
            Help h = new Help();
            h.Name = name;
            h.Email = email;
            h.Msg = msg; 
            h.Datetime = "123"; //this needs actually implemented to get the real datetime
            repo.StoreHelp(h);
            return View();
        }


   /*     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}