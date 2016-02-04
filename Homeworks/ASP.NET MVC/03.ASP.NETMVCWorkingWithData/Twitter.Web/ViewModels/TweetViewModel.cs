using System.Collections.Generic;
using Movies.Web.Infrastructure;
using Twitter.Models;

namespace Twitter.Web.ViewModels
{
    public class TweetViewModel : IMapFrom<Tweet>
    {
        public int Id { get; set; }

        public User User { get; set; }

        public string Content { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}