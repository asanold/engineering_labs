using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Builder
{
    class Chair
    {
        public Material Material { get; set; }
        public Decorations Decorations { get; set; }
        public Armrest Armrest { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Material != null)
            {
                sb.Append(Material.Name + "\n");
            }
            if (Decorations != null)
            {
                sb.Append(Decorations.Name + "\n");
            }
            if (Armrest != null)
            {
                sb.Append("Armrest\n");
            }
            return sb.ToString();
        }
    }
}
