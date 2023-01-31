using CER3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models
{
    internal interface IDiagramPattern
    {
        public string Name { get; }
        public string Description { get; }

        public string ToString();

        public static void Test(ConsoleView console) 
        { 
            console.ConsoleWrite("default static method");
        }
    }
}
