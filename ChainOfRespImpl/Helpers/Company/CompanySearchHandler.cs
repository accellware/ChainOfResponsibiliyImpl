using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespImpl.Helpers.Company
{
    public class CompanySearchHandler : ConsoleHandler
    {
        public override void Execute(int actionId)
        {
            if (!CanExecute(actionId))
            {
                base.Execute(actionId);
                return;
            }

            Console.WriteLine("CompanySearchHandler not yet implemented.");
        }

        public override string GetAction()
        {
            return $"{_id}. Search a company.";
        }
    }
}
