using Microsoft.AspNetCore.Mvc;
using SWMGApp.Data;
using SWMGApp.Models;

namespace SWMGApp.Controllers
{
    public class DataController : Controller
    {
        public IWebsiteRepo repo;
        public DataController(IWebsiteRepo r)
        {
            repo = r;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Industry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string industryType)
        {
            var loadedModel = new Industry();
            if (industryType == "Bio Science")
            {
                loadedModel = repo.GetIndustry(1);
            }
            
            else if(industryType == "Nutrition")
            {
                loadedModel = repo.GetIndustry(2);
            }
            else if(industryType == "Technology")
            {
                loadedModel = repo.GetIndustry(3);
            }
            else if (industryType == "Wood Working")
            {
                loadedModel = repo.GetIndustry(4);
            }
            else if (industryType == "Healthcare")
            {
                loadedModel = repo.GetIndustry(5);
            }
            else if (industryType == "Sports")
            {
                loadedModel = repo.GetIndustry(6);
            }


            return RedirectToAction("Industry", loadedModel); 
        }
    }
}
