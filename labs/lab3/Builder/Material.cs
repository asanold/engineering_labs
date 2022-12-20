using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Builder
{
    class Material
    {
        public string Name { get; }
        public Material(string name)
        {
            this.Name = name;
        }
    }
}
