using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Bridge
{
    internal class Object1 : IObject
    {
        public string Name { get; }
        public int Type { get; } = 1;
        public ISubObject subObject { get; }
        public Object1(string name, ISubObject subObject)
        {
            Name = name;
            this.subObject = subObject;
        }

        public override string ToString()
        {
            return Name + " " + Type + " " + subObject.ToString();
        }
    }
}
