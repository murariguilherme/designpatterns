using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Domain
{
    public class User
    {
        public string Name { get; set; }
        
        public Post WritePost(string title, string body)
        {
            return new Post(title, body, this);
        }
    }
}
