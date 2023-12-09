using Microsoft.AspNetCore.Mvc;

namespace SWMGApp.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Data()
        {
            return View();
        }
    }
}
