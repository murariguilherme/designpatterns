using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IObservable
    {
        public void Update(string message);
    }
}
