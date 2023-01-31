using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Factory
{
    public interface IObject
    {
        string Name { get; }
        string Description { get; }

        public string ToString();
    }
}
