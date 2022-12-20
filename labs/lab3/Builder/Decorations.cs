using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Builder
{
    class Decorations
    {
        public string Name { get; }
        public Decorations(string name)
        {
            this.Name = name;
        }
    }
}
