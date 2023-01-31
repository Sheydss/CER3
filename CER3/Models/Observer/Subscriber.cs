using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Observer
{
    internal class Subscriber
    {
        public string Name { get; } = "";

        public Subscriber() { }

        public Subscriber(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
