using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Factory
{
    public class Object1 : IObject
    {
        public string Name { get; }
        public string Description { get; }
        public Object1(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString() 
        {
            return Name + " " + Description;
        }
    }
}
