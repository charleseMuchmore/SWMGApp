using Microsoft.AspNetCore.Mvc;
using SWMGApp.Models;

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
        [HttpPost]
        public IActionResult Newsletter(string industyType)
        {

            return RedirectToAction("Index");
        }
    }
}
