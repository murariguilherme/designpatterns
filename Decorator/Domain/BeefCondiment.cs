using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Domain
{
    public class BeefCondiment : MacaroniDecorator
    {        
        public BeefCondiment(Macaroni macaroni): base(macaroni) { }
        public override double Coast()
        {
            return _macaroni.Coast() + 2.99;
        }

        public override string Description()
        {
            return $"{_macaroni.Description()}, with a delicious beef";
        }
    }
}
