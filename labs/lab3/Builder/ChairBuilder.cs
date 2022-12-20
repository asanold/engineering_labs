using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Builder
{
    abstract class ChairBuilder
    {
        public Chair Chair { get; private set; }
        public void CreateChair()
        {
            this.Chair = new Chair();
        }

        public abstract void SetMaterial();
        public abstract void SetDecorations();
        public abstract void SetArmset();
    }
}
