using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Bridge
{
    internal class SubObject2 : ISubObject
    {
        public string Name { get; }
        public int Type { get; } = 2;
        public SubObject2(string name) 
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name + " " + Type;
        }
    }
}
