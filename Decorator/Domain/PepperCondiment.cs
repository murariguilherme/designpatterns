using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Domain
{
    public class PepperCondiment: MacaroniDecorator
    {
        public PepperCondiment(Macaroni macaroni) : base(macaroni) { }
        public override double Coast()
        {
            return _macaroni.Coast() + 0.99;
        }
        public override string Description()
        {
            return $"{_macaroni.Description()}, with pepper";
        }
    }
}
