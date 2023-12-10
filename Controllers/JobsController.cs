using Microsoft.AspNetCore.Mvc;
using SWMGApp.Data;

namespace SWMGApp.Controllers
{
    public class JobsController : Controller
    {


        IWebsiteRepo repo;


        public JobsController( IWebsiteRepo r)
        {
      
            repo = r;
        }
        public IActionResult Index()
        {
            var model = repo.GetJobs();
            return View(model);
        }
    }
}
