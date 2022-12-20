using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Builder
{
    class CarpenterBrut
    {
        public Chair Build(ChairBuilder builder)
        {
            builder.CreateChair();
            builder.SetMaterial();
            builder.SetDecorations();
            builder.SetArmset();
            return builder.Chair;
        }
    }
}
