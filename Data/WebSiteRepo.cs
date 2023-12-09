using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWMGApp.Models;


namespace TheboisGaming.Data
{
    public class WebSiteRepo : IWebsiteRepo
    {
        public List<Company> GetCompany()
        {
            throw new NotImplementedException();
        }

        public Company GetCompany(int id)
        {
            throw new NotImplementedException();
        }

        public List<Help> GetEvents()
        {
            throw new NotImplementedException();
        }

        public Help GetHelp(int id)
        {
            throw new NotImplementedException();
        }

        public List<Industry> GetIndustry()
        {
            throw new NotImplementedException();
        }

        public Industry GetIndustry(int id)
        {
            throw new NotImplementedException();
        }

        public Job GetJob(int id)
        {
            throw new NotImplementedException();
        }

        public List<Job> GetJobs()
        {
            throw new NotImplementedException();
        }

        public Newsletter GetNewsletter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Newsletter> GetNewsletters()
        {
            throw new NotImplementedException();
        }

        public int StoreCompany(Company company)
        {
            throw new NotImplementedException();
        }

        public int StoreHelp(Help e)
        {
            throw new NotImplementedException();
        }

        public int StoreIndustry(Industry i)
        {
            throw new NotImplementedException();
        }

        public int StoreJobs(int id)
        {
            throw new NotImplementedException();
        }

        public int StoreNewsletter(Newsletter i)
        {
            throw new NotImplementedException();
        }
    }
}
