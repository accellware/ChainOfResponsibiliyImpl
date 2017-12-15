using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfRespImpl.DTO.Company;

namespace ChainOfRespImpl.Services
{
    public interface ICompanyService
    {
        void Add(CompanyAddDto dto);
        List<CompanyListingDto> GetCompanyList();
    }
}
