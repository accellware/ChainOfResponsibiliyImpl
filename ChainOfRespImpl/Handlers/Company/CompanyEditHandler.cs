using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ChainOfRespImpl.Handlers.Company
{
    public class CompanyEditHandler : ConsoleHandler
    {
        public CompanyEditHandler(IUnityContainer unityContainer)
            : base(unityContainer)
        {

        }

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
