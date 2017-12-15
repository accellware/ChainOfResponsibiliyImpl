using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ChainOfRespImpl.Handlers.Company
{
    public class CompanySearchHandler : ConsoleHandler
    {
        public CompanySearchHandler(IUnityContainer container) 
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

            Console.WriteLine("CompanySearchHandler not yet implemented.");
        }

        public override string GetAction()
        {
            return $"{_id}. Search a company.";
        }
    }
}
