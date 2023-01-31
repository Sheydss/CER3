using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Strategy
{
    internal class Strategy2 : IStrategy
    {
        public string Name { get; }
        public string Description { get; }
        public Strategy2(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }
        public override string ToString()
        {
            return Name + " " + Description;
        }
    }
}
