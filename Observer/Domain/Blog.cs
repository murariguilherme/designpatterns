using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Domain
{
    public class Blog: ISubject
    {
        private List<IObservable> _subscribers;
        public string Url { get; set; }
        public List<Post> Posts { get; set; }
        public Blog()
        {
            this.Url = "designpatterns.com";
            this.Posts = new List<Post>();
            _subscribers = new List<IObservable>();
        }
        private string GeneratePostUrl(string blogUrl, string postUrl)
        {
            return $"https://{blogUrl}/{postUrl}";
        }
        public void Publish(Post post)
        {
            this.Posts.Add(post);
            Console.WriteLine("Post added to our web site.");
            
            var message = $"our blog has a new post! Please visit the link {GeneratePostUrl(this.Url, post.URL)} and give us a feedback!";
            this.NotifySubscribers(message);
        }

        public void AddSubscriber(IObservable observable)
        {
            if (_subscribers.Contains(observable)) return;
            _subscribers.Add(observable);
            Console.WriteLine("New subscriber on blog posts");
        }

        public void RemoveSubscriber(IObservable observable)
        {
            _subscribers.Remove(observable);
            Console.WriteLine("Someone unsubscribed from your blog");
        }

        public void NotifySubscribers(string message)
        {
            foreach (var subscriber in _subscribers)
                subscriber.Update(message);
        }
    }
}
