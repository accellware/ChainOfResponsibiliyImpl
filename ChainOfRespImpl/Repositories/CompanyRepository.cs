using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfRespImpl.Models;

namespace ChainOfRespImpl.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CompanyRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Company company)
        {
            _dbContext.Companies.Add(company);

            _dbContext.SaveChanges();
        }

        public List<Company> GetCompanyList()
        {
            return _dbContext.Companies.ToList();
        }
    }
}
