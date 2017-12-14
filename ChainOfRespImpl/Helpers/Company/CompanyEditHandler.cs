using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespImpl.Helpers.Company
{
    public class CompanyEditHandler : ConsoleHandler
    {
        public override void Execute(int actionId)
        {
            if (!CanExecute(actionId))
            {
                base.Execute(actionId);
                return;
            }

            Console.WriteLine("CompanyEditHandler not yet implemented.");
        }

        public override string GetAction()
        {
            return $"{_id}. Edit a company.";
        }
    }
}
