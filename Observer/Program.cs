using Observer.Domain;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var blog = new Blog();
            var subscriber = new Subscriber("Mike", "mike2020@gmail.com");
            blog.AddSubscriber(subscriber);
            blog.AddSubscriber(new Subscriber("Veronica", "veronica@gmail.com"));
            blog.AddSubscriber(new Subscriber("Joseph", "Joseph@gmail.com"));
            Console.WriteLine();
            
            var user = new User() { Name = "Admin" };
            
            var post = user.WritePost("How to use a Observer Pattern", "I'll show you how to use a Observer Pattern in .NET Core.");
            blog.Publish(post);

            Console.WriteLine();
            blog.RemoveSubscriber(subscriber);
            Console.WriteLine();

            var post2 = user.WritePost("Other Post", "Other post to our website.");
            blog.Publish(post2);
        }
    }
}
