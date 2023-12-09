using Microsoft.AspNetCore.Mvc;

namespace SWMGApp.Controllers
{
    public class JobsController : Controller
    {
        public IActionResult Jobs()
        {
            return View();
        }
    }
}
