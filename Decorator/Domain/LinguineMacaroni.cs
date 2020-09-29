using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Domain
{
    public class LinguineMacaroni : Macaroni
    {
        public override double Coast()
        {
            return 1.99;
        }

        public override string Description()
        {
            return "Macaroni linguine";
        }
    }
}
