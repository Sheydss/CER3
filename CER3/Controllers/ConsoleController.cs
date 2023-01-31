using CER3.Models;
using CER3.Models.Bridge;
using CER3.Models.Factory;
using CER3.Models.Observer;
using CER3.Models.Strategy;
using CER3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Controllers
{
    internal class ConsoleController
    {
        ConsoleView _consoleView = new ConsoleView();
        public ConsoleController(int max) 
        {
            var i = 0;
            while (i < max)
            {
                try
                {
                    var input = _consoleView.GetInput("\nChose the diagram pattern or exit the application\n0 - Exit\n1 - Singleton\n2 - Strategy\n3 - Observer\n4 - Factory\n5 - Bridge\n", 100);
                    if (input.GetType() == typeof(int) && input >= 0 && input <= 5)
                    {
                        switch (input)
                        {
                            case 0:
                                Environment.Exit(0);
                                break;
                            case 1:
                                Singleton.Test(_consoleView);
                                break;
                            case 2:
                                Strategy.Test(_consoleView);
                                break;
                            case 3:
                                Observer.Test(_consoleView);
                                break;
                            case 4:
                                Factory.Test(_consoleView);
                                break;
                            case 5:
                                Bridge.Test(_consoleView);
                                break;
                            default:
                                throw new Exception("Input invalid");
                        }
                    }
                    else
                    {
                        throw new Exception("Input invalid");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Datetime: \n" + DateTime.Now.ToString() + "Message: \n " + ex.Message + "StackTrace: \n " + ex.StackTrace);
                }
            }
            Console.WriteLine("Max reached");
            Environment.Exit(0);
        }
    }
}
