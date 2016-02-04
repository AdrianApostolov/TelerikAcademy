using System.Collections.Generic;
using Movies.Web.Infrastructure;
using Twitter.Models;

namespace Twitter.Web.ViewModels
{
    public class UserViewModel : IMapFrom<User>
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}