using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfRespImpl.Config;
using ChainOfRespImpl.Handlers;
using ChainOfRespImpl.Handlers.Company;

namespace ChainOfRespImpl
{
    class Program
    {
        private static ConsoleHandler _handler;
        static void Main(string[] args)
        {
            RegisterHandlers();
            RegisterMappings();

            int actionId = 0;
            do
            {
                ShowMainMenu();
                try
                {
                    actionId = Int32.Parse(Console.ReadLine());
                    if(actionId == 0)
                    {
                        break;
                    }
                    
                    _handler.Execute(actionId);
                }
                catch(InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }catch(Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
                finally
                {
                    actionId = -1;
                }
                
            } while (actionId != 0);
        }

        private static void RegisterMappings()
        {
            AutomapperConfig.ConfigMapper();
        }

        private static void RegisterHandlers()
        {
            _handler = new CompanyAddHandler();
            _handler.Add(new CompanyEditHandler());
            _handler.Add(new CompanyListingHandler());
            _handler.Add(new CompanySearchHandler());
            _handler.Add(new CompanyDeleteHandler());
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine("Please select an option: ");

            var handler = _handler;
            do
            {
                Console.WriteLine(handler.GetAction());
            } while ((handler = handler.GetParent()) != null);
        }
    }
}
