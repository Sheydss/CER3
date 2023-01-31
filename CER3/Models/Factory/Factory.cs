using CER3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Factory
{
    internal class Factory : IDiagramPattern
    {
        public string Name { get; }
        public string Description { get; }

        public Factory(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

        public IObject CreateObject(string Name, string Description, int type)
        {
            switch(type)
            {
                case 1:
                    return new Object1(Name, Description); 
                case 2:
                    return new Object2(Name, Description);
                default:
                    throw new ArgumentException("Arguments invalid");
            }
        }

        public override string ToString()
        {
            return Name + " " + Description;
        }

        public static void Test(ConsoleView console)
        {
            var testFactory = new Factory("Factory", "this is a Test");
            console.ConsoleWrite(testFactory.ToString());
            var obj1 = testFactory.CreateObject("obj1", "test1", 1);
            console.ConsoleWrite(obj1.ToString());
            var obj2 = testFactory.CreateObject("obj2", "test2", 2);
            console.ConsoleWrite(obj2.ToString());
        }

    }
}
