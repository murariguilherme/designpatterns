using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Domain
{
    public class Post
    {
        public string URL { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User User { get; set; }

        public Post(string title, string body, User user)
        {
            this.URL = title.Replace(" ", "-").ToLower();
            this.Title = title;
            this.Body = body;
            this.User = user;
        }
    }
}
