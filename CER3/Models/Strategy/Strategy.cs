using CER3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Strategy
{
    internal class Strategy : IDiagramPattern
    {
        public string Name { get; }
        public string Description { get; }
        public Strategy(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public override string ToString()
        { 
            return Name + " " + Description;
        }
        public static void Test(ConsoleView console)
        {
            IStrategy testStrategy = new Strategy1("Strategy1", "this is a Test");
            console.ConsoleWrite(testStrategy.ToString());
            testStrategy = new Strategy2("Strategy2", "this is another Test");
            console.ConsoleWrite(testStrategy.ToString());
        }
    }
}
