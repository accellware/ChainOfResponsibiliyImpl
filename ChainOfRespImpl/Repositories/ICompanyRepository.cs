using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfRespImpl.Models;

namespace ChainOfRespImpl.Repositories
{
    public interface ICompanyRepository
    {
        void Add(Company company);
        List<Company> GetCompanyList();
    }
}
