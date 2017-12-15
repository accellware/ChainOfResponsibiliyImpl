using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ChainOfRespImpl.Handlers.Company
{
    public class CompanyDeleteHandler : ConsoleHandler
    {
        public CompanyDeleteHandler(IUnityContainer unityContainer)
            : base(unityContainer)
        {

        }

        public override void Execute(int actionId)
        {
            if(!CanExecute(actionId))
            {
                base.Execute(actionId);
                return;
            }

            Console.WriteLine("CompanyDeleteHandler not yet implemented!");
        }

        public override string GetAction()
        {
            return $"{_id}. Delete a company.";
        }
    }
}
