using CER3.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Views
{
    internal class ConsoleView
    {

        public ConsoleView() { }

        public int GetInput(string text, int maxCycle)
        {
            var error = true;
            var i = 0;
            Console.WriteLine(text);
            while (error && i < maxCycle)
            {
                error = false;
                var input = Console.ReadLine();
                var inputInt = 0;
                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out inputInt))
                {
                    return inputInt;
                }
                else
                {
                    error = true;
                }
                i++;
            }
            throw new MaxCycleException("Input Invalid");
            
        }

        public void ConsoleWrite(string text)
        {
            Console.WriteLine(text);
        }

    }
}
