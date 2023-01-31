using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Bridge
{
    internal class SubObject1 : ISubObject
    {
        public string Name { get; }
        public int Type { get; } = 1;
        public SubObject1(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name + " " + Type;
        }
    }
}
