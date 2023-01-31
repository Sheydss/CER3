using CER3.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models
{
    internal class Singleton : IDiagramPattern
    {
        private static Singleton? Instance = null;
        public string Name { get; }
        public string Description { get; }

        private Singleton(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

        public static Singleton getInstance(string Name, string Description)
        {
            if (Instance != null && Instance.Name == Name && Instance.Description == Description)
            {
                return Instance;
            }
            else
            {
                Instance = new Singleton(Name, Description);
                return Instance;
            }
        }

        public override string ToString()
        {
            return Name + " " + Description;
        }

        public static void Test(ConsoleView console)
        {
            var testSingleton = Singleton.getInstance("Singleton", "this is a Test");
            console.ConsoleWrite(testSingleton.ToString());
            if (testSingleton == Singleton.getInstance("Singleton", "this is a Test")) console.ConsoleWrite("Se sont les même instances\n");
            else console.ConsoleWrite("Se ne sont pas les même instances");
        }

    }
}
