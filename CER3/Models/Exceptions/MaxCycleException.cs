using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Exceptions
{
    internal class MaxCycleException : Exception
    {
        public MaxCycleException(string message) { }
    }
}
