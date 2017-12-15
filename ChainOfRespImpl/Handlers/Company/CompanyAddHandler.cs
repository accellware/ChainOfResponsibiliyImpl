using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfRespImpl.DTO.Company;
using Unity;
using ChainOfRespImpl.Services;

namespace ChainOfRespImpl.Handlers.Company
{
    public class CompanyAddHandler : ConsoleHandler
    {

        public CompanyAddHandler(IUnityContainer container)
            : base(container)
        {

        }

        public override void Execute(int actionId)
        {
            if (!CanExecute(actionId))
            {
                base.Execute(actionId);
                return;
            }

            var companyService = _container.Resolve<ICompanyService>();

            Console.WriteLine("Enter a name: ");
            var dto = new CompanyAddDto();
            dto.Name = Console.ReadLine();
            companyService.Add(dto);
            Console.WriteLine(".: Company successfully added! :.");
        }

        public override string GetAction()
        {
            return $"{_id}. Add a company.";
        }
    }
}
