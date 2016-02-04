using System.Collections.Generic;

namespace Twitter.Models
{
    public class Tweet
    {
        public ICollection<Tag> tags; 

        public Tweet()
        {
            this.Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public string Content { get; set; }

        public ICollection<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }
    }
}
