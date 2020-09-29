using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Domain
{
    public abstract class MacaroniDecorator: Macaroni
    {
        protected Macaroni _macaroni;
        protected MacaroniDecorator(Macaroni macaroni)
        {
            _macaroni = macaroni;
        }

        public override abstract string Description();  

        public override abstract double Coast();
    }
}
