using ChainOfRespImpl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ChainOfRespImpl.Handlers.Company
{
    public class CompanyListingHandler : ConsoleHandler
    {
        private readonly ICompanyService _companyService;

        public CompanyListingHandler(IUnityContainer container)
            : base(container)
        {
            _companyService = container.Resolve<ICompanyService>();
        }

        public override void Execute(int actionId)
        {
            if (!CanExecute(actionId))
            {
                base.Execute(actionId);
                return;
            }
            
            Console.WriteLine("Company listing: ");

            var companyList = _companyService.GetCompanyList();
            foreach(var company in companyList)
            {
                Console.Write($"| - {company.Id} - {company.Name}");
            }
        }

        public override string GetAction()
        {
            return $"{_id}. List a company.";
        }
    }
}
