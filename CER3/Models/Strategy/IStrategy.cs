using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Strategy
{
    internal interface IStrategy
    {
        string Name { get; }
        string Description { get; }

        public string ToString();
    }
}
