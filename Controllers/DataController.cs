using Microsoft.AspNetCore.Mvc;

namespace SWMGApp.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Industry()
        {
            return View();
        }
    }
}
