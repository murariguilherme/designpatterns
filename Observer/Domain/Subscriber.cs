using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Domain
{
    public class Subscriber: IObservable
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Subscriber(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
        public void Update(string message)
        {
            Console.WriteLine($"Hello {this.Name}, {message}");
        }        
    }
}
