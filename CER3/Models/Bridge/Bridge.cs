using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Bridge
{
    internal class Bridge : IDiagramPattern
    {
        public string Name { get; }
        public string Description { get; }

        public Bridge(string name, string description)
        {
            Name = name;
            Description = description; 
        }
        public override string ToString()
        {
            return Name + " " + Description;
        }
        public static void Test(Views.ConsoleView _consoleView)
        {
            var subObject1 = new SubObject1("sobj1");
            var subObject2 = new SubObject2("sobj2");
            var Object1 = new Object1("obj1", subObject1);
            var Object2 = new Object2("obj2", subObject2);
            Console.WriteLine(Object1);
            Console.WriteLine(Object2);
        }
    }
}
