using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfRespImpl.DTO.Company;

namespace ChainOfRespImpl.Helpers.Company
{
    public class CompanyAddHandler : ConsoleHandler
    {
        public override void Execute(int actionId)
        {
            if (!CanExecute(actionId))
            {
                base.Execute(actionId);
                return;
            }

            Console.WriteLine("Enter a name: ");
            var dto = new CompanyAddDto();
            dto.Name = Console.ReadLine();
        }

        public override string GetAction()
        {
            return $"{_id}. Add a company.";
        }
    }
}
