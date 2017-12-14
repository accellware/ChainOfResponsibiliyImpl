using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfRespImpl.DTO.Company;
using ChainOfRespImpl.Models;
using ChainOfRespImpl.Repositories;

namespace ChainOfRespImpl.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepo;

        public CompanyService(ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }

        public void Add(CompanyAddDto dto)
        {
            var company = AutoMapper.Mapper.Map<Company>(dto);
            _companyRepo.Add(company);
        }
    }
}
