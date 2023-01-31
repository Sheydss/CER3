using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Bridge
{
    internal interface IObject
    {
        string Name { get; }
        public int Type { get; }
        public ISubObject subObject { get; }
        public string ToString();
    }
}
