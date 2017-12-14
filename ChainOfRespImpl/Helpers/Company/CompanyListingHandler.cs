using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespImpl.Helpers.Company
{
    public class CompanyListingHandler : ConsoleHandler
    {
        public override void Execute(int actionId)
        {
            if (!CanExecute(actionId))
            {
                base.Execute(actionId);
                return;
            }

            Console.WriteLine("CompanyListingHandler not yet implemented.");
        }

        public override string GetAction()
        {
            return $"{_id}. List a company.";
        }
    }
}
