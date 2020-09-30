using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface ISubject
    {
        public void AddSubscriber(IObservable observable);
        public void RemoveSubscriber(IObservable observable);
        public void NotifySubscribers(string message);
    }
}
