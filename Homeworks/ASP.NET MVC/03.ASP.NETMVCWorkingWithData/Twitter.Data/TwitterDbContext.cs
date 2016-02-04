using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Twitter.Models;

namespace Twitter.Data
{
    public class TwitterDbContext : IdentityDbContext<User>, ITwitterDbContext
    {
        public TwitterDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Tag> Tags { get; set; }
        
        public  virtual IDbSet<Tweet> Tweets { get; set; }

        public static TwitterDbContext Create()
        {
            return new TwitterDbContext();
        }
    }
}
