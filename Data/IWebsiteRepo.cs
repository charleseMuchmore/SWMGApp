using Microsoft.AspNetCore.Mvc;
using SWMGApp.Models;

namespace TheboisGaming.Data
{
    public interface IWebsiteRepo
    {
        public List<Company> GetCompany();
        public Company GetCompany(int id);
        public int StoreCompany(Company company);


        public List<Help> GetEvents();
        public Help GetHelp(int id);
        public int StoreHelp(Help e);

        public List<Industry> GetIndustry();
        public Industry GetIndustry(int id);
        public int StoreIndustry(Industry i);

        public List<Job> GetJobs();
        public Job GetJob(int id);
        public int StoreJobs(int id);


        public List<Newsletter> GetNewsletters();
        public Newsletter GetNewsletter(int id);
        public int StoreNewsletter(Newsletter i);
         
    }
}
