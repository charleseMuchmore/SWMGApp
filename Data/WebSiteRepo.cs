using SWMGApp.Models;
using Microsoft.EntityFrameworkCore;


namespace SWMGApp.Data
{
    public class WebSiteRepo : IWebsiteRepo
    {
        private AppDbContext dbContext;

        public WebSiteRepo(AppDbContext context)
        {
            dbContext = context;
        }
        public List<Company> GetCompany()
        {
            return dbContext.Companies.ToList();
        }

        public Company GetCompany(int id)
        {
            return dbContext.Companies.Find(id);
        }

        public List<Help> GetEvents()
        {
            return dbContext.Help.ToList();
        }

        public Help GetHelp(int id)
        {
            return dbContext.Help.Find(id);
        }

        public List<Industry> GetIndustry()
        {
            return dbContext.Industries.ToList();
        }

        public Industry GetIndustry(int id)
        {
            return dbContext.Industries.Find(id);
        }

        public Job GetJob(int id)
        {
            return dbContext.Jobs.Find(id);
        }

        public List<Job> GetJobs()
        {
            return dbContext.Jobs.Include(m => m.Industry).ToList();


        }

        public Newsletter GetNewsletter(int id)
        {
            return dbContext.Newsletters.Find(id);
        }

        public List<Newsletter> GetNewsletters()
        {
            return dbContext.Newsletters.ToList();
        }

        public int StoreCompany(Company company)
        {
            dbContext.Companies.Add(company);
            return dbContext.SaveChanges();
        }

        public int StoreHelp(Help e)
        {
            dbContext.Help.Add(e);
            return dbContext.SaveChanges();
        }

        public int StoreIndustry(Industry i)
        {
            dbContext.Industries.Add(i);
            return dbContext.SaveChanges();
        }

        public int StoreJobs(Job j) 
        {
            dbContext.Jobs.Add(j);
            return dbContext.SaveChanges();
        }

        public int StoreJobs(int id)
        {
            Job j = dbContext.Jobs.Find(id);
            dbContext.Jobs.Add(j);
            return dbContext.SaveChanges();
        }

        public int StoreNewsletter(Newsletter i)
        {
            dbContext.Newsletters.Add(i);
            return dbContext.SaveChanges();
        }
    }
}
