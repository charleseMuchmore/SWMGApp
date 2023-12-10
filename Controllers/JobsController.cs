using Microsoft.AspNetCore.Mvc;
using SWMGApp.Data;
using SWMGApp.Models;


namespace SWMGApp.Controllers
{
    public class JobsController : Controller
    {
        public IWebsiteRepo repo;
        public JobsController( IWebsiteRepo r)
        {
            repo = r;
        }
        public IActionResult Index()
        {
            var model = repo.GetJobs();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string job, string industry)
        {
            List<Job> jobs = repo.GetJobs();
            List<Job> sortedJobs = new List<Job>();
            if (job != null && industry != null) 
            {
                sortedJobs = (from n in repo.GetJobs()
                              where n.JobName == job &&
                              n.Industry.Name == industry
                              select n).ToList();
            }
            else if (job != null && industry == null)
            {
                sortedJobs = (from n in repo.GetJobs()
                              where n.JobName == job
                              select n).ToList();
            }
            else if (job == null && industry != null)
            {
                sortedJobs = (from n in repo.GetJobs()
                              where n.Industry.Name == industry
                              select n).ToList();
            }

            return View(sortedJobs);
        }

    }
}
