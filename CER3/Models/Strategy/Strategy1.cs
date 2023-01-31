using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Strategy
{
    internal class Strategy1 : IStrategy
    {
        public string Name { get; }
        public string Description { get; }
        public Strategy1(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }
        public override string ToString()
        {
            return Description + " " + Name;
        }
    }
}
