using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Builder
{
    class LeatherChairBuilder : ChairBuilder
    {
        public override void SetArmset()
        {
            this.Chair.Armrest = new Armrest();
        }

        public override void SetDecorations()
        {
            this.Chair.Decorations = null;
        }

        public override void SetMaterial()
        {
            this.Chair.Material = new Material("Sinner's leather");
        }
    }
}
