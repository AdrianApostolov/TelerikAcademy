using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Twitter.Models;

namespace Twitter.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Twitter.Data.TwitterDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TwitterDbContext context)
        {
            SeedRoles(context);
            SeedAdmin(context);
        }

        private void SeedRoles(TwitterDbContext context)
        {
            if (!context.Roles.Any())
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var adminRole = new IdentityRole { Name = "Admin" };
                roleManager.Create(adminRole);

                context.SaveChanges();
            }
        }

        public void SeedAdmin(TwitterDbContext context)
        {
            if (!context.Users.Any())
            {
                var userManager = new UserManager<User>(new UserStore<User>(context));

                var admin = new User()
                {
                    Email = "admin@gmail.com",
                    UserName = "admin"
                };

                userManager.Create(admin, "123456");
                userManager.AddToRole(admin.Id, "Admin");

                var user = new User()
                {
                    Email = "pesho@gmail.com",
                    UserName = "Pesho.Peshev"
                };

                userManager.Create(user, "123456");

                for (int i = 1; i <= 15; i++)
                {
                    var newTweet = new Tweet()
                    {
                        Content = "Some Tweet" + i,
                        UserId = user.Id,
                        tags = new List<Tag>() { new Tag() { Name = "Tag" + 1} }
                    };

                    context.Tweets.Add(newTweet);
                }

                context.SaveChanges();
            }
        }
    }
}
