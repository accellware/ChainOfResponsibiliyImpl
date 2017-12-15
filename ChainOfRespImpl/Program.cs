using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfRespImpl.Config;
using ChainOfRespImpl.Handlers;
using ChainOfRespImpl.Handlers.Company;
using Unity;

namespace ChainOfRespImpl
{
    class Program
    {
        private static ConsoleHandler _handler;
        private static IUnityContainer _unityContainer;

        static void Main(string[] args)
        {
            Init();
            
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
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unknown error: {ex.Message}");
                }
                finally
                {
                    actionId = -1;
                }
                
            } while (actionId != 0);
        }

        private static void Init()
        {
            _unityContainer = UnityConfig.CreateContainer();

            RegisterHandlers();
            RegisterMappings();
        }

        private static void RegisterMappings()
        {
            AutomapperConfig.ConfigMapper();
        }

        private static void RegisterHandlers()
        {
            _handler = new CompanyAddHandler(_unityContainer);
            _handler.Add(new CompanyEditHandler(_unityContainer));
            _handler.Add(new CompanyListingHandler(_unityContainer));
            _handler.Add(new CompanySearchHandler(_unityContainer));
            _handler.Add(new CompanyDeleteHandler(_unityContainer));
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
