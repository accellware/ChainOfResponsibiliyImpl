using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfRespImpl.DTO.Company;
using ChainOfRespImpl.Models;

namespace ChainOfRespImpl.Config
{
    static class AutomapperConfig
    {
        internal static void ConfigMapper()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CompanyAddDto, Company>();
                cfg.CreateMap<Company, CompanyListingDto>();
            });
        }
    }
}
