using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Builder
{
    class WhiteChairBuilder : ChairBuilder
    {
        public override void SetArmset()
        {
            this.Chair.Armrest = null;
        }

        public override void SetDecorations()
        {
            this.Chair.Decorations = new Decorations("Horns");
        }

        public override void SetMaterial()
        {
            this.Chair.Material = new Material("White bone");
        }
    }
}
